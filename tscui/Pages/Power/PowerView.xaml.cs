using System;
using System.Windows;
using Apex.MVVM;
using tscui.Models;
using UserControl = System.Windows.Controls.UserControl;

namespace tscui.Pages.Power
{
    /// <summary>
    /// Interaction logic for CountDownView.xaml
    /// </summary>
    [View(typeof(PowerViewModel))]
    public partial class Power : UserControl, IView
    {
        TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();

    
        public Power()
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

 
  

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Opendog.IsChecked == true && Convert.ToByte(Watchdogtime.Value) < 25)
                {
                    MessageBox.Show("电源板看门狗时间至少25秒!","电源板",MessageBoxButton.OK,MessageBoxImage.Warning);
                    return;
                }
                byte[] sendmsg = new byte[8];
                sendmsg[0] = 0x81;
                sendmsg[1] = 0xe7;
                sendmsg[2] = 0x0;
                sendmsg[3] = 0x04;
                sendmsg[4] = (Byte)(Convert.ToInt32(HighVoltage.Value) - 150);
                sendmsg[5] = (Byte)(Convert.ToInt32(LowVoltage.Value) - 150);
                sendmsg[6] = 0xAA;
                sendmsg[7] = (Opendog.IsChecked == false) ? (Byte)((Convert.ToByte(Watchdogtime.Value) * 2)) : (Byte)((Convert.ToByte(Watchdogtime.Value) * 2 + 1));

                bool bqueryok = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, sendmsg);
                if (bqueryok)
                {
                    MessageBox.Show("电源板配置命令发送成功!", "电源板", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("电源板配置命令发送失败!", "电源板", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("电源板配置命令设置异常!", "电源板", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                byte[] result = Udp.recvUdp(td.Node.sIpAddress, Define.GBT_PORT, Define.POWER_CFG_GET);
                if (result.Length == 3 || (result[3] == 0 && result[4] == 0 ))
                {
                    MessageBox.Show("读取电源板配置失败!", "电源板", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    HighVoltage.Value = result[3] + 150;
                    LowVoltage.Value =  result[4] + 150;

                    if ((result[5] & 0x3) == 0x1)
                    {
                        HigthVolOn.IsChecked = true;
                    }
                    else if ((result[5] & 0x3) == 0x2)
                    {
                        HigthVolOff.IsChecked = true;
                    }
                    else
                    {
                        HigthVolRserve.IsChecked = true;
                    }

                    if (((result[5]>>2) & 0x3) == 0x1)
                    {
                        LowVolOn.IsChecked = true;
                    }
                    else if ((result[5] & 0x3) == 0x2)
                    {
                        LowVolOff.IsChecked = true;
                    }
                    else
                    {
                        LowVolRserve.IsChecked = true;
                    }

                    if (((result[5]>>4) & 0x3) == 0x1)
                    {
                        HigthVolOn1.IsChecked = true;
                    }
                    else if ((result[5] & 0x3) == 0x2)
                    {
                        HigthVolOff1.IsChecked = true;
                    }
                    else
                    {
                        HigthVolRserve.IsChecked = true;
                    }
                    if (((result[5] >> 6) & 0x3) == 0x1)
                    {
                        LowVolOn1.IsChecked = true;
                    }
                    else if ((result[5] & 0x3) == 0x2)
                    {
                        LowVolOff1.IsChecked = true;
                    }
                    else
                    {
                        LowVolReserve1.IsChecked = true;
                    }

                    Watchdogtime.Value = result[6] >> 0x1;
                    Opendog.IsChecked = ((result[6] & 0x1) == 0x1 ? true : false);
                    Closedog.IsChecked = ((result[6] & 0x1) == 0x1 ? false : true);

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("电源板置读取异常!", "电源板", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
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
        

        }
    }

