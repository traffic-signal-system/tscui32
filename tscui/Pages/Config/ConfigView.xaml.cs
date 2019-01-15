using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Threading;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Models;
using System.Windows;
using tscui.Service;
using System.Threading;
using tscui.Utils;
using Application = System.Windows.Application;
using MessageBox = System.Windows.MessageBox;
using UserControl = System.Windows.Controls.UserControl;

namespace tscui.Pages.Config
{
    /// <summary>
    /// Interaction logic for VariableSignView.xaml
    /// </summary>
    [View(typeof (ConfigViewModel))]
    public partial class ConfigView : UserControl, IView
    {
        private TscData tdData;
        private DispatcherTimer showDispatcherTimer;
        private Thread TimingThread;
        public ConfigView()
        {
            InitializeComponent();
            tdData = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            showDispatcherTimer = new DispatcherTimer();
            showDispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            showDispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            showDispatcherTimer.Start();
        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            dtpTiming.Value = DateTime.Now;
        }

        public void OnActivated()
        {
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 显示检测器的灵敏度
        /// </summary>

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (tdData == null)
            {
                MessageBox.Show((string) App.Current.Resources.MergedDictionaries[3]["msg_log_selected_tsc"]);
                this.Visibility = Visibility.Hidden;
                return;
            }
            else
            {
                this.Visibility = Visibility.Visible;

            }
           // ip.Text = tdData.Node.sIpAddress;
        }




        private void dtpTiming_Loaded(object sender, RoutedEventArgs e)
        {
            dtpTiming.Value = DateTime.Now;
        }

        private void btnTiming_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            DateTime dt = (DateTime) dtpTiming.Value;
            bool bok = TscDataUtils.Timing(dt, tdData.Node);
            if (!bok)
                MessageBox.Show("校时失败，检查IP地址！", "校时", MessageBoxButton.OK, MessageBoxImage.Error);

            else
                MessageBox.Show("校时命令发送成功！", "校时", MessageBoxButton.OK, MessageBoxImage.Information);
          //  MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["tsc_config_timing"]);
        }


