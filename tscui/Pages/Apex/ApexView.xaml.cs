using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

using Apex.MVVM;
using Apex.Behaviours;
using tscui.Models;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using tscui.Service;
using Apex;
using tscui.Views;
using System.Data.SQLite;
using System.Windows.Input;

namespace tscui.Pages.Apex
{
    /// <summary>
    /// Interaction logic for ApexView.xaml
    /// </summary>
    [View(typeof(ApexViewModel))]
    public partial class ApexView : UserControl, IView
    {

        UdpClient recevieUdpClient = null;
        //  List<TscInfo> listTscInfo = null;
        private delegate void ShowMsgCallBack(TscInfo tscInfo);

        private ShowMsgCallBack showMsgCallBack;
      
        // TscInfo currentTI = null;

        public ApexView()
        {
            InitializeComponent();
            //  this.SetResourceReference(PageViewModel.TitleProperty, "tsc_menu_tsc_list");
            showMsgCallBack = new ShowMsgCallBack(ShowMsg);
        }
        private void ShowMsg(TscInfo tscInfo)
        {
            TscInfoList.Items.Add(tscInfo);
        }


        // 显示消息回调方法

        /// <summary>
        /// 系统启动后，
        /// 系统自动会将在线的信号机进行搜索。并将数据填写到列表中
        /// 这个方法是处理：选中后，以后的配置的信号机都是选中的参数

