﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Models;
using System.Windows;
using tscui.Service;
using System.Threading;
using System.Windows.Input;
using System.IO;

namespace tscui.Pages.Config
{
    /// <summary>
    /// Interaction logic for VariableSignView.xaml
    /// </summary>
    [View(typeof(ConfigViewModel))]
    public partial class ConfigView : UserControl,IView
    {
        private delegate void ShowDateTimingCallBack();
        private ShowDateTimingCallBack timingCallBack;
        Thread TimingThread;
        private void ShowTimeToDateTime()
        {
            DateTime dt = DateTime.Now;
            dtpTiming.Value = dt;
        }
        private void updateTime()
        {
            while (true)
            {
                dtpTiming.Dispatcher.Invoke(timingCallBack);
            }
        }
        public void RunThreadTiming()
        {
            try
            {

                TimingThread = new Thread(updateTime);
                TimingThread.IsBackground = true;
                TimingThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["msg_config_network_err"]);
            }
        }
        public ConfigView()
        {
            InitializeComponent();
            timingCallBack = new ShowDateTimingCallBack(ShowTimeToDateTime);
        }
         public void OnActivated()
        {
            //throw new NotImplementedException();
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }
        TscData t;
        /// <summary>
        /// 显示检测器的灵敏度
        /// </summary>
        public void displayDetectorSensitivity()
        {

            //int level1 = TscDataUtils.GetDetectorSensitivityOneBorad1_8();
            //int level2 = TscDataUtils.GetDetectorSensitivityOneBorad9_16();
            //int level3 = TscDataUtils.GetDetectorSensitivityTwoBorad1_8();
            //int level4 = TscDataUtils.GetDetectorSensitivityTwoBorad9_16();
            //sldSensitivity.Value = level1;
        }
        
        public void displayDetectorOscillatorFrequency()
        {
            //int level = TscDataUtils.GetDetectorOscillatorFrequency1();
            //sldOscillatorFrequency.Value = level;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if(t == null)
            {
                return;
            }
            //显示检测器的灵敏度
            displayDetectorSensitivity();
            displayDetectorOscillatorFrequency();
            RunThreadTiming();
        }


        private void txtHighHumidity_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!Utils.Utils.isNumberic(e.Text)) 
            {  
               e.Handled = true;  
           }  
            else 
                 e.Handled = false;  
        }

        private void txtHighHumidity_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Space)  
                 e.Handled = true;  

        }

        private void txtHighHumidity_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String))) 
            {  
                String text = (String)e.DataObject.GetData(typeof(String));
                 if (!Utils.Utils.isNumberic(text)) 
                 { 
                     e.CancelCommand(); 
                 } 
             }  
             else 
            {
                e.CancelCommand();
            }  
        }

        private void rbnLampCheckOpen_Checked(object sender, RoutedEventArgs e)
        {
          
        }

        private void rbnLampCheckClose_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void cbxCountDown_Checked(object sender, RoutedEventArgs e)
        {
            rbnNormalCountDown.IsEnabled = true;
            rbnPauseCountDown.IsEnabled = true;
            rbn15CountDown.IsEnabled = true;
        }

        private void cbxCountDown_Unchecked(object sender, RoutedEventArgs e)
        {
            rbnNormalCountDown.IsEnabled = false;
            rbnPauseCountDown.IsEnabled = false;
            rbn15CountDown.IsEnabled = false;
        }

        private void btnCountDown_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            string result = "";
            if ((bool)cbxCountDown.IsChecked)
            {
                if ((bool)rbn15CountDown.IsChecked)
                {
                    bool b1 = Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.SET_COUNT_DOWN_OPEN_15);
                    if (b1)
                    {
                        result = (string)App.Current.Resources.MergedDictionaries[3]["msg_config_countdown_15_success"];
                    }
                    else
                    {
                        result = (string)App.Current.Resources.MergedDictionaries[3]["msg_config_countdown_15_failed"]; 
                    }
                }
                else if ((bool)rbnNormalCountDown.IsChecked)
                {
                    bool b2 = Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.SET_COUNT_DOWN_OPEN_NORMAL);
                    if (b2)
                    {
                        result = (string)App.Current.Resources.MergedDictionaries[3]["msg_config_countdown_success"]; 
                    }
                    else
                    {
                        result = (string)App.Current.Resources.MergedDictionaries[3]["msg_config_countdown_failed"]; 
                    }
                }
                else if((bool)rbnPauseCountDown.IsChecked)
                {
                    bool b3 = Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.SET_COUNT_DOWN_OPEN_8);
                    
                    if (b3)
                    {
                        result = (string)App.Current.Resources.MergedDictionaries[3]["msg_config_countdown_8_success"]; 
                    }
                    else
                    {
                        result = (string)App.Current.Resources.MergedDictionaries[3]["msg_config_countdown_8_failed"]; 
                    }
                }
            }
            else
            {
                bool b4 = Udp.sendUdpNoReciveData(t.Node.sIpAddress, t.Node.iPort, Define.SET_COUNT_DOWN_CLOSE);
                if (b4)
                {
                    result = (string)App.Current.Resources.MergedDictionaries[3]["msg_config_countdown_close_success"]; 
                }
                else
                {
                    result = (string)App.Current.Resources.MergedDictionaries[3]["msg_config_countdown_close_failed"]; 
                }
            }
            MessageBox.Show(result);
        }

        private void sldSensitivity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            byte se = Convert.ToByte(sldSensitivity.Value);
            if (DetectorBorad1.IsChecked == true)
            {
                TscDataUtils.SetSensitivity(1,se,t.Node);
            }
            else if(DetectorBorad2.IsChecked == true)
            {
                TscDataUtils.SetSensitivity(2, se, t.Node);
            }
        }

        private void sldOscillatorFrequency_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            TscDataUtils.SetOscillatorFrequency(Convert.ToByte(sldOscillatorFrequency.Value), t.Node);
        }

        private void dtpTiming_Loaded(object sender, RoutedEventArgs e)
        {
            dtpTiming.Value = DateTime.Now;
        }

        private void btnTiming_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            DateTime dt = (DateTime)dtpTiming.Value;
            TscDataUtils.Timing(dt,t.Node);
        }

        private void btnControllerStatusRead_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            byte[] ba = TscDataUtils.GetControllerStatus(t.Node);
            byte[] bt = {ba[3],ba[4]};
            tbkTemperature.Text = Convert.ToString(System.BitConverter.ToInt16(bt, 0));
            byte bd = ba[5];
            tbkDoorStatus.Text = Utils.Utils.devMonitorDescDoor(bd);
            byte[] bv = { ba[6], ba[7] };
            tbkVoltage.Text = Convert.ToString(System.BitConverter.ToInt16(bv,0));
            byte bpt = ba[8];
            tbkPowerType.Text = Utils.Utils.devMonitorDescPowerType(bpt);
        }

        private void btnLampCheck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLampCheckSave_Click(object sender, RoutedEventArgs e)
        {
            if(rbnLampCheckOpen.IsChecked == true)
            {
                if (TscDataUtils.SetLampCheckOpenALL(null))
                    MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["msg_config_lamp_check_open"]);
                else
                    MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["msg_config_lamp_check_open_err"]);
            }
            else
            {
                if (TscDataUtils.SetLampCheckCloseALL(null))
                    MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["msg_config_lamp_check_close"]);
                else
                    MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["msg_config_lamp_check_close_err"]);
            }
        }

  
    }
}
