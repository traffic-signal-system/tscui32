using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Apex.MVVM;
using tscui.ViewModels;
using Apex.Behaviours;
using System.Collections.ObjectModel;
using System.Timers;
using tscui.Models;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using tscui.Service;
using Apex;
using tscui.Views;
using tscui.Utils;

namespace tscui.Pages.Apex
{
    /// <summary>
    /// Interaction logic for ApexView.xaml
    /// </summary>
    [View(typeof(ApexViewModel))]
    public partial class ApexView : UserControl, IView
    {
        ListView myListView = null;
        GridView myGridView = null;
        UdpClient recevieUdpClient = null;
        List<TscInfo> listTscInfo = null;
        private delegate void ShowMsgCallBack(TscInfo tscInfo);
        private ShowMsgCallBack showMsgCallBack;

        TscInfo currentTI = null;


        public ApexView()
        {
            InitializeComponent();
            
            
        }
        // 显示消息回调方法
        private void ShowMsg(TscInfo tscInfo)
        {
            myListView.Items.Add(tscInfo);
        }
        /// <summary>
        /// 系统启动后，
        /// 系统自动会将在线的信号机进行搜索。并将数据填写到列表中
        /// 这个方法是处理：选中后，以后的配置的信号机都是选中的参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void myListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TscInfo ti = (TscInfo)myListView.SelectedItem;
            Application.Current.Properties[Define.TSC_INFO] = ti;
            if (ti == null)
            {
                return;
            }
            InitTscData(ti);
        }
        public void InitTscData(TscInfo ti)
        {
            TscData td = new TscData();
            Node node = new Node(ti.Ip, ti.Name, ti.Version, ti.Port);
            td.Node = node;
            // 对选中的信号机进行数据库生成
            SQLiteHelper.CreateDB("c:\\"+ti.Ip + ".db");
            Application.Current.Properties[Define.TSC_DATA] = td;
            try
            {
                td.ListSchedule = TscDataUtils.GetSchedule();
                
              
                
            }
            catch (Exception ex)
            {
                
               // string str = (string)App.Current.Resources.MergedDictionaries[3]["tsc_apex_network"];
                MessageBox.Show("时段表加载异常！");
            }
            try
            {
                td.ListPlan = TscDataUtils.GetPlan();
            }
            catch (Exception ex)
            {

                MessageBox.Show("时基表加载异常！");
            }
            try
            {
                td.ListModule = TscDataUtils.GetModule();
            }
            catch (Exception ex)
            {

                MessageBox.Show("模块表加载异常");
            }
            try
            {
                td.ListPhase = TscDataUtils.GetPhase();
            }
            catch (Exception ex)
            {

                MessageBox.Show("相位表加载异常");
            }
            try
            {
                td.ListCollision = TscDataUtils.GetCollision();
            }
            catch (Exception ex)
            {

                MessageBox.Show("相位冲突表加载异常");
            }
            try
            {
                td.ListDetector = TscDataUtils.GetDetector();
            }
            catch (Exception ex)
            {

                MessageBox.Show("检测器表加载异常");
            }
            try
            {
                td.ListChannel = TscDataUtils.GetChannel();
            }
            catch (Exception ex)
            {

                MessageBox.Show("通道表加载异常");
            }
            try
            {
                td.ListPattern = TscDataUtils.GetPattern();
            }
            catch (Exception ex)
            {

                MessageBox.Show("方案表加载异常");
            }
            try
            {
                td.ListStagePattern = TscDataUtils.GetStagePattern();
            }
            catch (Exception ex)
            {

                MessageBox.Show("阶段表加载异常");
            }
            try
            {
                td.ListOverlapPhase = TscDataUtils.GetOverlapPhase();
            }
            catch (Exception ex)
            {

                MessageBox.Show("跟随相位表加载异常");
            }
            try
            {
                td.ListPhaseToDirec = TscDataUtils.GetPhaseToDirec();
            }
            catch (Exception ex)
            {

                MessageBox.Show("方向表加载异常");
            }
            try
            {
                td.ListLampCheck = TscDataUtils.GetLampCheck();
            }
            catch (Exception ex)
            {

                MessageBox.Show("灯泡检测表加载异常");
            }


            currentTI = null;
        }
        public void RunThreadRecevie()
        {
            try
            {
                // 创建并实例化IP终端结点
                IPEndPoint ipEndPoint =
                    new IPEndPoint(IPAddress.Any, Define.BROADCAST_PORT);
                // 实例化UDP客户端（可用于实名发送和接收）
                if (recevieUdpClient == null)
                {
                    recevieUdpClient = new UdpClient(ipEndPoint);
                }
                ThreadPool.QueueUserWorkItem(AddListViewTscData);
                
            }
            catch (Exception ex)
            {
               MessageBox.Show("网络出现问题，请处理！"+ex.Message);
            }
            
        }
        private object objLock = new object();
        void AddListViewTscData(object state)
        {
            // 创建并实例化IP终端结点
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
            listTscInfo = new List<TscInfo>();
            try
                {
            // 消息接收循环
            while (true)
            {
                
                    if (recevieUdpClient == null)
                    {
                        return;
                    }
                    if (recevieUdpClient.Available > 0)
                    {
                        // 同步阻塞接收消息
                        lock (objLock)
                        {

                            byte[] byt = recevieUdpClient.Receive(ref ipEndPoint);
                            string msg = Encoding.Default.GetString(byt);
                            if (byt.Length > 6)
                            {
                                string pot1 = Convert.ToString(byt[6], 16);
                                string pot2 = Convert.ToString(byt[7], 16);
                                string tt = pot1 + pot2;
                                string tscId = Convert.ToString(byt[3]);
                                string tscName = byt[0] + "" + byt[1] + "" + byt[2] + "" + byt[3];
                                string tscIp = byt[0] + "." + byt[1] + "." + byt[2] + "." + byt[3];
                                int tscPort = Convert.ToInt32(tt, 16);
                                string tscVersion = Convert.ToString(byt[8], 10) + Convert.ToString(byt[9], 10) + Convert.ToString(byt[10], 10);
                                TscInfo titemp = new TscInfo(tscId, tscName, tscIp, tscVersion, tscPort);
                                if (currentTI == null)
                                    currentTI = titemp;
                                myListView.Dispatcher.Invoke(showMsgCallBack, titemp);
                            }
                        }
                    }
                    
                }
               
            }
            catch (Exception ex)
            {
                // 接收发生异常
                Console.WriteLine(ex.ToString());
               // MessageBox.Show("网络出现异常，请联系软件厂商！" + ex.Message);
            }
        }
        public void SendBroadCastByAllTscInfo()
        {
            // 创建IP终端结点
            try
            {
                // 广播模式（由系统自动提供广播地址）
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Broadcast, Define.BROADCAST_PORT);
                // 准备发送的数据
                byte[] sendData = Encoding.Default.GetBytes("123456");
                recevieUdpClient.Send(sendData, sendData.Length, ipEndPoint);
            }
            catch (Exception ext)
            {
                MessageBox.Show("网络出现问题，请检测网络！"+ext.Message);
            }
            
        }
      
        void atime_Elapsed(object sender, ElapsedEventArgs e)
        {

          // myListView.Items.Add()
        }
        
        public class TscInfo
        {
            private string _id;
            private string _name;
            private string _ip;
            private string _version;
            private int _port;
            public int Port
            {
                get { return _port; }
                set { _port = value; }
            }

            public string Version
            {
                get { return _version; }
                set { _version = value; }
            }
            public string Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Ip
            {
                get { return _ip; }
                set { _ip = value; }
            }

            public TscInfo(string id, string name, string ip,string version,int port)
            {
                _id = id;
                _name = name;
                _ip = ip;
                _version = version;
                _port = port;
            }
            public TscInfo()
            {
                _id = "";
                _name = "";
                _ip = "";
                _version = "";
                _port = 0;
            }
        }
 
       
        

        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
        }

        public void RefreshGridView()
        {
            myListView.Items.Clear();
            
            RunThreadRecevie();
            SendBroadCastByAllTscInfo();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myListView.Items.Clear();
            SendBroadCastByAllTscInfo();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //<SnippetListViewView>
            myListView = new ListView();
            //<SnippetGridViewColumn>

            //<SnippetGridViewAllowsColumnReorder>
            myGridView = new GridView();
            myGridView.AllowsColumnReorder = true;
            myGridView.ColumnHeaderToolTip = "Tsc Information";
            //</SnippetGridViewAllowsColumnReorder>
            ResourceDictionary rd = App.Current.Resources.MergedDictionaries[3];
            //<SnippetGridViewColumnProperties>
            GridViewColumn gvc1 = new GridViewColumn();
            gvc1.DisplayMemberBinding = new Binding("Id");
            string sid = (string)rd["tsc_apex_id"];
            gvc1.Header = sid;
            gvc1.Width = 100;
            //</SnippetGridViewColumnProperties>
            myGridView.Columns.Add(gvc1);
            GridViewColumn gvc2 = new GridViewColumn();
            gvc2.DisplayMemberBinding = new Binding("Name");
            string sname = (string)rd["tsc_apex_name"];
            gvc2.Header = sname;
            gvc2.Width = 100;
            myGridView.Columns.Add(gvc2);
            //<SnippetAddToColumns>
            GridViewColumn gvc3 = new GridViewColumn();
            gvc3.DisplayMemberBinding = new Binding("Ip");
            string sip = (string)rd["tsc_apex_ip"];
            gvc3.Header = sip;
            gvc3.Width = 100;
            myGridView.Columns.Add(gvc3);
  
            myListView.View = myGridView;
            myListView.Height = 550;
            // myListView.
            tscPanel.Children.Add(myListView);

            
            //myListView
            myListView.SelectionChanged += new SelectionChangedEventHandler(myListView_SelectionChanged);
            showMsgCallBack = new ShowMsgCallBack(ShowMsg);
            RefreshGridView();
            
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            recevieUdpClient.Close();
            if(currentTI != null)
            {
                InitTscData(currentTI);
            }
            

        }

    }
}
