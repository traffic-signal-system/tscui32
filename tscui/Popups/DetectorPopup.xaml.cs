using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Apex;
using tscui.Models;

namespace tscui.Popups
{
    /// <summary>
    /// Interaction logic for Detector.xaml
    /// </summary>
    public partial class DetectorPopup : UserControl
    {
        
        public string currentDetector = "";
        public  DetectorPopup(string currentDetector)
        {

        }
        public DetectorPopup()
        {
            InitializeComponent();
            this.AddHandler(Button.ClickEvent ,new RoutedEventHandler(Button_Click));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource != null)
            {
                Button selectdecButton = e.OriginalSource as Button;
                if (selectdecButton != null)
                {
                    Byte selectDecId = 0xff;
                    string selectDecName = selectdecButton.Name;
                    switch (selectDecName)
                    {
                        case "detector1":
                            selectDecId = 1;
                            break;
                        case "detector2":
                            selectDecId = 2;
                            break;
                        case "detector3":
                            selectDecId = 3;
                            break;
                        case "detector4":
                            selectDecId =4;
                            break;
                        case "detector5":
                            selectDecId = 5;
                            break;
                        case "detector6":
                            selectDecId =6;
                            break;
                        case "detector7":
                            selectDecId =7;
                            break;
                        case "detector8":
                            selectDecId = 8;
                            break;
                        case "detector9":
                            selectDecId =9;
                            break;
                        case "detector10":
                            selectDecId = 10;
                            break;
                        case "detector11":
                            selectDecId = 11;
                            break;
                        case "detector12":
                            selectDecId = 12;
                            break;
                        case "detector13":
                            selectDecId = 13;
                            break;
                        case "detector14":
                            selectDecId = 14;
                            break;
                        case "detector15":
                            selectDecId = 15;
                            break;
                        case "detector16":
                            selectDecId = 16;
                            break;
                        case "detector17":
                            selectDecId = 17;
                            break;
                        case "detector18":
                            selectDecId = 18;
                            break;
                        case "detector19":
                            selectDecId = 19;
                            break;
                        case "detector20":
                            selectDecId = 20;
                            break;
                        case "detector21":
                            selectDecId = 21;
                            break;
                        case "detector22":
                            selectDecId = 22;
                            break;
                        case "detector23":
                            selectDecId = 23;
                            break;
                        case "detector24":
                            selectDecId = 24;
                            break;
                        case "detector25":
                            selectDecId = 25;
                            break;
                        case "detector26":
                            selectDecId = 26;
                            break;
                        case "detector27":
                            selectDecId = 27;
                            break;
                        case "detector28":
                            selectDecId = 28;
                            break;
                        case "detector29":
                            selectDecId = 29;
                            break;
                        case "detector30":
                            selectDecId = 30;
                            break;
                        case "detector31":
                            selectDecId =31;
                            break;
                        case "detector32":
                            selectDecId = 32;
                            break;
                        default:
                            selectDecId = 0xff;
                            break;
                    }


                    if (selectDecId != 0xff)
                    {
                        TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                        Utils.Utils.SetSelectedDetector(selectDecId);
                        ApexBroker.GetShell().ClosePopup(this, true);
                    }
                    e.Handled = true;
                }

            }
        }

        private void button_OK_Click(object sender, RoutedEventArgs e)
        {
            Utils.Utils.SetSelectedDetector(0);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

     

    }
}
