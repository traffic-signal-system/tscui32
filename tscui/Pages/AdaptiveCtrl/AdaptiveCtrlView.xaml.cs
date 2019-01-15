using System;
using System.Threading;
using System.Windows;
using Apex.MVVM;
using tscui.Models;
using UserControl = System.Windows.Controls.UserControl;

namespace tscui.Pages.AdaptiveCtrl
{
    /// <summary>
    /// Interaction logic for CountDownView.xaml
    /// static byte
    /// </summary>
    [View(typeof(AdaptiveCtrlViewModel))]
    public partial class AdaptiveCtrlView : UserControl, IView
    {
        static Byte occuptynum = 0x32 ;
        static Byte carnum = 0x32;
        static Byte first = 0x14;
        static Byte secopnd = 0x1e;
        static Byte third= 0x32;
        static Byte cycleadjust = 0x32;
        static bool bVehi = true;

        TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
        public AdaptiveCtrlView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            //throw new NotImplementedException();
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (td == null)
            {
                this.Visibility = Visibility.Hidden;
                return;
            }
            else
            {
                this.Visibility = Visibility.Visible;
            }
            

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
           
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
                if (Convert.ToByte(SaturationLowDegree.Value) >= Convert.ToByte(SaturationHighDegree.Value))
                {
                    MessageBox.Show("错误:低饱和度参数大于或等于高饱和度参数!", "自适应参数", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                string result = "";
                byte[] BusPriorityData = new byte[] { 0x81, 0xeb, 0x0, 0x0, 0x0, 0x0, 0x0 };
                BusPriorityData[3] = Convert.ToByte(GreenTimeReduceRate.Value);
                BusPriorityData[4] = Convert.ToByte(GreenTimeAddRate.Value);
                BusPriorityData[5] = Convert.ToByte(SaturationLowDegree.Value);
                BusPriorityData[6] = Convert.ToByte(SaturationHighDegree.Value);
                bool bBusParaSet = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, BusPriorityData);
                if (bBusParaSet == true)
                {
                    result = "自适应参数设置成功!";
                }
                else
                {
                    result = "自适应参数设置失败!";
                }
                MessageBox.Show(result, "自适应参数", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("自适应参数设置异常!", "自适应参数", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private void Simulate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string result = "";
                byte[] GetBusPriorityCmd = new byte[] { 0x80, 0xeb, 0x0, 0x1 };
                byte[] BytesAdaptiveCfg = Udp.sendUdpClient(td.Node.sIpAddress, td.Node.iPort, GetBusPriorityCmd);
                if (BytesAdaptiveCfg.Length != 0x7)
                {
                    result = "自适应控制参数获取失败!";
                }
                else
                {
                    GreenTimeReduceRate.Value = BytesAdaptiveCfg[3] ;
                    GreenTimeAddRate.Value = BytesAdaptiveCfg[4];

                    SaturationLowDegree.Value = BytesAdaptiveCfg[5];
                    SaturationHighDegree.Value = BytesAdaptiveCfg[6];

                    result += "自适应控制参数获取成功!";
                }

                MessageBox.Show(result, "自适应控制参数", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("自适应控制参数获取异常!", "自适应控制参数", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }
        

        }
    }