        private void bRstartTsc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
                byte[] mybyte = new byte[5];
                mybyte[0] = 0x81;
                mybyte[1] = 0xf6;
                mybyte[2] = 0x1;
                mybyte[3] = 0x0;
                mybyte[4] = 0x1;
                bool bRstart = Udp.sendUdpNoReciveData(tdData.Node.sIpAddress, tdData.Node.iPort, mybyte);
                if (!bRstart)
                {
                    MessageBox.Show("重启命令发送失败！", "重启信号机", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Application.Current.Properties[Define.TSC_DATA] = null;
                    Application.Current.Resources["tscinfo"] = "当前信号机IP地址:000.000.000.000      端口号:0000       版本:0000";
                    MessageBox.Show("重启命令发送成功！", "重启信号机", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统重启命令发送异常！", "重启信号机", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void bNetWorkConfig_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
                if ((!Utils.Utils.bIp(ip.Text) && ip.Text != String.Empty) ||
                    (!Utils.Utils.bIp(netmask.Text) && netmask.Text != String.Empty) ||
                    (!Utils.Utils.bIp(gateway.Text) && gateway.Text != String.Empty))
                {
                    MessageBox.Show("请检查网络参数格式设置是否正确！", "网络配置", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                byte[] netparams = new byte[7] {0x81, 0xf6, 0x0, 0x0, 0x0, 0x0, 0x0};

                if (ip.Text.Trim() != String.Empty)
                {
                    IPAddress newip = IPAddress.Parse(ip.Text);
                    byte[] tmpip = newip.GetAddressBytes();
                    netparams[2] = 0x6;
                    netparams[3] = tmpip[0];
                    netparams[4] = tmpip[1];
                    netparams[5] = tmpip[2];
                    netparams[6] = tmpip[3];
                    Udp.sendUdpNoReciveData(tdData.Node.sIpAddress, Define.GBT_PORT, netparams);
                    //  Thread.Sleep(300);

                }
                if (netmask.Text.Trim() != String.Empty)
                {
                    IPAddress newip = IPAddress.Parse(netmask.Text);
                    byte[] tmpip = newip.GetAddressBytes();
                    netparams[2] = 0x7;
                    netparams[3] = tmpip[0];
                    netparams[4] = tmpip[1];
                    netparams[5] = tmpip[2];
                    netparams[6] = tmpip[3];
                    Udp.sendUdpNoReciveData(tdData.Node.sIpAddress, Define.GBT_PORT, netparams);
                    //  Thread.Sleep(300);

                }
                if (gateway.Text.Trim() != String.Empty)
                {
                    IPAddress newip = IPAddress.Parse(gateway.Text);
                    byte[] tmpip = newip.GetAddressBytes();
                    netparams[2] = 08;
                    netparams[3] = tmpip[0];
                    netparams[4] = tmpip[1];
                    netparams[5] = tmpip[2];
                    netparams[6] = tmpip[3];
                    Udp.sendUdpNoReciveData(tdData.Node.sIpAddress, Define.GBT_PORT, netparams);
                    // Thread.Sleep(300);

                }
                MessageBox.Show("网络参数已提交,重启信号机生效！", "网络配置", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("网络参数提交异常！", "网络配置", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void bInitTsc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
                MessageBoxResult msgBoxResult = MessageBox.Show("确定要重置信号机数据吗?", "数据重置", MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (msgBoxResult == MessageBoxResult.No)
                    return;
                bool bok = Udp.sendUdpNoReciveData(tdData.Node.sIpAddress, tdData.Node.iPort,
                    Define.UPDATE_DATABASE_START);
                if (bok)
                {
                    MessageBox.Show("信号机数据重置命令发送成功,请重启信号机!", "数据重置", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.bRstartTsc_Click(this, null);
                }
                else
                {
                    MessageBox.Show("信号机数据重置命令发送失败!", "数据重置", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机数据重置命令发送异常!", "数据重置", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void UserControl_UnLoaded(object sender, RoutedEventArgs e)
        {
            showDispatcherTimer.Stop();
            showDispatcherTimer = null;
        }

        private void manualtime_checked(object sender, RoutedEventArgs e)
        {
            showDispatcherTimer.Stop();
        }

        private void manualtime_unchecked(object sender, RoutedEventArgs e)
        {
            showDispatcherTimer.Start();
        }

        private void btnGetTime_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tdData == null)
                    return;
                Int32 localtimesec = TscDataUtils.GetTime(0, tdData.Node);
                if (localtimesec != 0)
                {
                    if (Manualchk.IsChecked == false)
                        Manualchk.IsChecked = true;
                    DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
                    dtpTiming.Value = dt.AddSeconds(localtimesec - 8*3600);
                    MessageBox.Show("信号机时间获取成功!", "信号机时间", MessageBoxButton.OK, MessageBoxImage.Information);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机时间获取异常!", "信号机时间", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private void bSetPassWd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
                Byte[] SetPasswdBytes =new byte[]{0x81,0xe4,0x0,0x2,0x0};
                int TextLength = TbxManagerPasswd.Text.Length;
                if (TextLength < 0x4 || TextLength > 0xA)
                {
                    MessageBox.Show("设置密码须4-10位字符数字!", "密码设置", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                foreach (char c in TbxManagerPasswd.Text)
                 {
                     if (!char.IsLetterOrDigit(c))
                     {
                         MessageBox.Show("设置密码须4-10位字符数字!", "密码设置", MessageBoxButton.OK, MessageBoxImage.Error);
                         return;
                     }
                 }
                Byte[] passwd = System.Text.Encoding.Default.GetBytes(TbxManagerPasswd.Text.Trim());
                Byte[] SendPasswdByte = new byte[SetPasswdBytes.Length+passwd.Length];
                SetPasswdBytes[4] = (Byte)(passwd.Length);
                SetPasswdBytes.CopyTo(SendPasswdByte,0x0);
                passwd.CopyTo(SendPasswdByte, SetPasswdBytes.Length);
                bool bok = Udp.sendUdpNoReciveData(tdData.Node.sIpAddress, tdData.Node.iPort,SendPasswdByte);
                if (bok)
                {
                    MessageBox.Show("信号配置密码设置成功!", "密码设置", MessageBoxButton.OK, MessageBoxImage.Information);
                    Log4netHelper.WriteLog(typeof(ConfigView), "修改设置密码!!");
                }
                else
                {
                    MessageBox.Show("信号配置密码设置失败!", "密码设置", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("信号机数据重置命令发送异常!", "数据重置", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btnBuildSN_Click(object sender, RoutedEventArgs e)
        {
             try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                byte[] byteTscver = Udp.sendUdpClient(t.Node.sIpAddress, Define.GBT_PORT, Define.TSCVER_QUERY);
                byte[] byteTscver2 = new byte[byteTscver.Length - 3];
                Array.Copy(byteTscver, 0x3, byteTscver2, 0x0,byteTscver.Length - 3);
                lblVer.Content = System.Text.Encoding.Default.GetString(byteTscver2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuildSN1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                byte[] byteTscver = Udp.sendUdpClient(t.Node.sIpAddress, Define.GBT_PORT, Define.TSCIDCODE_QUERY);
                byte[] byteTscver2 = new byte[byteTscver.Length - 3];
                Array.Copy(byteTscver, 0x3, byteTscver2, 0x0, byteTscver.Length - 3);
                lblVer1.Content = System.Text.Encoding.Default.GetString(byteTscver2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bNetWorkConfigQuery_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                byte[] bytesnet = Udp.sendUdpClient(t.Node.sIpAddress, Define.GBT_PORT, Define.TSC_CTRLPARAMETERS);
                if (bytesnet == null || bytesnet.Length != 64)
                {
                    MessageBox.Show("信号机网络配置获取失败!","网络配置");
                    return;
                }
                ip.Text = Convert.ToString(bytesnet[16])+"."+ Convert.ToString(bytesnet[17]) + "."+Convert.ToString(bytesnet[18]) + "."+Convert.ToString(bytesnet[19]);
                netmask.Text = Convert.ToString(bytesnet[32]) + "." + Convert.ToString(bytesnet[33]) + "." + Convert.ToString(bytesnet[34]) + "." + Convert.ToString(bytesnet[35]);
                gateway.Text = Convert.ToString(bytesnet[48]) + "." + Convert.ToString(bytesnet[49]) + "." + Convert.ToString(bytesnet[50]) + "." + Convert.ToString(bytesnet[51]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
