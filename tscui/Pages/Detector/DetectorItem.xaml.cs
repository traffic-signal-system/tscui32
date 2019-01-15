
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using Apex;
using tscui.Models;


namespace tscui.Detector
{
    /// <summary>
    /// Interaction logic for ExamplePopup.xaml
    /// </summary>
    public partial class DetectorItem : UserControl
    {
        private bool DecBoardd1;
        private bool DecBoardd2;
        private bool InjecBoardd1;
        private bool InjecBoardd2;


        public DetectorItem(bool DecBd1 ,bool DecBd2,bool InjecBd1,bool InjecBd2)
        {
            InitializeComponent();
            this.GridAll.AddHandler(RadioButton.ClickEvent, new RoutedEventHandler(RadioButton_Click));
            this.GridAll.AddHandler(Ellipse.MouseLeftButtonDownEvent, new RoutedEventHandler(MouseLeftButtonDown_Click));

            DecBoardd1 = DecBd1;
            DecBoardd2 = DecBd2;
            InjecBoardd1 = InjecBd1;
            InjecBoardd2 = InjecBd2;
            
        }

        private void MouseLeftButtonDown_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (e.OriginalSource != null)
                {
                    Ellipse selectdeceEllipse = e.OriginalSource as Ellipse;
                    if (selectdeceEllipse != null)
                    {
                        Byte selectDecId = 0xff;
                        string selectDecName = selectdeceEllipse.Name;
                        //  GridAll.FindName(selectDecName)
                        for (byte index = 1; index < 96; index++)
                        {
                            string checkboxname = "CH" + index;
                            if (checkboxname == selectDecName)
                            {
                                selectDecId = index;
                                break;
                            }
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
            catch (Exception ex)
            {
                MessageBox.Show("选择检测通道异常!");
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource != null)
            {
                RadioButton selectdecButton = e.OriginalSource as RadioButton;
                if (selectdecButton != null)
                {
                    string selectRadioName = selectdecButton.Name;
                    switch (selectRadioName)
                    {
                        case "RadDetc1":
                            GrpDetecSlot1.Visibility = Visibility.Visible;
                            GrpInjectSlot1.Visibility = Visibility.Hidden;
                            break;
                        case "RadDetc2":
                            GrpInjectSlot2.Visibility = Visibility.Hidden;
                            GrpDetectSlot2.Visibility = Visibility.Visible;
                            break;
                        case "RadInjec1":
                            GrpInjectSlot1.Visibility = Visibility.Visible;
                            GrpDetecSlot1.Visibility = Visibility.Hidden;
                            break;
                        case "RadInjec2":
                            GrpDetectSlot2.Visibility = Visibility.Hidden;
                            GrpInjectSlot2.Visibility = Visibility.Visible;
                            break;
                        case "CurSlot1":
                            GrpInjectSlot1.Visibility = Visibility.Hidden;
                            GrpDetecSlot1.Visibility = Visibility.Hidden;
                            if (DecBoardd1 == true)
                            {
                                GrpDetecSlot1.Visibility = Visibility.Visible;
                            }
                            else if (InjecBoardd1 == true)
                            {
                                GrpInjectSlot1.Visibility = Visibility.Visible;
                            }
                            break;
                        case "CurSlot2":
                            GrpDetectSlot2.Visibility = Visibility.Hidden;
                            GrpInjectSlot2.Visibility = Visibility.Hidden;
                            if (DecBoardd2 == true)
                            {
                                GrpDetectSlot2.Visibility = Visibility.Visible;
                            }
                            else if (InjecBoardd2 == true)
                            {
                                GrpInjectSlot2.Visibility = Visibility.Visible;
                            }
                            break;
                        default:
                            break;

                    }
                    Utils.Utils.SetSelectedDetector(0);
                    e.Handled = true;
                }
            }
        }


        private void Grid_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Utils.Utils.SetSelectedDetector(0);
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void pop_load(object sender, RoutedEventArgs e)
        {
            CurSlot1.IsChecked = true;
            CurSlot2.IsChecked = true;
            if (DecBoardd1 == true)
            {
                GrpDetecSlot1.Visibility = Visibility.Visible;
            }
            else if (InjecBoardd1 == true)
            {
                GrpInjectSlot1.Visibility = Visibility.Visible;
            }
            if (DecBoardd2 == true)
            {
                GrpDetectSlot2.Visibility = Visibility.Visible;
            }
            else if (InjecBoardd2 == true)
            {
                GrpInjectSlot2.Visibility = Visibility.Visible;
            }
        }

    }
}
