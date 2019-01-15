using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;
using Apex.MVVM;
using Microsoft.Windows.Controls;
using tscui.Models;
using UserControl = System.Windows.Controls.UserControl;

namespace tscui.Pages.BusPriority
{
    /// <summary>
    /// Interaction logic for CountDownView.xaml
    /// </summary>
    [View(typeof(BusPriorityViewModel))]
    public partial class BusPriorityView : UserControl, IView
    {
        TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
        private DispatcherTimer BusPriorityDispatcherTimer;
        public BusPriorityView()
        {
            InitializeComponent();
            Initpoplist();
        }

        public void OnActivated()
        {
            //throw new NotImplementedException();
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }

        public List<ChannelPhaseOverlap> lcpo = new List<ChannelPhaseOverlap>();
        public void Initpoplist()
        {
            for (byte a = 1; a < 49; a++)
            {
                lcpo.Add(new ChannelPhaseOverlap() { id = a, name = a > 32 ? "OP" + (a-32) : "P" + a, isPhase = (a >32) ? false : true});
            }
            ComboxBusPhaseId.ItemsSource = lcpo;
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
                byte[] GetBusPriorityCmd = new byte[]{0x80, 0xea, 0x0,0x1};
                byte[] BytesBusPriorityData = Udp.sendUdpClient(td.Node.sIpAddress, td.Node.iPort, GetBusPriorityCmd);
                if (BytesBusPriorityData.Length != 0x9)
                {
                    result = "优先放行参数获取非法!";
                }
                else
                {
                    ChkBusPriority.IsChecked = BytesBusPriorityData[3] ==0x1?true:false;

                    if (BytesBusPriorityData[4] == 0x0)
                    {
                        RadReduceTimeType2.IsChecked = true;

                    }
                    else
                    {
                        RadReduceTimeType1.IsChecked = true;
                    }
                    DelayGreenTime.Value = BytesBusPriorityData[5];
                    BusArriveTime.Value = BytesBusPriorityData[6];
                    EarlyRedTime.Value = BytesBusPriorityData[7];
                    foreach (ChannelPhaseOverlap oorp in lcpo)
                    {
                        if (BytesBusPriorityData[8] == oorp.id )
                        {
                            ComboxBusPhaseId.SelectedIndex = oorp.id - 1;
                            break;
                        }
                    }
                    result += "优先放行参数获取成功!";
                }
               
                MessageBox.Show(result, "优先放行", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
             //  MessageBox.Show("获取Gps配置异常!", "Gps", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        

        private void BtnBusPrioritySet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
                string result = "";
                byte[] BusPriorityData = new byte[]{0x81,0xea ,0x0,0x0,0x0,0x0,0x0,0x0,0x0};
                BusPriorityData[3] = (ChkBusPriority.IsChecked==true) ? (byte)0x1:(byte)0x0;
                BusPriorityData[4] = (RadReduceTimeType2.IsChecked == true) ? (byte)0x0 : (RadReduceTimeType1.IsChecked == true?(byte)0x1:(byte)0x0);
                BusPriorityData[5] = Convert.ToByte(DelayGreenTime.Value);
                BusPriorityData[6] =  Convert.ToByte(BusArriveTime.Value);
                BusPriorityData[7] = Convert.ToByte(EarlyRedTime.Value);
                BusPriorityData[8] = ((ChannelPhaseOverlap)ComboxBusPhaseId.SelectedValue).id;
                bool bBusParaSet = Udp.sendUdpNoReciveData(td.Node.sIpAddress, Define.GBT_PORT, BusPriorityData);
                if(bBusParaSet == true)
                {
                    result = "优先放行参数设置成功!";
                }
                else
                {
                    result = "优先放行参数设置失败!";
                }
                MessageBox.Show(result, "优先放行", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("优先放行参数异常!", "优先放行", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            BusPriorityDispatcherTimer = new DispatcherTimer();
            BusPriorityDispatcherTimer.Tick += new EventHandler(BusPriorityDispatcherTimer_Tick);
            BusPriorityDispatcherTimer.Interval = new TimeSpan(0, 0, 0,1); 
            BusPriorityDispatcherTimer.Start();
        }

        private void BusPriorityDispatcherTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] GetBusPriorityCmd2 = new byte[] { 0x80, 0xea, 0x0, 0x2 };
                byte[] BytesBusPriorityData2 = Udp.sendUdpClient(td.Node.sIpAddress, td.Node.iPort, GetBusPriorityCmd2);
                if (BytesBusPriorityData2.Length != 0x7)
                {
                    return;
                }
                else
                {
                    BusPhaseColor.Content = BytesBusPriorityData2[6] == 0x2 ? "绿色" : (BytesBusPriorityData2[6] == 0x0 ? "红色" : "黄色");
                    PresentCycle.Content = BytesBusPriorityData2[3].ToString();
                    string LabelContent = "";
                    switch ( BytesBusPriorityData2[4])
                    {
                        case 0x0:
                            LabelContent = "周期保持不变!";
                            break;
                        case 0x1:
                            LabelContent = "公交相位绿灯延长" + BytesBusPriorityData2[5] + "秒";
                            break;
                        case 0x2:
                            LabelContent = "非公交相位时长为最小绿" + BytesBusPriorityData2[5] + "秒";
                            break;
                        case 0x3:
                            LabelContent = "非公交相位时长减少" + BytesBusPriorityData2[5] + "秒";
                            break;
                        default:
                            break;
                    }
                    BusPhaseColorHandle.Content = LabelContent;

                }

            }
            catch (Exception ex)
            {
                return;
            }

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            BusPriorityDispatcherTimer.Stop();
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            if (ChkOpenBusPriority.IsChecked == true)
            {
                ChkOpenBusPriority.IsChecked = false;
            }
        }
       
    }
    }

