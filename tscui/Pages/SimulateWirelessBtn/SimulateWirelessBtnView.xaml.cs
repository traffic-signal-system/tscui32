using System;
using System.Threading;
using System.Windows;
using Apex.MVVM;
using tscui.Models;
using UserControl = System.Windows.Controls.UserControl;
using System.Windows.Forms;

namespace tscui.Pages.SimulateWirelessBtn
{
    /// <summary>
    /// Interaction logic for CountDownView.xaml
    /// </summary>
    [View(typeof(SimulateWirelessBtnViewModel))]
    public partial class SimulateWirelessBtnView : UserControl, IView
    {
        TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
        public SimulateWirelessBtnView()
        {
            InitializeComponent();
            
            this.ButtonsGrp.AddHandler(UIElement.MouseLeftButtonDownEvent, new RoutedEventHandler(MouseLeftButton_Down));
        }

        private void MouseLeftButton_Down(object sender, RoutedEventArgs e)
        {
            try
            {
                
                if (e.OriginalSource != null)
                {
                    
                    Button tb = e.OriginalSource as Button;
                     if (tb == null)
                    {
                        return;
                    }
                    System.Windows.Forms.MessageBox.Show(tb.Name);
                   
                }
            }
            catch (Exception ex)
            {
                return;
            }
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

        private void BtnNorth_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            //System.Windows.MessageBox.Show("北");
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };

             SendSimulateWirelessBtnData[4] = 0x1;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
             SendSimulateWirelessBtnData[5] = 0x7;
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);        
        }

        private void BtnManul_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };
            SendSimulateWirelessBtnData[4] = 0x1;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtnRed_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };
            SendSimulateWirelessBtnData[4] = 0x5;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtnEast_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };

            SendSimulateWirelessBtnData[4] = 0x1;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            SendSimulateWirelessBtnData[6] = 0x7;
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);  
        }

        private void BtnSouth_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };

            SendSimulateWirelessBtnData[4] = 0x1;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            SendSimulateWirelessBtnData[7] = 0x7;
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);  
        }


        private void BtnSouthNorthLeft_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };

            SendSimulateWirelessBtnData[4] = 0x1;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            SendSimulateWirelessBtnData[5] = 0x1;
            SendSimulateWirelessBtnData[7] = 0x1;

            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtnSouthNorthStraight_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
             Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };

            SendSimulateWirelessBtnData[4] = 0x1;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            SendSimulateWirelessBtnData[5] = 0x2;
            SendSimulateWirelessBtnData[7] = 0x2;

            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtnEastWestLeft_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };

            SendSimulateWirelessBtnData[4] = 0x1;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            SendSimulateWirelessBtnData[6] = 0x1;
            SendSimulateWirelessBtnData[8] = 0x1;

            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtnEastWestStraight_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
             Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };

            SendSimulateWirelessBtnData[4] = 0x1;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            SendSimulateWirelessBtnData[6] = 0x2;
            SendSimulateWirelessBtnData[8] = 0x2;

            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtnYellowFlash_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
             Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };
            SendSimulateWirelessBtnData[4] = 0x3;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtnNextStep_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };
            SendSimulateWirelessBtnData[4] = 0x9;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtnNextDirection_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };
            SendSimulateWirelessBtnData[4] = 0x21;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
             Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData);
        }

        private void BtbWest_Click(object sender, RoutedEventArgs e)
        {
            if (Utils.Utils.bValidate() == false)
                return;
            Byte[] SendSimulateWirelessBtnData = new Byte[9] { 0x81, 0xe9, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0 };

            SendSimulateWirelessBtnData[4] = 0x1;   // {0x81,0xe9,0x0,0x2,0x0,0x0,0x0,0x0,x0};
            SendSimulateWirelessBtnData[8] = 0x7;
            Udp.sendUdpNoReciveData(td.Node.sIpAddress, td.Node.iPort, SendSimulateWirelessBtnData); 
        }

      
        


        

        }
    }

