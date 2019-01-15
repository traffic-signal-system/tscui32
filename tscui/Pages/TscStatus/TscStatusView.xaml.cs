using System;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Models;
using System.Windows;
using Application = System.Windows.Application;
using UserControl = System.Windows.Controls.UserControl;

namespace tscui.Pages.Log
{
    /// <summary>
    /// Interaction logic for ThePagesView.xaml
    /// </summary>
    [View(typeof(TscStatusViewModel))]
    public partial class LogsView2 : UserControl, IView
    {
        System.Windows.Threading.DispatcherTimer TscStatusdispatcherTimer;

        public LogsView2()
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

        private void LMonitorBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (td == null)
                    return;
                byte[] sendmsg = new byte[7];
                sendmsg[0] = 0x81;
                sendmsg[1] = 0xf7;
                sendmsg[2] = 0x0;
                sendmsg[3] = 0x1;
                sendmsg[4] = 0xf5;
                sendmsg[5] = 0x0;
                sendmsg[6] = 0xa;
                if ((string)LMonitorBtn.Content == "开始")
                {
                    LMonitorBtn.Content = "停止";
                    Udp.StartReceive();
                    // Udp.sendUdp(td.Node.sIpAddress, Define.GBT_PORT, Define.REPORT_TSC_STATUS);
                    Udp.sendUdp(td.Node.sIpAddress, Define.GBT_PORT, sendmsg);
                    TscStatusdispatcherTimer = new System.Windows.Threading.DispatcherTimer();
                    TscStatusdispatcherTimer.Tick += new EventHandler(TscStatusdispatcherTimer_Tick);
                    TscStatusdispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                    TscStatusdispatcherTimer.Start();
                }
                else
                {
                    sendmsg[6] = 0x0;
                    LMonitorBtn.Content = "开始";
                    TscStatusdispatcherTimer.Stop();
                    Udp.sendUdp(td.Node.sIpAddress, Define.GBT_PORT, sendmsg);
                    TscMonStatus.bTscMonStatus = false;

                }
            }
            catch (Exception ex)
            {

                System.Windows.MessageBox.Show("监测信号机状态异常", "状态监测", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        private void TscStatusdispatcherTimer_Tick(object sender, EventArgs e)
        {
            LHighVoltage.Content = TscMonStatus.StrongVoltage + "V";
            LWeakVoltage.Content = TscMonStatus.WeakVoltage + "V";
            LBusVoltage.Content = TscMonStatus.BusVoltage + "V";

            LFrontDoor.Content = (TscMonStatus.FrontDoor == 0x1 ? "开启" : "关闭");
            LBackDoor.Content = (TscMonStatus.BackDoor == 0x1 ? "开启" : "关闭");
            LLight.Content = (TscMonStatus.LocalLight == 0x1 ? "开启" : "关闭");
            LAlarm.Content = (TscMonStatus.LocalAlarm == 0x1 ? "开启" : "关闭");

            LTemprature.Content = TscMonStatus.Temperature + "℃";
            LWedness.Content = TscMonStatus.Humidity + "%";

            LRemoteImport1.Content = (TscMonStatus.RemoteExport1 == 0x1 ? "开启" : "关闭");
            LRemoteImport2.Content = (TscMonStatus.RemoteExport2 == 0x1 ? "开启" : "关闭");
            LRemoteInput1.Content = (TscMonStatus.RemoteInput1 == 0x1 ? "开启" : "关闭");
            LRemoteInput2.Content = (TscMonStatus.RemoteInput2 == 0x1 ? "开启" : "关闭");


            LHeter.Content = (TscMonStatus.Heater == 0x1 ? "开启" : "关闭");
            LRaditor.Content = (TscMonStatus.Radiator == 0x1 ? "开启" : "关闭");
            LShockStatus.Content = (TscMonStatus.MachineVibration == 0x1 ? "震动" : "静止");
            for (Byte index = 0; index < 8; index++)
            {
                if (((TscMonStatus.PSC >> index) & 0x1) == 0x1)
                {
                    switch (index)
                    {
                        case 0:
                            LpedestrianBtn.Content = "北边按钮1有人";
                            return;
                        case 1:
                            LpedestrianBtn.Content = "北边按钮2有人";
                            return;
                        case 2:
                            LpedestrianBtn.Content = "东边按钮1有人";
                            return;
                        case 3:
                            LpedestrianBtn.Content = "东边按钮2有人";
                            return;
                        case 4:
                            LpedestrianBtn.Content = "南边按钮1有人";
                            return;
                        case 5:
                            LpedestrianBtn.Content = "南边按钮2有人";
                            return;
                        case 6:
                            LpedestrianBtn.Content = "西边按钮1有人";
                            return;
                        case 7:
                            LpedestrianBtn.Content = "西边按钮2有人";
                            return;
                        default:
                            LpedestrianBtn.Content = "无人";
                            return;
                    }

                }
            }
            LpedestrianBtn.Content = "无人";
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            {
                TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (td == null)
                    return;
                if ((string)LMonitorBtn.Content == "停止")
                {
                    LMonitorBtn.Content = "开始";
                    byte[] sendmsg = new byte[7];
                    sendmsg[0] = 0x81;
                    sendmsg[1] = 0xf7;
                    sendmsg[2] = 0x0;
                    sendmsg[3] = 0x1;
                    sendmsg[4] = 0xf5;
                    sendmsg[5] = 0x0;
                    sendmsg[6] = 0x0;
                    TscStatusdispatcherTimer.Stop();
                    Udp.sendUdp(td.Node.sIpAddress, Define.GBT_PORT, sendmsg);
                    TscMonStatus.bTscMonStatus = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("UserControl_Unloaded TscStatus except!");
            }
        }

    }
}
