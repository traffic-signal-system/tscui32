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
using tscui.Models;

using tscui.Views;
using System.Windows.Threading;
using System.Threading;
using Xceed.Wpf.Toolkit;
using tscui.Service;

namespace tscui.Pages.Music
{
    /// <summary>
    /// Interaction logic for MusicView.xaml
    /// </summary>
    [View(typeof(MusicViewModel))]
    public partial class MusicView : UserControl, IView
    {
        TscData t;
        int currentPhaseId = 0;
        public MusicView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
        }
        private delegate void DelegateInitPhaseType();
        private void DispatcherInitPhaseType()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitPhaseType(InitPhaseType));
        }

        private delegate void DelegatePhaseOption();
        private void DispatcherPhaseOption()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegatePhaseOption(InitPhaseOption));
        }
        private delegate void DelegateOverlapPhaseType();
        private void DispatcherOverlapPhaseType()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateOverlapPhaseType(InitOverlapPhaseType));
        }

        private delegate void DelegateOverlap();
        private void DispatcherOverlap()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateOverlap(InitOverlap));
        }

        class ChannelFlash
        {
            public int value{ set; get; }
            public string name{ set; get; }
        }
        class ChannelType
        {
            public int value { set; get; }
            public string name { set; get; }
        }
        List<ChannelType> lct = new List<ChannelType>();
        List<ChannelFlash> lcf = new List<ChannelFlash>();
        private void InitChannel()
        {
            lct.Add(new ChannelType() { name = "其它", value = 1 });
            lct.Add(new ChannelType() { name = "机动车", value = 2 });
            lct.Add(new ChannelType() { name = "行人", value = 3 });
            lct.Add(new ChannelType() { name = "跟随相位", value = 4 });

            lcf.Add(new ChannelFlash() { name = "红灯闪(前半秒)", value = 4 });
            lcf.Add(new ChannelFlash() { name = "红灯闪(后半秒)", value = 12 });
            lcf.Add(new ChannelFlash() { name = "黄灯闪(前半秒)", value = 2 });
            lcf.Add(new ChannelFlash() { name = "黄灯闪(后半秒)", value = 10 });
            lcf.Add(new ChannelFlash() { name = "未设置", value = 0 });

            cbxChannelType.ItemsSource = lct;
            cbxAutoFlash.ItemsSource = lcf;
        }

        List<PhaseType> lpt = new List<PhaseType>();
        private void InitPhaseType()
        {
            
            lpt.Add(new PhaseType() { typeName = "固定相位", ucType = 0x80 });
            lpt.Add(new PhaseType() { typeName = "特定相位", ucType = 0x40 });
            lpt.Add(new PhaseType() { typeName = "弹性相位", ucType = 0x20 });
            lpt.Add(new PhaseType() { typeName = "关键相位", ucType = 0x10 });
            lpt.Add(new PhaseType() { typeName = "未知", ucType = 0 });
            cbxPhaseType.ItemsSource = lpt;
        }
        List<PhaseOption> lpo = new List<PhaseOption>();
        private void InitPhaseOption()
        {
            
            lpo.Add(new PhaseOption() { optionName = "同阶放行", ucOption = 0x10 });
            lpo.Add(new PhaseOption() { optionName = "人车放行", ucOption = 0x08 });
            lpo.Add(new PhaseOption() { optionName = "特定相位出现", ucOption = 0x04 });
            lpo.Add(new PhaseOption() { optionName = "人行过街相位", ucOption = 0x02 });
            lpo.Add(new PhaseOption() { optionName = "相位启用", ucOption = 0x01 });
            lpo.Add(new PhaseOption() { optionName = "未知", ucOption = 0 });
            cbxPhaseOption.ItemsSource = lpo;
        }

        List<OverlapPhaseType> lopt = new List<OverlapPhaseType>();
        private void InitOverlapPhaseType()
        {
            
            lopt.Add(new OverlapPhaseType() { name = "其它", value = 1 });
            lopt.Add(new OverlapPhaseType() { name = "正常", value = 2 });
            lopt.Add(new OverlapPhaseType() { name = "最小绿灯黄灯", value = 3 });
            lopt.Add(new OverlapPhaseType() { name = "未知", value = 0 });
            cbxOperateType.ItemsSource = lopt;

        }
        List<ChannelPhaseOverlap> lcpo = new List<ChannelPhaseOverlap>();
        public class ChannelPhaseOverlap
        {
            public int id { set; get; }
            public string name { set; get; }
            public bool isPhase { set; get; }
        }
        private void InitOverlap()
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();

            List<tscui.Models.Phase> lp = t.ListPhase;
            ccbIncludePhase1.ItemsSource = lp;
            
            ccbCorrectPhase.ItemsSource = lp;
            for (int a = 1; a < 33;a++ )
                lcpo.Add(new ChannelPhaseOverlap() { id = a, name = "p"+a ,isPhase=true});
            for (int b = 1; b < 17; b++)
                lcpo.Add(new ChannelPhaseOverlap() { id = b, name = "op" + b ,isPhase=false});


            channel1.ItemsSource = lcpo;
            channel2.ItemsSource = lcpo;
            channel3.ItemsSource = lcpo;
            channel4.ItemsSource = lcpo;
            channel5.ItemsSource = lcpo;
            channel6.ItemsSource = lcpo;
            channel7.ItemsSource = lcpo;
            channel8.ItemsSource = lcpo;
            channel9.ItemsSource = lcpo;
            channel10.ItemsSource = lcpo;
            channel11.ItemsSource = lcpo;
            channel12.ItemsSource = lcpo;
            channel13.ItemsSource = lcpo;
            channel14.ItemsSource = lcpo;
            channel15.ItemsSource = lcpo;
            channel16.ItemsSource = lcpo;
            channel17.ItemsSource = lcpo;
            channel18.ItemsSource = lcpo;
            channel19.ItemsSource = lcpo;
            channel20.ItemsSource = lcpo;
            channel21.ItemsSource = lcpo;
            channel22.ItemsSource = lcpo;
            channel23.ItemsSource = lcpo;
            channel24.ItemsSource = lcpo;
            channel25.ItemsSource = lcpo;
            channel26.ItemsSource = lcpo;
            channel27.ItemsSource = lcpo;
            channel28.ItemsSource = lcpo;
            channel29.ItemsSource = lcpo;
            channel30.ItemsSource = lcpo;
            channel31.ItemsSource = lcpo;
            channel32.ItemsSource = lcpo;

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
              //  System.Windows.MessageBox.Show("请选择一台信号机后，再进行配置！");
               // return;
            }
            //下拉框数据填充
            Thread tDispatcherOverlap = new Thread(DispatcherOverlap);
            tDispatcherOverlap.IsBackground = true;
            tDispatcherOverlap.Start();
            Thread tDispatcherOverlapPhaseType = new Thread(DispatcherOverlapPhaseType);
            tDispatcherOverlapPhaseType.IsBackground = true;
            tDispatcherOverlapPhaseType.Start();
            Thread tDispatcherPhaseOption = new Thread(DispatcherPhaseOption);
            tDispatcherPhaseOption.IsBackground = true;
            tDispatcherPhaseOption.Start();
            Thread tDispatcherInitPhaseType = new Thread(DispatcherInitPhaseType);
            tDispatcherInitPhaseType.IsBackground = true;
            tDispatcherInitPhaseType.Start();
            InitChannel();
            //初始化显示相位数据与通道关联
            InitPhaseChannel();
            

        }

        private void InitPhase(tscui.Models.Channel c)
        {
            if (c.ucId == 1)
            {
                channel1.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel1.Background = Brushes.Red;
            }
            else if (c.ucId == 2)
            {
                channel2.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel2.Background = Brushes.Red;
            }
            else if (c.ucId == 3)
            {
                channel3.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel3.Background = Brushes.Red;
            }
            else if (c.ucId == 4)
            {
                channel4.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel4.Background = Brushes.Red;
            }
            else if (c.ucId == 5)
            {
                channel5.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel5.Background = Brushes.Red;
            }
            else if (c.ucId == 6)
            {
                channel6.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel6.Background = Brushes.Red;
            }
            else if (c.ucId == 7)
            {
                channel7.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel7.Background = Brushes.Red;
            }
            else if (c.ucId == 8)
            {
                channel8.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel8.Background = Brushes.Red;
            }
            else if (c.ucId == 9)
            {
                channel9.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel9.Background = Brushes.Red;
            }
            else if (c.ucId == 10)
            {
                channel10.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel10.Background = Brushes.Red;
            }
            else if (c.ucId == 11)
            {
                channel11.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel11.Background = Brushes.Red;
            }
            else if (c.ucId == 12)
            {
                channel12.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel12.Background = Brushes.Red;
            }
            else if (c.ucId == 13)
            {
                channel13.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel13.Background = Brushes.Red;
            }
            else if (c.ucId == 14)
            {
                channel14.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel14.Background = Brushes.Red;
            }
            else if (c.ucId == 15)
            {
                channel15.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel15.Background = Brushes.Red;
            }
            else if (c.ucId == 16)
            {
                channel16.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel16.Background = Brushes.Red;
            }
            else if (c.ucId == 17)
            {
                channel17.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel17.Background = Brushes.Red;
            }
            else if (c.ucId == 18)
            {
                channel18.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel18.Background = Brushes.Red;
            }
            else if (c.ucId == 19)
            {
                channel19.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel19.Background = Brushes.Red;
            }
            else if (c.ucId == 20)
            {
                channel20.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel20.Background = Brushes.Red;
            }
            else if (c.ucId == 21)
            {
                channel21.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel21.Background = Brushes.Red;
            }
            else if (c.ucId == 22)
            {
                channel22.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel22.Background = Brushes.Red;
            }
            else if (c.ucId == 23)
            {
                channel23.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel23.Background = Brushes.Red;
            }
            else if (c.ucId == 24)
            {
                channel24.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel24.Background = Brushes.Red;
            }
            else if (c.ucId == 25)
            {
                channel25.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel25.Background = Brushes.Red;
            }
            else if (c.ucId == 26)
            {
                channel26.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel26.Background = Brushes.Red;
            }
            else if (c.ucId == 27)
            {
                channel27.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel27.Background = Brushes.Red;
            }
            else if (c.ucId == 28)
            {
                channel28.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel28.Background = Brushes.Red;
            }
            else if (c.ucId == 29)
            {
                channel29.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel29.Background = Brushes.Red;
            }
            else if (c.ucId == 30)
            {
                channel30.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel30.Background = Brushes.Red;
            }
            else if (c.ucId == 31)
            {
                channel31.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel31.Background = Brushes.Red;
            }
            else if (c.ucId == 32)
            {
                channel32.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel32.Background = Brushes.Red;
            }
        }
        private void InitOverlapPhase(Channel c)
        {
            if (c.ucId == 1)
            {
                channel1.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel1.Background = Brushes.Yellow;
            }
            else if (c.ucId == 2)
            {
                channel2.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel2.Background = Brushes.Yellow;
            }
            else if (c.ucId == 3)
            {
                channel3.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel3.Background = Brushes.Yellow;
            }
            else if (c.ucId == 4)
            {
                channel4.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel4.Background = Brushes.Yellow;
            }
            else if (c.ucId == 5)
            {
                channel5.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel5.Background = Brushes.Yellow;
            }
            else if (c.ucId == 6)
            {
                channel6.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel6.Background = Brushes.Yellow;
            }
            else if (c.ucId == 7)
            {
                channel7.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel7.Background = Brushes.Yellow;
            }
            else if (c.ucId == 8)
            {
                channel8.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel8.Background = Brushes.Yellow;
            }
            else if (c.ucId == 9)
            {
                channel9.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel9.Background = Brushes.Yellow;
            }
            else if (c.ucId == 10)
            {
                channel10.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel1.Background = Brushes.Yellow;
            }
            else if (c.ucId == 11)
            {
                channel11.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel11.Background = Brushes.Yellow;
            }
            else if (c.ucId == 12)
            {
                channel12.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel12.Background = Brushes.Yellow;
            }
            else if (c.ucId == 13)
            {
                channel13.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel13.Background = Brushes.Yellow;
            }
            else if (c.ucId == 14)
            {
                channel14.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel14.Background = Brushes.Yellow;
            }
            else if (c.ucId == 15)
            {
                channel15.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel15.Background = Brushes.Yellow;
            }
            else if (c.ucId == 16)
            {
                channel16.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel16.Background = Brushes.Yellow;
            }
        }

        private void InitPedePhase(Channel c)
        {
            if (c.ucId == 1)
            {
                channel1.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel1.Background = Brushes.Green;
            }
            else if (c.ucId == 2)
            {
                channel2.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel2.Background = Brushes.Green;
            }
            else if (c.ucId == 3)
            {
                channel3.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel3.Background = Brushes.Green;
            }
            else if (c.ucId == 4)
            {
                channel4.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel4.Background = Brushes.Green;
            }
            else if (c.ucId == 5)
            {
                channel5.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel5.Background = Brushes.Green;
            }
            else if (c.ucId == 6)
            {
                channel6.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel6.Background = Brushes.Green;
            }
            else if (c.ucId == 7)
            {
                channel7.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel7.Background = Brushes.Green;
            }
            else if (c.ucId == 8)
            {
                channel8.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel8.Background = Brushes.Green;
            }
            else if (c.ucId == 9)
            {
                channel9.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel9.Background = Brushes.Green;
            }
            else if (c.ucId == 10)
            {
                channel10.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel10.Background = Brushes.Green;
            }
            else if (c.ucId == 11)
            {
                channel11.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel11.Background = Brushes.Green;
            }
            else if (c.ucId == 12)
            {
                channel12.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel12.Background = Brushes.Green;
            }
            else if (c.ucId == 13)
            {
                channel13.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel13.Background = Brushes.Green;
            }
            else if (c.ucId == 14)
            {
                channel14.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel14.Background = Brushes.Green;
            }
            else if (c.ucId == 15)
            {
                channel15.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel15.Background = Brushes.Green;
            }
            else if (c.ucId == 16)
            {
                channel16.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel16.Background = Brushes.Green;
            }
            else if (c.ucId == 17)
            {
                channel17.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel17.Background = Brushes.Green;
            }
            else if (c.ucId == 18)
            {
                channel18.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel18.Background = Brushes.Green;
            }
            else if (c.ucId == 19)
            {
                channel19.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel19.Background = Brushes.Green;
            }
            else if (c.ucId == 20)
            {
                channel20.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel20.Background = Brushes.Green;
            }
            else if (c.ucId == 21)
            {
                channel21.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel21.Background = Brushes.Green;
            }
            else if (c.ucId == 22)
            {
                channel22.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel22.Background = Brushes.Green;
            }
            else if (c.ucId == 23)
            {
                channel23.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel23.Background = Brushes.Green;
            }
            else if (c.ucId == 24)
            {
                channel24.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel24.Background = Brushes.Green;
            }
            else if (c.ucId == 25)
            {
                channel25.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel25.Background = Brushes.Green;
            }
            else if (c.ucId == 26)
            {
                channel26.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel26.Background = Brushes.Green;
            }
            else if (c.ucId == 27)
            {
                channel27.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel27.Background = Brushes.Green;
            }
            else if (c.ucId == 28)
            {
                channel28.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel28.Background = Brushes.Green;
            }
            else if (c.ucId == 29)
            {
                channel29.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel29.Background = Brushes.Green;
            }
            else if (c.ucId == 30)
            {
                channel30.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel30.Background = Brushes.Green;
            }
            else if (c.ucId == 31)
            {
                channel31.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel31.Background = Brushes.Green;
            }
            else if (c.ucId == 32)
            {
                channel32.SelectedIndex = c.ucSourcePhase - 1;
                lblChannel32.Background = Brushes.Green;
            }
        }
        public void InitPhaseChannel()
        {
            List<tscui.Models.Phase> phases = t.ListPhase;
            List<tscui.Models.Channel> channels = t.ListChannel;
            foreach (tscui.Models.Channel c in channels)
            {
                if(c.ucType == 1){//其它 

                }else if(c.ucType ==2 ){//机动车相位
                    InitPhase(c);
                }else if (c.ucType ==3){ // 人行相位
                    InitPedePhase(c);
                }else if(c.ucType == 4){    //跟随相位
                    InitOverlapPhase(c);
                }
                
            }
        }

        private void PedestrainClearTime_Spin(object sender, Xceed.Wpf.Toolkit.SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();

        }

        private void PedestrainCrossTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrGreenTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrYellowTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrRedTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }
        private void displayPhase(int pid, List<tscui.Models.Phase> lp)
        {
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == pid)
                {
                    cbxPhaseType.SelectedItem = p.ucType;
                    cbxPhaseOption.SelectedItem = p.ucOption;
                    TextBox tbpc = (TextBox)bsrPedestrainCrossTime.Content;
                    tbpc.Text = Convert.ToString(p.ucPedestrianGreen);
                    TextBox tbpct = (TextBox)bsrPedestrainClearTime.Content;
                    tbpct.Text = Convert.ToString(p.ucPedestrianClear);
                    TextBox tbGreenFlash = (TextBox)bsrGreenFlash.Content;
                    tbGreenFlash.Text = Convert.ToString(p.ucGreenFlash);
                    TextBox tbMax2Time = (TextBox)bsrMax2Time.Content;
                    tbMax2Time.Text = Convert.ToString(p.ucMaxGreen2);
                    TextBox tbMax1Time = (TextBox)bsrMax1Time.Content;
                    tbMax1Time.Text = Convert.ToString(p.ucMaxGreen1);
                    TextBox tbUintDelayTime = (TextBox)bsrUintDelayTime.Content;
                    tbUintDelayTime.Text = Convert.ToString(p.ucGreenDelayUnit);
                    TextBox tbFixedGreenTime = (TextBox)bsrFixedGreenTime.Content;
                    tbFixedGreenTime.Text = Convert.ToString(p.ucFixedGreen);
                    TextBox tbMinGreenTime = (TextBox)bsrMinGreenTime.Content;
                    tbMinGreenTime.Text = Convert.ToString(p.ucMinGreen);


                }
            }
        }


        private void bsrMax2Time_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrMax1Time_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrUintDelayTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrFixedGreenTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrMinGreenTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void bsrGreenFlash_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == Xceed.Wpf.Toolkit.SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }

        }

        private void tbxPedestrainCrossTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxGreenFlash_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxMax2Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxMax1Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxUintDelayTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxFixedGreenTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxMinGreenTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucPedestrianClear = Convert.ToByte(tb.Text);
                }
            }
        }

        private void cbxPhaseOption_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            ComboBox cb = sender as ComboBox;
            PhaseOption po = (PhaseOption)cb.SelectedValue;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucType = Convert.ToByte(po.ucOption);
                }
            }
        }
        private void SetIncludePhaseToOverlapPhase(CheckComboBox ccb, int pUcId)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == pUcId)
                {
                    List<byte> lb = new List<byte>();
                    foreach (Object o in ccb.SelectedItems)
                    {
                        tscui.Models.Phase po = (tscui.Models.Phase)o;
                        lb.Add(po.ucId);//po.ucId
                    }
                    op.ucIncludePhase = lb.ToArray<byte>();
                }
            }
        }
        private void cbxPhaseType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<tscui.Models.Phase> lp = t.ListPhase;
            ComboBox cb = sender as ComboBox;
            PhaseType pt = (PhaseType)cb.SelectedValue;
            foreach (tscui.Models.Phase p in lp)
            {
                if (p.ucId == currentPhaseId)
                {
                    p.ucType = Convert.ToByte(pt.ucType);
                }
            }
        }
        private void SetCorrectPhaseToOverlapPhase(CheckComboBox ccb, int opUcId)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == opUcId)
                {
                    List<byte> lb = new List<byte>();
                    foreach (Object o in ccb.SelectedItems)
                    {
                        tscui.Models.Phase po = (tscui.Models.Phase)o;
                        lb.Add(po.ucId);//po.ucId
                    }
                    op.ucCorrectPhase = lb.ToArray<byte>();
                }
            }
        }
       
        private void SetOverlapPhaseToChannel(ComboBox cb, byte id)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Channel cc = (Channel)cb.SelectedValue;
            byte cId = Convert.ToByte(cc.ucId);
            List<Channel> lc = t.ListChannel;
            foreach (Channel c in lc)
            {
                if (c.ucId == cId)
                {
                    c.ucSourcePhase = id;
                }
            }
        }
        private void cbxOverlapPhaseChannel1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            //string v = (string)cb.SelectedValue;
            //string v1 = (string)cb.SelectedItem;
            //int v2 = cb.SelectedIndex;
            //string v11 = (string)cb.Text;
            SetOverlapPhaseToChannel(cb, 1);

        }

        private void cbxOverlapPhaseChannel2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 2);
        }

        private void cbxOverlapPhaseChannel3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 3);
        }

        private void cbxOverlapPhaseChannel4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 4);
        }

        private void cbxOverlapPhaseChannel5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 5);
        }

        private void cbxOverlapPhaseChannel6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 6);
        }

        private void cbxOverlapPhaseChannel7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 7);
        }

        private void cbxOverlapPhaseChannel8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 8);
        }

        private void cbxOverlapPhaseChannel9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 9);
        }

        private void cbxOverlapPhaseChannel10_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 10);
        }

        private void cbxOverlapPhaseChannel11_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 11);
        }

        private void cbxOverlapPhaseChannel12_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 12);
        }

        private void cbxOverlapPhaseChannel13_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 13);
        }

        private void cbxOverlapPhaseChannel14_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 14);
        }

        private void cbxOverlapPhaseChannel15_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 15);
        }

        private void cbxOverlapPhaseChannel16_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SetOverlapPhaseToChannel(cb, 16);
        }
        private byte currentOverlapPhase = 0;
        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == currentOverlapPhase)
                {
                    op.ucTailGreen = Convert.ToByte(tb.Text);
                }
            }
        }

        private void TextBox_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == currentOverlapPhase)
                {
                    op.ucTailYellow = Convert.ToByte(tb.Text);
                }
            }
        }

        private void tbxTailRed_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == currentOverlapPhase)
                {
                    op.ucTailRed = Convert.ToByte(tb.Text);
                }
            }
        }

        private void cbxOperateType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            OverlapPhaseType opt = (OverlapPhaseType)cb.SelectedValue;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == currentOverlapPhase)
                {
                    op.ucTailRed = Convert.ToByte(opt.value);
                }
            }
        }
        private void DisplayOverlapPhase(RadioButton rb, List<OverlapPhase> lop)
        {
            foreach (OverlapPhase op in lop)
            {
                if (op.ucId == Convert.ToByte(rb.Content))
                {
                    tbxTailGreen.Text = Convert.ToString(op.ucTailGreen);
                    tbxYellowTime.Text = Convert.ToString(op.ucTailYellow);
                    tbxRedTime.Text = Convert.ToString(op.ucTailRed);
                    cbxOperateType.SelectedValue = op.ucOperateType;
                }
            }
        }
        private void DisplayOverlapPhase(byte id)
        {
            try
            {
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                foreach (OverlapPhase op in t.ListOverlapPhase)
                {
                    if (id == 1)
                    {
                        for (int a = 0; a < op.ucIncludePhase.Length; a++)
                        {
                            if (op.ucIncludePhase[a] != 0)
                            {
                                ccbIncludePhase1.Items.Add(op.ucIncludePhase[a]);
                            }
                        }
                        for (int a = 0; a < op.ucCorrectPhase.Length; a++)
                        {
                            if (op.ucCorrectPhase[a] != 0)
                            {
                                ccbCorrectPhase.Items.Add(op.ucCorrectPhase[a]);
                            }
                        }
                        tbxYellowTime.Text = Convert.ToString(op.ucTailYellow);
                        tbxRedTime.Text = Convert.ToString(op.ucTailRed);
                        tbxTailGreen.Text = Convert.ToString(op.ucTailGreen);
                        cbxOperateType.SelectedValue = op.ucOperateType;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        private void ClearPhaseContentById()
        {
            try
            {
                tbxFixedGreenTime.Text = "";
                tbxGreenFlash.Text = "";
                tbxMax1Time.Text = "";
                tbxMax2Time.Text = "";
                tbxMinGreenTime.Text = "";

                // cbxPhaseOption.SelectedItem = po;

                tbxPedestrainClearTime.Text = "";
                tbxPedestrainCrossTime.Text = "";

                //cbxPhaseType.SelectedItem = pt;
            }
            catch (Exception ex)
            {

            }
           
               
        }
        private void tbxPhaseId_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                System.Windows.MessageBox.Show("请选择一个信号机，再进行配置！");
                return;
            }
            List<tscui.Models.Phase> phases = t.ListPhase;
            ClearPhaseContentById();
            if (Byte.Parse(tbxPhaseId.Text) != 0)
            {
                ClearPhaseContentById();
                foreach (tscui.Models.Phase p in phases)
                {
                    if (p.ucId == Byte.Parse(tbxPhaseId.Text))
                    {

                        tbxFixedGreenTime.Text = "" + p.ucFixedGreen;
                        tbxGreenFlash.Text = "" + p.ucGreenFlash;
                        tbxMax1Time.Text = "" + p.ucMaxGreen1;
                        tbxMax2Time.Text = "" + p.ucMaxGreen2;
                        tbxMinGreenTime.Text = "" + p.ucMinGreen;
                        foreach (PhaseOption po in lpo)
                        {
                            if (po.ucOption == p.ucOption)
                            {
                                cbxPhaseOption.SelectedItem = po;
                            }
                        }

                        tbxPedestrainClearTime.Text = "" + p.ucPedestrianClear;
                        tbxPedestrainCrossTime.Text = "" + p.ucPedestrianGreen;
                        foreach (PhaseType pt in lpt)
                        {
                            if (pt.ucType == p.ucType)
                            {
                                cbxPhaseType.SelectedItem = pt;
                            }
                        }


                    }
                }
            }
            
        }
        private void ClearOverlapContentById()
        {
          //  ccbCorrectPhase.SelectedItemsOverride = new List<tscui.Models.Phase>();
           // ccbIncludePhase1.SelectedItemsOverride = new List<tscui.Models.Phase>();
            tbxTailGreen.Text = "";
            tbxRedTime.Text = "";
            tbxYellowTime.Text = "";
        }
        private void tbxOverlapPhaseId_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                System.Windows.MessageBox.Show("请选择一台信号机后，再进行配置！");
                return;
            }
            List<tscui.Models.OverlapPhase> overlapPhases = t.ListOverlapPhase;
            List<tscui.Models.Phase> phases = t.ListPhase;
            if (Byte.Parse(tbxOverlapPhaseId.Text) != 0)
            {
                ClearOverlapContentById();
                foreach (tscui.Models.OverlapPhase op in overlapPhases)
                {
                    if (op.ucId == Byte.Parse(tbxOverlapPhaseId.Text))
                    {
                        List<tscui.Models.Phase> listCorrect = new List<tscui.Models.Phase>();
                        for (int i = 0; i < op.ucCorrectPhase.Length; i++)
                        {
                            foreach (tscui.Models.Phase phase in phases)
                            {
                                if (op.ucCorrectPhase[i] == phase.ucId)
                                    listCorrect.Add(phase);
                            }

                        }

                      //  ccbCorrectPhase.SelectedItemsOverride = listCorrect;

                        List<tscui.Models.Phase> listInclude = new List<tscui.Models.Phase>();
                        for (int j = 0; j < op.ucIncludePhase.Length; j++)
                        {
                            foreach (tscui.Models.Phase phase in phases)
                            {
                                if (op.ucIncludePhase[j] == phase.ucId)
                                    listInclude.Add(phase);
                            }

                        }
                      //  ccbIncludePhase1.SelectedItemsOverride = listInclude;
                        foreach (OverlapPhaseType opt in lopt)
                        {
                            if (opt.value == op.ucOperateType)
                            {
                                cbxOperateType.SelectedItem = opt;
                            }
                        }

                        tbxTailGreen.Text = "" + op.ucTailGreen;
                        tbxRedTime.Text = "" + op.ucTailRed;
                        tbxYellowTime.Text = "" + op.ucTailYellow;

                    }
                }
            }
            
        }
        private void ClearChannelContentById()
        {
            cbxAutoFlash.SelectedItem = new ChannelFlash();
            cbxChannelType.SelectedItem = new  ChannelType();
        }
        private void tbxChannelId_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                System.Windows.MessageBox.Show("请选择一台信号机后，再进行配置！");
                return;
            }
            List<Channel> channels = t.ListChannel;
            if (Convert.ToByte(tbxChannelId.Text) != 0)
            {
                ClearChannelContentById();
                foreach (Channel channel in channels)
                {
                    if (channel.ucId == Convert.ToByte(tbxChannelId.Text))
                    {
                        foreach (ChannelFlash cf in lcf)
                        {
                            if (cf.value == channel.ucFlashAuto)
                            {
                                cbxAutoFlash.SelectedItem = cf;
                            }
                        }
                        foreach (ChannelType ct in lct)
                        {
                            if (ct.value == channel.ucType)
                            {
                                cbxChannelType.SelectedItem = ct;
                            }
                        }
                    }
                }
            }
            
        }
        private void ClearDirecContentById()
        {
            tbxRoadCnt.Text = "0";
        }
        private void tbxDirecId_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                System.Windows.MessageBox.Show("请选择一台信号机后，再进行配置！");
                return;
            }
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            if (Convert.ToByte(tbxDirecId.Text) != 0)
            {
                ClearDirecContentById();
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (Convert.ToByte(tbxDirecId.Text) == ptd.ucId)
                    {
                        try
                        {
                            string eeee = "" + ptd.ucRoadCnt;
                            tbxRoadCnt.Text = eeee;
                        }
                        catch (Exception exce)
                        {
                            Console.Write(exce.Message);
                        }

                    }

                }
            }
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                System.Windows.MessageBox.Show("请选择一台信号机后，再进行配置！");
                return;
            }
            List<tscui.Models.Phase> phases = t.ListPhase;
            foreach (tscui.Models.Phase p in phases)
            {
                if (p.ucId == Byte.Parse(tbxPhaseId.Text))
                {
                    p.ucExtend = 0;
                    p.ucFixedGreen = Byte.Parse(tbxFixedGreenTime.Text);
                    p.ucGreenDelayUnit = Byte.Parse(tbxUintDelayTime.Text);
                    p.ucGreenFlash = Byte.Parse(tbxGreenFlash.Text);
                    p.ucMaxGreen1 = Byte.Parse(tbxMax1Time.Text);
                    p.ucMaxGreen2 = Byte.Parse(tbxMax2Time.Text);
                    p.ucMinGreen = Byte.Parse(tbxMinGreenTime.Text);
                    PhaseOption po = ((PhaseOption)cbxPhaseOption.SelectedValue);
                    p.ucOption = Convert.ToByte(po.ucOption);
                    p.ucPedestrianClear = Byte.Parse(tbxPedestrainClearTime.Text);
                    p.ucPedestrianGreen = Byte.Parse(tbxPedestrainCrossTime.Text);
                    p.ucType =Convert.ToByte(((PhaseType)cbxPhaseType.SelectedValue).ucType);
                }
            }
            Message m = TscDataUtils.SetPhase(phases);
            System.Windows.MessageBox.Show(m.msg);
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                System.Windows.MessageBox.Show("请选择一台信号机后，再进行配置！");
                return;
            }
            List<OverlapPhase> overlapPhases = t.ListOverlapPhase;
            foreach (OverlapPhase op in overlapPhases)
            {
                if (op.ucId == Byte.Parse(tbxOverlapPhaseId.Text))
                {

                    int correctCount = ccbCorrectPhase.SelectedItems.Count;
                    byte[] bytesCorrect = new byte[correctCount];
                    for (int j = 0; j < correctCount; j++)
                    {
                        bytesCorrect[j] = Convert.ToByte(((tscui.Models.Phase)ccbCorrectPhase.SelectedItems[j]).ucId);
                    }
                    op.ucCorrectPhase = bytesCorrect;
                    op.ucCorrectPhaseLen = Convert.ToByte(ccbCorrectPhase.SelectedItems.Count);
                    
                    //includePhase list
                    int includeCount = ccbIncludePhase1.SelectedItems.Count;
                    byte[] bytesinclude = new byte[includeCount];
                    for (int i = 0; i < includeCount; i++)
                    {
                        bytesinclude[i] = Convert.ToByte(((tscui.Models.Phase)ccbIncludePhase1.SelectedItems[i]).ucId);
                    }
                    op.ucIncludePhase = bytesinclude;
                    op.ucIncludePhaseLen = Convert.ToByte(ccbIncludePhase1.SelectedItems.Count);
                    op.ucOperateType = Convert.ToByte(((OverlapPhaseType)cbxOperateType.SelectedValue).value);
                    op.ucTailGreen = Convert.ToByte(tbxTailGreen.Text);
                    op.ucTailRed = Convert.ToByte(tbxRedTime.Text);
                    op.ucTailYellow = Convert.ToByte(tbxYellowTime.Text);
                }
            }
            Message m = TscDataUtils.SetOverlapPhase(overlapPhases);
            System.Windows.MessageBox.Show(m.msg);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                System.Windows.MessageBox.Show("请选择一台信号机后，再进行配置！");
                return;
            }
            List<Channel> channels = t.ListChannel;
            foreach(Channel channel in channels){
                if (channel.ucId == Convert.ToByte(tbxChannelId.Text))
                {
                    channel.ucFlashAuto = Convert.ToByte(((ChannelFlash)cbxAutoFlash.SelectedValue).value);
          
                    channel.ucType = Convert.ToByte(((ChannelType)cbxChannelType.SelectedValue).value);
                }
            }
            Message m = TscDataUtils.SetChannel(channels);
            System.Windows.MessageBox.Show(m.msg);
        }
       
        private void btnDirec_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                System.Windows.MessageBox.Show("请选择一台信号机后，再进行配置！");
                return;
            }
            List<PhaseToDirec> direcs = t.ListPhaseToDirec;
            foreach (PhaseToDirec ptd in direcs)
            {
                if (ptd.ucId == Convert.ToByte(tbxDirecId.Text))
                {
                    ptd.ucRoadCnt = Convert.ToByte(tbxRoadCnt.Text);
                    
                }
            }
            Message m = TscDataUtils.SetPhaseToDirec(direcs);
            System.Windows.MessageBox.Show(m.msg);
        }
        

        private void bsrDirecId_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
           
            txtBox.Text = value.ToString();
        }

        private void bsrRoadCount_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrChannelId_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            else if (value >= 32)
            {
                value = 32;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrOverlapPhaseId_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            else if (value >= 16)
            {
                value = 16;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrGreenTime_Spin_1(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrYellowTime_Spin_1(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrRedTime_Spin_1(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void phaseId_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            else if (value >= 32)
            {
                value = 32;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrPedestrainClearTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrPedestrainCrossTime_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrGreenFlash_Spin_1(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrMax2Time_Spin_1(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrMax1Time_Spin_1(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrUintDelayTime_Spin_1(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrFixedGreenTime_Spin_1(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void bsrMinGreenTime_Spin_1(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            if (value <= 1)
            {
                value = 1;
            }
            txtBox.Text = value.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            List<Channel> lc = td.ListChannel;
            //List<tscui.Models.Phase> lp = td.ListPhase;
            //List<OverlapPhase> lop = td.ListOverlapPhase;
            foreach (Channel c in lc)
            {
                if (c.ucId == 1)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel1.SelectedValue;
              
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 2)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel2.SelectedValue;
           
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 3)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel3.SelectedValue;
             
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 4)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel4.SelectedValue;
           
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 5)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel5.SelectedValue;
         
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 6)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel6.SelectedValue;
          
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 7)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel7.SelectedValue;
         
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 8)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel8.SelectedValue;
       
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 9)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel9.SelectedValue;
        
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 10)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel10.SelectedValue;
        
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 11)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel11.SelectedValue;
        
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 12)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel12.SelectedValue;
       
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 13)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel13.SelectedValue;
       
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 14)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel14.SelectedValue;
  
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 15)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel15.SelectedValue;
    
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 16)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel16.SelectedValue;

                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 17)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel17.SelectedValue;

                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 218)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel18.SelectedValue;
  
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 19)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel19.SelectedValue;
        
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 20)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel20.SelectedValue;
         
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 21)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel21.SelectedValue;
            
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 22)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel22.SelectedValue;
              
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 23)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel23.SelectedValue;
         
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 24)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel24.SelectedValue;
           
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 25)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel25.SelectedValue;
               
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 26)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel26.SelectedValue;
             
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 27)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel27.SelectedValue;
           
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 28)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel28.SelectedValue;
              
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 29)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel29.SelectedValue;
             
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 30)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel30.SelectedValue;
             
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 31)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel31.SelectedValue;
             
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
                else if (c.ucId == 32)
                {
                    ChannelPhaseOverlap cpo = (ChannelPhaseOverlap)channel32.SelectedValue;
          
                    c.ucSourcePhase = Convert.ToByte(cpo.id);
                }
            }
            Message m = TscDataUtils.SetChannel(lc);
            System.Windows.MessageBox.Show(m.msg);
        }
    }
}
