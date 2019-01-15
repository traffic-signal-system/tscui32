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
    /// </summary>
    [View(typeof(PedestrianBtnViewModel))]
    public partial class PedestrianBtn : UserControl, IView
    {
        TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
        public PedestrianBtn()
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
            try
            {
                if (Rped.IsChecked == true)
                {
               //     TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                    if (td == null)
                        return;
                    byte[] pscdate = new byte[7] {0x81, 0xF6, 0x3, 0x1, 0x1, 0x2, 0x3};
                    bool bPsc = false;
                    bPsc = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, pscdate);
                    if (bPsc == true)
                    {
                        MessageBox.Show("行人按钮控制设置成功!","行人按钮",MessageBoxButton.OK,MessageBoxImage.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("行人按钮控制设置失败!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("行人按钮控制设置异常!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
             try
            {
                if (Rtsc.IsChecked == true)
                {
              //      TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                    if (td == null)
                        return;
                    byte[] pscdate = new byte[7] {0x81, 0xF6, 0x3, 0x0, 0x1, 0x2, 0x3};
                    bool bPsc = false;
                    bPsc = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, pscdate);
                    if (bPsc == true)
                    {
                        MessageBox.Show("Tsc控制设置成功!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("Tsc控制设置失败!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tsc设置控制异常!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
             //   TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (td == null)
                    return;
                bool bSetPscPara = false;
                byte[] pscdate = null;
                Byte psc_interval_time = Convert.ToByte(IntervalTime.Value);
                pscdate = new byte[4] { 0x81, 0xF6, 0xF, psc_interval_time };
                bSetPscPara = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, pscdate);
                Thread.Sleep(200);
                Byte psc_wait_time = Convert.ToByte(MaxWaitTime.Value);
                pscdate = new byte[6] { 0x81, 0xC1, 0x84, 0x10, 0x01, psc_wait_time };  //暂时以配时阶段16号作为临时的行人过街配时
                bSetPscPara =Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, pscdate);
                Thread.Sleep(200);
                Byte psc_walk_time = Convert.ToByte(CrossStreenTime.Value);
                pscdate = new byte[6] { 0x81, 0xC1, 0x84, 0x10, 0x02, psc_walk_time };
                bSetPscPara= Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, pscdate);
                if (bSetPscPara == true)
                {
                    MessageBox.Show("行人按钮参数提交成功!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("行人按钮参数提交失败!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("行人按钮参数提交异常!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Simulate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             
                byte[] pscdate = null;
                Byte randnum = Convert.ToByte(new Random().Next() % 129);
                pscdate = new byte[4] { 0x81, 0xee, 0x0, randnum };
                Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, pscdate);

                for (Byte i = 0; i < 8; i++)
                {
                    if (((randnum >> i) & 0x1) == 0x1)
                    {
                        switch (i)
                        {
                            case 0:
                                MessageBox.Show("北方向人行按钮1被按下\r\n!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
                            case 1:
                                MessageBox.Show("北方向人行按钮2被按下\r\n!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);

                                return;
                            case 2:
                                MessageBox.Show("东方向人行按钮1被按下\r\n!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
                            case 3:
                                MessageBox.Show("东方向人行按钮2被按下\r\n!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
                            case 4:
                                MessageBox.Show("南方向人行按钮1被按下\r\n!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
                            case 5:
                                MessageBox.Show("南方向人行按钮2被按下\r\n!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
                            case 6:
                                MessageBox.Show("西方向人行按钮1被按下\r\n!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
                            case 7:
                                MessageBox.Show("西方向人行按钮2被按下\r\n!", "行人按钮", MessageBoxButton.OK, MessageBoxImage.Information);
                                return;
                            default:
                                return;
                        }

                    }
                }
                Simulatebtn.IsEnabled = false;
                Thread.Sleep(2000);
              //  pscdate[3] =0x0;
              //  Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, pscdate);
                Simulatebtn.IsEnabled = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        

        }
    }