        void myListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            TscInfo ti = (TscInfo)TscInfoList.SelectedItem;
            if (ti == null) //鼠标右键单击不处理
            {
                return; ;
            }
            Application.Current.Properties[Define.TSC_INFO] = ti;
            InitTscData(ti);
           // TextIP.Text = ti.Ip;
        }
        public void InitTscData(TscInfo ti)
        {
            TscData td = new TscData();
            Node node = new Node(ti.Ip, ti.Name, ti.Version, ti.Port);
            td.Node = node;
            Application.Current.Resources["tscinfo"] = "当前信号机IP地址:" + ti.Ip + "       端口号:" + ti.Port + "       版本:" + ti.Version;
            Application.Current.Properties[Define.TSC_DATA] = td;

            // 对选中的信号机进行数据库生成
            try
            {
                td.ListSchedule = TscDataUtils.GetSchedule();
                if (td.ListSchedule == null)
                {
                    //  MessageBox.Show("信号机数据加载失败!!!","信号机",MessageBoxButton.OK,MessageBoxImage.Error);
                    Application.Current.Resources["tscinfo"] = "当前信号机时段数据加载失败,请检查网络或者配置文件是否正常!";

                    Application.Current.Properties[Define.TSC_DATA] = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机数据加载异常!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                Application.Current.Properties[Define.TSC_DATA] = null;
                return;
            }
            try
            {
                td.ListPlan = TscDataUtils.GetPlan();
                if (td.ListPlan == null)
                {
                    MessageBox.Show("信号机时基表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机时基表加载异常!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);
               // return;
            }
         
            try
            {
                td.ListPhase = TscDataUtils.GetPhase();
                if (td.ListPhase == null)
                {
                    MessageBox.Show("信号机相位表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机相位表加载异常!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            try
            {
                td.ListCollision = TscDataUtils.GetCollision();
                if (td.ListCollision == null)
                {
                    MessageBox.Show("信号机加载相位冲突表失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机相位冲突表加载异常!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
            try
            {
                td.ListDetector = TscDataUtils.GetDetector();
                if (td.ListDetector == null)
                {
                    MessageBox.Show("信号机检测器表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机检测器表加载异常!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
            try
            {
                td.ListChannel = TscDataUtils.GetChannel();
                if (td.ListChannel == null)
                {
                    MessageBox.Show("信号机通道表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机通道表加载异常!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                return;
            }
            try
            {
                td.ListPattern = TscDataUtils.GetPattern();

                if (td.ListPattern == null)
                {
                    MessageBox.Show("信号机方案表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机方案表加载异常!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            try
            {
                td.ListStagePattern = TscDataUtils.GetStagePattern();
                if (td.ListStagePattern == null)
                {
                    MessageBox.Show("信号机阶段配时表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机阶段配时表加载异常!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            try
            {
                td.ListOverlapPhase = TscDataUtils.GetOverlapPhase();
                if (td.ListOverlapPhase == null)
                {
                    MessageBox.Show("信号机跟随相位表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机跟随相位表加载异常!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
            try
            {
                td.ListPhaseToDirec = TscDataUtils.GetPhaseToDirec();
                if (td.ListPhaseToDirec == null)
                {
                    MessageBox.Show("信号机相位方向表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机相位方向表加载异常!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
            try
            {
                td.ListLampCheck = TscDataUtils.GetLampCheck();
                if (td.ListLampCheck == null)
                {
                    MessageBox.Show("信号机灯泡检测表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机灯泡检测表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
            try
            {
                td.ListCntDownDev = TscDataUtils.GetCntDown();
                if (td.ListCntDownDev == null)
                {
                    MessageBox.Show("信号机倒计时配置表加载失败!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机倒计时配置表加载异常!!!", "信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
          
        }
        public void RunThreadRecevie()
        {
            try
            {
                // 创建并实例化IP终端结点
                IPEndPoint ipEndPoint =new IPEndPoint(IPAddress.Any, 8899);
                // 实例化UDP客户端（可用于实名发送和接收）
                if (recevieUdpClient == null)
                {
                    recevieUdpClient = new UdpClient(ipEndPoint);
                }
                ThreadPool.QueueUserWorkItem(AddListViewTscData);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机网络接收异常,检查网络!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            
        }
        private object objLock = new object();
        void AddListViewTscData(object state)
        {
            // 创建并实例化IP终端结点
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 0);
          //  listTscInfo = new List<TscInfo>();
            try
                {
            // 消息接收循环
            while (true)
            {
                    if (recevieUdpClient == null)
                    {
                      //  MessageBox.Show("退出广播接收线程!", "信号机", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    if (recevieUdpClient.Available > 0)
                    {
                        // 同步阻塞接收消息
                        lock (objLock)
                        {
                            byte[] byt = recevieUdpClient.Receive(ref ipEndPoint);
                            string msg = Encoding.Default.GetString(byt);
                            if (byt.Length == 0xB)
                            {
                                string pot1 = Convert.ToString(byt[6], 16);
                                string pot2 = Convert.ToString(byt[7], 16);
                                string tt = pot1 + pot2;
                                string tscId = Convert.ToString(byt[3]);
                                string tscName = "网络搜索在线信号机";
                                string tscIp = byt[0] + "." + byt[1] + "." + byt[2] + "." + byt[3];
                                int tscPort = Convert.ToInt32(tt, 16);
                                string tscVersion = "TscV32";//(byt[8] == 0x0 ? "未知版本" : ((byt[8] == 0x1 ? "V16" : "V32") + String.Format("{0:X}", byt[9]) + String.Format("{0:D2}", byt[10])));

                                TscInfo titemp = new TscInfo(tscId, tscName, tscIp, tscVersion, tscPort);
                                TscInfoList.Dispatcher.Invoke(showMsgCallBack, titemp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void SendBroadCastByAllTscInfo()
        {
            // 创建IP终端结点
            try
            {
              // 广播模式（由系统自动提供广播地址）
              //  IPAddress broadAddress = IPAddress.Parse("192.168.255.255");
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Broadcast, Define.BROADCAST_PORT);
                // 准备发送的数据
                byte[] sendData = Encoding.Default.GetBytes("123456");
                recevieUdpClient.Send(sendData, sendData.Length, ipEndPoint);}
            catch (Exception ext)
            {
                MessageBox.Show("网络广播出现问题,请检测网络!" + ext.Message, "信号机", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
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
            TscInfoList.Items.Clear();
            RunThreadRecevie();
            SendBroadCastByAllTscInfo();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (TscInfoList.Items.Count>0)
                TscInfoList.Items.Clear();
            Application.Current.Properties[Define.TSC_DATA] = null;
            Application.Current.Resources["tscinfo"] ="当前信号机IP地址:000.000.000.000      端口号:0000       版本:0000";
            SendBroadCastByAllTscInfo();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
           // showMsgCallBack = new ShowMsgCallBack(ShowMsg);
            RefreshGridView();
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
             recevieUdpClient.Close();      
            //if(currentTI != null)
            //{
            //    InitTscData(currentTI);
            //}
        }


        private void AddTscNode(object sender, RoutedEventArgs e)
        {
         
            ApexBroker.GetShell().ShowPopup(new TscNode(1));
            LoadTscNode(null, null);
        }

        private void LoadTscNode(object sender, RoutedEventArgs e)
        {
            TscInfoList.Items.Clear();     
                
            using (SQLiteDataReader reader = Utils.SQLiteHelper.ExecuteReader("select * from Tbl_TscNode", null))
            {
                while (reader.Read())
                {
                    TscInfo titemp = new TscInfo(reader.GetInt32(0).ToString(), reader.GetString(2), reader.GetString(1), reader.GetString(3), 5435);
                    TscInfoList.Dispatcher.Invoke(showMsgCallBack, titemp);
                }
            }

        }

        private void AlterTscNode(object sender, RoutedEventArgs e)
        {
            TscInfo ti = (TscInfo)TscInfoList.SelectedItem;
            if (ti == null)
            {
                return; ;
            }
            ApexBroker.GetShell().ShowPopup(new TscNode(2, Convert.ToInt32(ti.Id),ti.Ip,ti.Name));
            LoadTscNode(null, null);
        }
            

        private void DelTscNode(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgBoxResult = MessageBox.Show("确定要删除该信号机吗?", "删除信号机", MessageBoxButton.YesNo,
                   MessageBoxImage.Question);
            if (msgBoxResult == MessageBoxResult.No)
                return;
            else
            {
                TscInfo ti = (TscInfo)TscInfoList.SelectedItem;
                if (ti == null) //鼠标右键单击不处理
                {
                    MessageBox.Show("请选择需要删除信号机", "删除信号机", MessageBoxButton.OK);
                    return; ;
                }
                string sql = "delete from Tbl_TscNode where ucId = @ID";
                SQLiteParameter[] parameters = new SQLiteParameter[]
                {                    
                     new SQLiteParameter("@ID",Convert.ToInt32(ti.Id))
                };
                Utils.SQLiteHelper.ExecuteNonQuery(sql, parameters);
                MessageBox.Show("删除信号机成功", "删除信号机", MessageBoxButton.OK);
                LoadTscNode(null, null);
            }
        }
    }
}
