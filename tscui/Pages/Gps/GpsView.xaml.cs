using System;
using System.Threading;
using System.Windows;
using Apex.MVVM;
using tscui.Models;
using UserControl = System.Windows.Controls.UserControl;

namespace tscui.Pages.Gps
{
    /// <summary>
    /// Interaction logic for CountDownView.xaml
    /// </summary>
    [View(typeof(GpsViewModel))]
    public partial class GpsView : UserControl, IView
    {
        TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
        public GpsView()
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

        private void CfgRead_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string result = "";
                byte[] bGpsState = Udp.sendUdpClient(td.Node.sIpAddress, td.Node.iPort, Define.GETOPENCLOSE_GPS);
                if (bGpsState.Length != 0x4)
                {
                    result += "Gps开启关闭状态获取非法!";
                }
                else
                {
                    if (bGpsState[3] == 0x1)
                    {
                        RdbOpen.IsChecked = true;
                       // RdbClose.IsChecked = false;
                      //  RdbRserve.IsChecked = false;
                    }
                    else
                    {
                     //   RdbOpen.IsChecked = false;
                        RdbClose.IsChecked = true;
                     //   RdbRserve.IsChecked = false;
                    }
                    result += "Gps开启关闭状态获取成功!";
                }
               
                byte[] bGpsInteral = Udp.sendUdpClient(td.Node.sIpAddress, td.Node.iPort, Define.GETINTERAL_GPS);
                if (bGpsInteral.Length != 0x4)
                {
                    result += "\r\nGps校时间隔参数获取非法!";
                }
                else
                {
                    IntervalTime.Value = bGpsInteral[3];
                    result += "\r\nGps校时间隔参数获取成功!";
                }
      //          MessageBox.Show(result);
                MessageBox.Show(result, "Gps", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取Gps配置异常!", "Gps", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtnSet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
                string result = "";
                if (RdbOpen.IsChecked == true)
                {

                    bool bOpenok = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, Define.OPEN_GPS);
                    if (bOpenok)
                    {
                        result += "Gps开启设置成功!";
                    }
                    else
                    {
                        result += "Gps开启设置失败!";
                    }
                }
                else if (RdbClose.IsChecked == true)
                {
                    bool bClose = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, Define.CLOSE_GPS);
                    if (bClose)
                    {
                        result += "Gps关闭设置成功!";
                    }
                    else
                    {
                         result += "Gps关闭设置失败!";
                    }
                }

                if (ChkGpsPara.IsChecked == true)
                {
                    byte[] ibraodbyte = new byte[4] { 0x81, 0xf6, 0x0B, 0x0 };
                    ibraodbyte[3] = Convert.ToByte(IntervalTime.Value);
                    if (ibraodbyte[3] < 1 || ibraodbyte[3] > 30)
                    {
                        MessageBox.Show("Gps间隔时间天数范围在1-30之间，其他非法!");
                        return;
                    }
                    bool bGpsParaSetOk = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, ibraodbyte);
                    if (bGpsParaSetOk)
                    {
                        result += "\r\nGps校时参数设置成功!";
                    }
                    else
                    {
                        result += "\r\nGps校时参数设置失败!";
                    }

                }


                if (result == "")
                {
                    MessageBox.Show("请至少选择一项Gps设置选项!", "Gps", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show(result, "Gps", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("GPS配置异常!", "Gps", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void BtnAdjTime_Click(object sender, RoutedEventArgs e)
        {
            bool bok = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, Define.FORCEADJ_GPS);
            if (bok)
            {
                MessageBox.Show("强制Gps命令发送成功！", "Gps", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("强制Gps校时命令发送失败！", "Gps", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        

        }
    }

