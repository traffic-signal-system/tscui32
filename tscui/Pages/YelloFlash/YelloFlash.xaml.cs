using System;
using System.Windows;
using Apex.MVVM;
using tscui.Models;
using UserControl = System.Windows.Controls.UserControl;

namespace tscui.Pages.YelloFlash
{
    /// <summary>
    /// Interaction logic for CountDownView.xaml
    /// </summary>
    [View(typeof(YelloFlashViewModel))]
    public partial class YelloFlash : UserControl, IView
    {
        TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
        public YelloFlash()
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Rped.IsChecked == true)
                {
                    
                    byte[] sendmsg = new byte[5];
                    sendmsg[0] = 0x81;
                    sendmsg[1] = 0xe1;
                    sendmsg[2] = 0x0;
                    sendmsg[3] = 0x4;
                    sendmsg[4] = 0x4;
                    bool bforceok = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, sendmsg);
                    if(bforceok)
                    {
                        Rtsc.IsEnabled = true;
                        MessageBox.Show("强制黄闪命令发送成功!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("强制黄闪命令发送失败!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("强制黄闪命令异常!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
             try
            {
                if (Rtsc.IsChecked == true)
                {
                    byte[] sendmsg = new byte[4];
                    sendmsg[0] = 0x81;
                    sendmsg[1] = 0xe1;
                    sendmsg[2] = 0x0;
                    sendmsg[3] = 0x5;

                    bool bexitok = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, sendmsg);
                    if (bexitok)
                    {
                        MessageBox.Show("黄闪器退出命令发送成功!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("黄闪器退出命令发送失败!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("退出黄闪异常!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
                byte[] sendmsg = new byte[6];
                sendmsg[0] = 0x81;
                sendmsg[1] = 0xe1;
                sendmsg[2] = 0x0;
                sendmsg[3] = 0x3;
                sendmsg[4] = 0x84;
                sendmsg[5] = 0x1;

                sendmsg[4] = Convert.ToByte(Cbrate.SelectedIndex);
                sendmsg[4] |= (Convert.ToByte(Cbdutyratio.SelectedIndex << 4));

                sendmsg[5] = Convert.ToByte((Syncflash.IsChecked==true) ? 0x1 : 0x2);

                bool bcfgok = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, sendmsg);
                if (bcfgok)
                {
                    MessageBox.Show("黄闪器配置成功!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("黄闪器配置失败!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("黄闪器配置设置异常!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Simulate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                byte[] sendmsg = new byte[3];
                sendmsg[0] = 0x80;
                sendmsg[1] = 0xe1;
                sendmsg[2] = 0x0;
               byte[] result  = Udp.recvUdp(td.Node.sIpAddress, Define.GBT_PORT, sendmsg);

               if (result.Length == 3 || (result[3] == 0 && result[4] == 0 && result[5]==0))
               {
                   MessageBox.Show("读取配置失败!","黄闪器",MessageBoxButton.OK,MessageBoxImage.Error);
                   Cbyftype.SelectedIndex = 3;
               }
               else
               {
                   Cbrate.SelectedIndex = result[3] & 0xf;
                   Cbdutyratio.SelectedIndex = (result[3] >> 4) & 0xf;
                   Syncflash.IsChecked = ((result[4]&0xf) == 0x1)?true:false;
                   Asynflash.IsChecked = ((result[4]&0xf) == 0x2) ? true : false;
                   Cbyftype.SelectedIndex = result[5] & 0xf;
               }

             
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("黄闪器配置读取异常!", "黄闪器", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
        {
           
            if (td == null)
            {
                this.Visibility= Visibility.Hidden; 
                return;
            }
            else
            {
                this.Visibility = Visibility.Visible; 
            }
        }
        

        }
    }

