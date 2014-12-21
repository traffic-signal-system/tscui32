using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using Apex;
using tscui.Popups;
using Apex.Shells;
using System.Windows;
using tscui.Models;
using tscui.Service;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Media;
using System.Net;
using System.Net.Sockets;

namespace tscui.Pages.Detector
{
    /// <summary>
    /// Interaction logic for DetectorView.xaml
    /// </summary>
    [View(typeof(DetectorViewModel))]
    public partial class DetectorView : UserControl,IView
    {
        public DetectorView()
        {
            InitializeComponent();
            this.Deteccanvas.AddHandler(TextBlock.MouseLeftButtonDownEvent, new RoutedEventHandler(MouseLeftButton_Down));
            this.Deteccanvas.AddHandler(TextBlock.MouseRightButtonDownEvent, new RoutedEventHandler(MouseRightButton_Down));
        }

        private void MouseRightButton_Down(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource != null)
            {
                TextBlock tb = e.OriginalSource  as TextBlock;
                if (tb == null)
                {
                  //  MessageBox.Show("不是检测器右键点击");
                    return;
                }
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                if (tb.Text.Equals(""))
                {
                    return;
                }
                byte id = Convert.ToByte(tb.Text);
                List<Models.Detector> ld = t.ListDetector;
                foreach (Models.Detector d in ld)
                {
                    if (d.ucDetectorId == id)
                    {
                        d.ucPhaseId = 0x00;
                        tb.Text = "";
                    }
                }
            }
        }

        private void MouseLeftButton_Down(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource != null)
            {
                TextBlock tb = e.OriginalSource as TextBlock;
                if (tb == null)
                {
                 //   MessageBox.Show("不是检测器左键点击");
                    return;
                }
                ApexBroker.GetShell().ShowPopup(new DetectorPopup());
                Byte DetectorDirect = 0xff;
                Byte DetectorIndex = 0xff;
                string setdetectorname = (e.OriginalSource as FrameworkElement).Name;
                switch (setdetectorname)
                {
                    case "detectorNorthLeft1":
                        DetectorDirect = Define.NORTH_LEFT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorNorthLeft2":
                        DetectorDirect = Define.NORTH_LEFT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorNorthLeft3":
                        DetectorDirect = Define.NORTH_LEFT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorNorthLeft4":
                        DetectorDirect = Define.NORTH_LEFT;
                        DetectorIndex = 0x4;
                        break;
                     case "detectorNorthStraight1" :
                        DetectorDirect = Define.NORTH_STRAIGHT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorNorthStraight2":
                        DetectorDirect = Define.NORTH_STRAIGHT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorNorthStraight3":
                        DetectorDirect = Define.NORTH_STRAIGHT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectoNorthStraight4":
                        DetectorDirect = Define.NORTH_STRAIGHT;
                        DetectorIndex = 0x4;
                        break;

                    case "detectorNorthRight1":
                        DetectorDirect = Define.NORTH_RIGHT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorNorthRight2":
                        DetectorDirect = Define.NORTH_RIGHT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorNorthRight3":
                        DetectorDirect = Define.NORTH_RIGHT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorNorthRight4":
                        DetectorDirect = Define.NORTH_RIGHT;
                        DetectorIndex = 0x4;
                        break;

                    case "detectorNorthOther1":
                        DetectorDirect = Define.NORTH_OTHER;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorNorthOther2":
                        DetectorDirect = Define.NORTH_OTHER;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorNorthOther3":
                        DetectorDirect = Define.NORTH_OTHER;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorNorthOther4":
                        DetectorDirect = Define.NORTH_OTHER;
                        DetectorIndex = 0x4;
                        break;

                    case "detectorSouthLeft1":
                        DetectorDirect = Define.SOUTH_LEFT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorSouthLeft2":
                        DetectorDirect = Define.SOUTH_LEFT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorSouthLeft3":
                        DetectorDirect = Define.SOUTH_LEFT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorSouthLeft4":
                        DetectorDirect = Define.SOUTH_LEFT;
                        DetectorIndex = 0x4;
                        break;
                    case "detectorSouthStraight1":
                        DetectorDirect = Define.SOUTH_STRAIGHT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorSouthStraight2":
                        DetectorDirect = Define.SOUTH_STRAIGHT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorSouthStraight3":
                        DetectorDirect = Define.SOUTH_STRAIGHT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorSouthStraight4":
                        DetectorDirect = Define.SOUTH_STRAIGHT;
                        DetectorIndex = 0x4;
                        break;

                    case "detectorSouthRight1":
                        DetectorDirect = Define.SOUTH_RIGHT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorSouthRight2":
                        DetectorDirect = Define.SOUTH_RIGHT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorSouthRight3":
                        DetectorDirect = Define.SOUTH_RIGHT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorSouthRight4":
                        DetectorDirect = Define.SOUTH_RIGHT;
                        DetectorIndex = 0x4;
                        break;
                    case "detectorSouthOther1":
                        DetectorDirect = Define.SOUTH_OTHER;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorSouthOther2":
                        DetectorDirect = Define.SOUTH_OTHER;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorSouthOther3":
                        DetectorDirect = Define.SOUTH_OTHER;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorSouthOther4":
                        DetectorDirect = Define.SOUTH_OTHER;
                        DetectorIndex = 0x4;
                        break;

                    case "detectorWestLeft1":
                        DetectorDirect = Define.WEST_LEFT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorWestLeft2":
                        DetectorDirect = Define.WEST_LEFT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorWestLeft3":
                        DetectorDirect = Define.WEST_LEFT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorWestLeft4":
                        DetectorDirect = Define.WEST_LEFT;
                        DetectorIndex = 0x4;
                        break;
                    case "detectorWestStraight1":
                        DetectorDirect = Define.WEST_STRAIGHT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorWestStraight2":
                        DetectorDirect = Define.WEST_STRAIGHT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorWestStraight3":
                        DetectorDirect = Define.WEST_STRAIGHT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorWestStraight4":
                        DetectorDirect = Define.WEST_STRAIGHT;
                        DetectorIndex = 0x4;
                        break;

                    case "detectorWestRight1":
                        DetectorDirect = Define.WEST_RIGHT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorWestRight2":
                        DetectorDirect = Define.WEST_RIGHT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorWestRight3":
                        DetectorDirect = Define.WEST_RIGHT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorWestRight4":
                        DetectorDirect = Define.WEST_RIGHT;
                        DetectorIndex = 0x4;
                        break;

                    case "detectorWestOther1":
                        DetectorDirect = Define.WEST_OTHER;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorWestOther2":
                        DetectorDirect = Define.WEST_OTHER;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorWestOther3":
                        DetectorDirect = Define.WEST_OTHER;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorWestOther4":
                        DetectorDirect = Define.WEST_OTHER;
                        DetectorIndex = 0x4;
                        break;
                    case "detectorEastLeft1":
                        DetectorDirect = Define.EAST_LEFT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorEastLeft2":
                        DetectorDirect = Define.EAST_LEFT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorEastLeft3":
                        DetectorDirect = Define.EAST_LEFT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorEastLeft4":
                        DetectorDirect = Define.EAST_LEFT;
                        DetectorIndex = 0x4;
                        break;
                    case "detectorEastStraight1":
                        DetectorDirect = Define.EAST_STRAIGHT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorEastStraight2":
                        DetectorDirect = Define.EAST_STRAIGHT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorEastStraight3":
                        DetectorDirect = Define.EAST_STRAIGHT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorEastStraight4":
                        DetectorDirect = Define.EAST_STRAIGHT;
                        DetectorIndex = 0x4;
                        break;

                    case "detectorEastRight1":
                        DetectorDirect = Define.EAST_RIGHT;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorEastRight2":
                        DetectorDirect = Define.EAST_RIGHT;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorEastRight3":
                        DetectorDirect = Define.EAST_RIGHT;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorEastRight4":
                        DetectorDirect = Define.EAST_RIGHT;
                        DetectorIndex = 0x4;
                        break;
                    case "detectorEastOther1":
                        DetectorDirect = Define.EAST_OTHER;
                        DetectorIndex = 0x1;
                        break;
                    case "detectorEastOther2":
                        DetectorDirect = Define.EAST_OTHER;
                        DetectorIndex = 0x2;
                        break;
                    case "detectorEastOther3":
                        DetectorDirect = Define.EAST_OTHER;
                        DetectorIndex = 0x3;
                        break;
                    case "detectorEastOther4":
                        DetectorDirect = Define.EAST_OTHER;
                        DetectorIndex = 0x4;
                        break;
                    default:
                        break;
                }
                if (DetectorDirect != 0xff && DetectorIndex != 0xff)
                {
                    int i = Utils.Utils.GetSelectedDetector();
                    if (i == 0)
                    {
                        return;
                    }
                    ClearDetectorId(i);
                    tb = e.OriginalSource as TextBlock;
                    tb.Text = i.ToString();
                    SetDetector(i, DetectorDirect, DetectorIndex);
                    displayOneDetector(i);
                  //  MessageBox.Show("添加检测器" + DetectorIndex.ToString());
                }
                e.Handled = true;
            }
        }

        public void OnActivated()
        {
            SlideFadeInBehaviour.DoSlideFadeIn(this);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector1.Executed += new CommandEventHandler(ShowPopupCommandDetector1_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector2.Executed += new CommandEventHandler(ShowPopupCommandDetector2_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector3.Executed += new CommandEventHandler(ShowPopupCommandDetector3_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector4.Executed += new CommandEventHandler(ShowPopupCommandDetector4_Executed);
        }

        void ShowPopupCommandDetector4_Executed(object sender, CommandEventArgs args)
        {
            //throw new NotImplementedException();
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        void ShowPopupCommandDetector3_Executed(object sender, CommandEventArgs args)
        {
            //throw new NotImplementedException();
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        void ShowPopupCommandDetector2_Executed(object sender, CommandEventArgs args)
        {
            //throw new NotImplementedException();
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        void ShowPopupCommandDetector1_Executed(object sender, CommandEventArgs args)
        {
            //throw new NotImplementedException();
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        public void OnDeactivated()
        {
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector1.Executed -= new CommandEventHandler(ShowPopupCommandDetector1_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector2.Executed -= new CommandEventHandler(ShowPopupCommandDetector2_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector3.Executed -= new CommandEventHandler(ShowPopupCommandDetector3_Executed);
            ((DetectorViewModel)DataContext).ShowPopupCommandDetector4.Executed -= new CommandEventHandler(ShowPopupCommandDetector4_Executed);
        }

        private void image19_ImageFailed(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {

        }

        private void image1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        private void image21_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
        }

        private void image20_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northOtherDetector3_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }

        private void northOtherDetector1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            IShell theShell = ApexBroker.GetShell();
            theShell.ShowPopup(new DetectorPopup());
            //theShell.
            //theShell.
        }

        private void tbkD1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tbkd = sender as TextBlock;
            DragDrop.DoDragDrop(tbkd, tbkd, DragDropEffects.Move);
        }

        private void tbkD2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBlock tbkd = sender as TextBlock;
            DragDrop.DoDragDrop(tbkd, tbkd, DragDropEffects.Move);
        }

        private void canvasNorthOtherDetector1_Drop(object sender, System.Windows.DragEventArgs e)
        {
            e.Data.GetFormats();
            if(e.Data.GetDataPresent("System.Windows.Controls.TextBlock"))
            {
                Canvas cv = sender as Canvas;
                TextBlock tbkd = e.Data.GetData("System.Windows.Controls.TextBlock") as TextBlock;
                WrapPanel wp = tbkd.Parent as WrapPanel;
                wp.Children.Remove(tbkd);
                cv.Children.Add(tbkd);
            }
            
            Console.WriteLine(e.Data);
        }

        private void canvasNorthOtherDetector2_Drop(object sender, System.Windows.DragEventArgs e)
        {
            e.Data.GetFormats();
            if (e.Data.GetDataPresent("System.Windows.Controls.TextBlock"))
            {
                TextBlock cv = sender as TextBlock;
                TextBlock tbkd = e.Data.GetData("System.Windows.Controls.TextBlock") as TextBlock;
                cv.Text = tbkd.Text;
                tbkd.Text = "";
                Console.WriteLine(cv.Text);
            }
        }

        private void t_Drop(object sender, DragEventArgs e)
        {
            e.Data.GetFormats();
            if (e.Data.GetDataPresent("System.Windows.Controls.TextBlock"))
            {
                TextBlock cv = sender as TextBlock;
                TextBlock tbkd = e.Data.GetData("System.Windows.Controls.TextBlock") as TextBlock;
                cv.Text = tbkd.Text;
                tbkd.Text = "";
                Console.WriteLine(cv.Text);
            }
        }

        private void tbkD1_Drop(object sender, DragEventArgs e)
        {
            e.Data.GetFormats();
            if (e.Data.GetDataPresent("System.Windows.Controls.TextBlock"))
            {
                TextBlock cv = sender as TextBlock;
                TextBlock tbkd = e.Data.GetData("System.Windows.Controls.TextBlock") as TextBlock;
                cv.Text = tbkd.Text;
                tbkd.Text = "";
                Console.WriteLine(cv.Text);
            }
        }
        TscData t;
        public byte GetPhaseIdByDirec(byte direc)
        {
            byte result = new byte();
            if (t == null)
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return 0;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach(PhaseToDirec ptd in lptd)
            {
                if(ptd.ucId == direc)
                {
                    result =  ptd.ucPhase;
                }
            }
            return result;
        }
        public byte GetOptionByCheckbox()
        {
            byte re = new byte();
            if(cbxCarType.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x01);
            }
            if(cbxKeyRoad.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x02);
            }
            if(cbxFlow.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x04);
            }
            if (cbxOccupancy.IsChecked ==true)
            {
                re = Convert.ToByte(re | 0x08);
            }
            if (cbxSpeed.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x10);
            }
            if(cbxQueun.IsChecked == true)
            {
                re = Convert.ToByte(re | 0x20);
            }
            return re;
        }
        private byte GetDirecByte(byte direc)
        {
            byte result = new byte();
            if (direc >= Define.NORTH_TURN_AROUND && direc <= Define.NORTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x01;
            }
            else if (direc >= Define.EAST_NORTH_TURN_AROUND && direc <=Define.EAST_NORTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x02;
            }
            else if (direc >= Define.EAST_TURN_AROUND && direc <= Define.EAST_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x04;
            }
            else if (direc >= Define.EAST_SOUTH_TURN_AROUND && direc <= Define.EAST_SOUTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x08;
            }
            else if (direc >= Define.SOUTH_TURN_AROUND && direc <= Define.SOUTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x10;
            }
            else if (direc >= Define.WEST_SOUTH_TURN_AROUND && direc <= Define.WEST_SOUTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x20;
            }
            else if (direc >= Define.WEST_TURN_AROUND && direc <= Define.WEST_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x40;
            }
            else if (direc >= Define.WEST_NORTH_TURN_AROUND && direc <= Define.WEST_NORTH_LEFT_STRAIGHT_RIGHT)
            {
                result = 0x80;
            }
            return result;
        }
        public byte GetDetFlag(int type,byte direc)
        {
            byte result = new byte();
           if(direc == Define.NORTH_OTHER || direc == Define.WEST_OTHER || direc == Define.EAST_OTHER || direc == Define.SOUTH_OTHER)
           {
               if (type == 1)
               {
                   result = Define.DETECTOR_TYPE_STATEGY_BUS;
               }
               else if (type == 2)
               {
                   result = Define.DETECTOR_TYPE_REACTION_BUS;
               }
               else if (type == 3)
               {
                   result = Define.DETECTOR_TYPE_TACTICS_BUS;
               }
               else if (type == 4)
               {
                   result = Define.DETECTOR_TYPE_REQUEST_BUS;
               }
           }
           else if (direc == Define.NORTH_PEDESTRAIN_ONE || direc == Define.NORTH_PEDESTRAIN_TWO || direc == Define.EAST_PEDESTRAIN_ONE || direc == Define.EAST_PEDESTRAIN_TWO || direc == Define.SOUTH_PEDESTRAIN_ONE || direc == Define.SOUTH_PEDESTRAIN_TWO || direc == Define.WEST_PEDESTRAIN_ONE || direc == Define.WEST_PEDESTRAIN_TWO)
           {
               if (type == 1)
               {
                   result = Define.DETECTOR_TYPE_STATEGY_HUMAN;
               }
               else if (type == 2)
               {
                   result = Define.DETECTOR_TYPE_REACTION_HUMAN;
               }
               else if (type == 3)
               {
                   result = Define.DETECTOR_TYPE_TACTICS_HUMAN;
               }
               else if (type == 4)
               {
                   result = Define.DETECTOR_TYPE_REQUEST_HUMAN;
               }
           }
           else
           {
               if (type == 1)
               {
                   result = Define.DETECTOR_TYPE_STATEGY_CAR;
               }
               else if (type == 2)
               {
                   result = Define.DETECTOR_TYPE_REACTION_CAR;
               }
               else if (type == 3)
               {
                   result = Define.DETECTOR_TYPE_TACTICS_CAR;
               }
               else if (type == 4)
               {
                   result = Define.DETECTOR_TYPE_REQUEST_CAR;
               }
           }
            
            return result;
        }
        /// <summary>
        /// 设置检测器，在哪个位置都有不同的定义 
        /// 1、路口最外面的是 战略
        /// 2、路口外到内 第二个是感应
        /// 3、路口外到内 第三个是战术
        /// 4、路口 外到内第四个是请求
        /// </summary>
        /// <param name="i"></param>
        /// <param name="direc"></param>
        /// <param name="type"></param>
        public void SetDetector(int i ,byte direc,int type)
        {
            tscui.Models.Detector d = new Models.Detector();
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            
            if (t == null)
                return ;
            bool newDetector = true;
            List<Models.Detector> ld = t.ListDetector;
            foreach (Models.Detector det in ld)
            {
                if (det.ucDetectorId == i)
                {
                    det.ucDetectorId = Convert.ToByte(i);
                    det.ucDetFlag = GetDetFlag(type,direc);
                    det.ucDirect = GetDirecByte(direc);
                    det.ucOptionFlag = GetOptionByCheckbox();
                    det.ucPhaseId = GetPhaseIdByDirec(direc);
                    det.ucSaturationOccupy = d.ucSaturationOccupy;
                    byte vt = 0;
                    if (tbkVaildTime.Text != "")
                    {
                        vt = Convert.ToByte(tbkVaildTime.Text);
                    }
                    det.ucValidTime = vt;
                    det.usSaturationFlow = d.usSaturationFlow;
                    newDetector = false;
                    break;
                }
            }
            if (newDetector == true)
            {
                d.ucDetectorId = Convert.ToByte(i);
                d.ucPhaseId = GetPhaseIdByDirec(direc);
                d.ucDetFlag = GetDetFlag(type,direc);
                d.ucDirect = GetDirecByte(direc);
                d.ucValidTime = Byte.Parse("0");//Convert.ToByte(tbkVaildTime.Text); 
                d.ucOptionFlag = GetOptionByCheckbox();
                d.usSaturationFlow = 0;
                d.ucSaturationOccupy = 0;
                newDetector = true;
               
                ld.Add(d);
            }
        }
        public List<TextBlock> allDetecotr = new List<TextBlock>();
        /// <summary>
        /// 显示表单数据到界面上
        /// </summary>
        /// <param name="id"></param>
        public void displayOneDetector(int id)
        {
           
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            foreach(Models.Detector d in ld)
            {
                if(id == d.ucDetectorId)
                {
                    tbkPhaseId.Text = Convert.ToString(d.ucPhaseId);
                    byte detf = d.ucDetFlag;
                    if ((detf & 0x10) == 0x10)
                    {
                        rbnStategy.IsChecked = true;
                    }
                    if ((detf & 0x40) == 0x40)
                    {
                        rbnReaction.IsChecked = true;
                    }
                    if ((detf & 0x80) == 0x80)
                    {
                        rbnRequest.IsChecked = true;
                    }
                    if ((detf & 0x20) == 0x20)
                    {
                        rbnTactics.IsChecked = true;
                    }
                    if ((detf & 0x01) == 0x01)
                    {
                        rbnCar.IsChecked = true;
                    }
                    if ((detf & 0x02) == 0x02)
                    {
                        rbnBike.IsChecked = true;
                    }
                    if ((detf & 0x04) == 0x04)
                    {
                        rbnBus.IsChecked = true;
                    }
                    if ((detf & 0x08) == 0x08)
                    {
                        rbnPedestrain.IsChecked = true;
                    }

                    tbkVaildTime.Text = Convert.ToString(d.ucValidTime);
                    tbxFlow.Text = Convert.ToString(d.usSaturationFlow);
                    tbxOccupany.Text = Convert.ToString(d.ucSaturationOccupy);
                    byte opt = d.ucOptionFlag;
                    if ((opt & 0x01) == 0x01)
                    {
                        cbxCarType.IsChecked = true;
                    }
                    else
                    {
                        cbxCarType.IsChecked = false;
                    }
                    if ((opt & 0x02) == 0x02)
                    {
                        cbxKeyRoad.IsChecked = true;
                    }
                    else
                    {
                        cbxKeyRoad.IsChecked = false;
                    }
                    if ((opt & 0x04) == 0x04)
                    {

                        cbxFlow.IsChecked = true;
                    }
                    else
                    {
                        cbxFlow.IsChecked = false;
                    }
                    if ((opt & 0x08) == 0x08)
                    {
                        cbxOccupancy.IsChecked = true;
                    }
                    else
                    {
                        cbxOccupancy.IsChecked = false;
                    }
                    if ((opt & 0x10) == 0x10)
                    {
                        cbxSpeed.IsChecked = true;
                    }
                    else
                    {
                        cbxSpeed.IsChecked = false;
                    }
                    if ((opt & 0x20) == 0x20)
                    {
                        cbxQueun.IsChecked = true;
                    }
                    else
                    {
                        cbxQueun.IsChecked = false;
                    }
                }
                
            }
        }
        /// <summary>
        /// 清空配置当前检测器在其它方向位置上的数字显示
        /// 并显示在当前配置的位置上。
        /// </summary>
        /// <param name="id"></param>
        public void ClearDetectorId(int id)
        {
            //清空之前放到的textblock
            foreach (TextBlock tb in allDetecotr)
            {
                if (!tb.Text.Equals(""))
                {
                    if (id == Convert.ToInt32(tb.Text))
                    {
                        tb.Text = "";
                    }
                }

            }
        }
        private void detectorNorthOther1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ApexBroker.GetShell().ShowPopup(new DetectorPopup());
            int i = Utils.Utils.GetSelectedDetector();
            if (i == 0)
            {
                return;
            }
            ClearDetectorId(i);
            TextBlock tb = sender as TextBlock;
            tb.Text = i.ToString();
            SetDetector(i, Define.NORTH_OTHER, 1);
            displayOneDetector(i);
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            { 
                ThreadPool.QueueUserWorkItem(SaveDetector);
            }
            catch (Exception ex)
            {
                MessageBox.Show("BaseTime: " + ex.ToString());
            }
        }

        private void SaveDetector(object state)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            Message m = TscDataUtils.SetDetector(t.ListDetector);
        }

        private delegate void DelegateCheckCar();
        private void DispatcherCheckCar(object state)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateCheckCar(CheckCar));
        }


        private List<DetectorStateObject> CheckCarByte(byte[] data)
        {
            List<DetectorState> lds = new List<DetectorState>();
            List<DetectorStateObject> ldso = new List<DetectorStateObject>();
            byte[] countDownArray = new byte[Define.DETECTOR_STATE_BYTE_LEN * Define.DETECTOR_STATE_BYTE_SIZE];
            Array.Copy(data, 4, countDownArray, 0, Define.DETECTOR_STATE_BYTE_LEN * Define.DETECTOR_STATE_BYTE_SIZE);
            byte[,] twoArray = ByteUtils.oneArray2TwoArray(countDownArray, Define.DETECTOR_STATE_BYTE_LEN, Define.DETECTOR_STATE_BYTE_SIZE);
            DetectorState ds;
            DetectorStateObject dso;
            for (int i = 0; i < Define.DETECTOR_STATE_BYTE_LEN; i++)
            {
                ds = new DetectorState();
                dso = new DetectorStateObject();

                dso.UcDetectorStateId = twoArray[i, 0];
                byte state = twoArray[i, 1];
                if (0x01 ==  (byte)(state & 0x01))
                {
                    dso.UcDetectorState1 = 0x01;
                }
                if (0x02 == (byte)(state & 0x02))
                {
                    dso.UcDetectorState2 = 0x01;
                }
                if (0x04 == (byte)(state & 0x04))
                {
                    dso.UcDetectorState3 = 0x01;
                }
                if (0x08 == (byte)(state & 0x08))
                {
                    dso.UcDetectorState4 = 0x01;
                }
                if (0x10 == (byte)(state & 0x10))
                {
                    dso.UcDetectorState5 = 0x01;
                }
                if (0x20 == (byte)(state & 0x20))
                {
                    dso.UcDetectorState6 = 0x01;
                }
                if (0x40 == (byte)(state & 0x40))
                {
                    dso.UcDetectorState7 = 0x01;
                }
                if (0x80 == (byte)(state & 0x80))
                {
                    dso.UcDetectorState8 = 0x01;
                }
                byte alert = twoArray[i, 2];
                if(0x01 == (byte)(alert & 0x01)){
                    dso.UcDetectorStateAlert1 = 0x01;
                }
                if (0x02 == (byte)(alert & 0x02))
                {
                    dso.UcDetectorStateAlert2 = 0x01;
                }
                if (0x04 == (byte)(alert & 0x04))
                {
                    dso.UcDetectorStateAlert3 = 0x01;
                }
                if (0x08 == (byte)(alert & 0x08))
                {
                    dso.UcDetectorStateAlert4 = 0x01;
                }
                if (0x10 == (byte)(alert & 0x10))
                {
                    dso.UcDetectorStateAlert5 = 0x01;
                }
                if (0x20 == (byte)(alert & 0x20))
                {
                    dso.UcDetectorStateAlert6 = 0x01;
                }
                if (0x40 == (byte)(alert & 0x40))
                {
                    dso.UcDetectorStateAlert7 = 0x01;
                }
                if (0x80 == (byte)(alert & 0x80))
                {
                    dso.UcDetectorStateAlert8 = 0x01;
                }

                ds.UcDetectorStateId = twoArray[i, 0];
                ds.UcDetectorState = twoArray[i, 1];
                ds.UcDetectorStateAlert = twoArray[i, 2];
                lds.Add(ds);
                ldso.Add(dso);
            }
            return ldso;
        }
        DispatcherTimer checkDispatcherTimer;
        bool isDetectorState1 = true;
        bool isDetectorAlert1 = true;
        bool isDetectorState2 = true;
        bool isDetectorAlert2 = true;
        bool isDetectorState3 = true;
        bool isDetectorAlert3 = true;
        bool isDetectorState4 = true;
        bool isDetectorAlert4 = true;
        bool isDetectorState5 = true;
        bool isDetectorAlert5 = true;
        bool isDetectorState6 = true;
        bool isDetectorAlert6 = true;
        bool isDetectorState7 = true;
        bool isDetectorAlert7 = true;
        bool isDetectorState8 = true;
        bool isDetectorAlert8 = true;
        bool isDetectorState9 = true;
        bool isDetectorAlert9 = true;
        bool isDetectorState10 = true;
        bool isDetectorAlert10 = true;
        bool isDetectorState11 = true;
        bool isDetectorAlert11 = true;
        bool isDetectorState12 = true;
        bool isDetectorAlert12 = true;
        bool isDetectorState13 = true;
        bool isDetectorAlert13 = true;
        bool isDetectorState14 = true;
        bool isDetectorAlert14 = true;
        bool isDetectorState15 = true;
        bool isDetectorAlert15 = true;
        bool isDetectorState16 = true;
        bool isDetectorAlert16 = true;

        bool isDetectorState17 = true;
        bool isDetectorAlert17 = true;
        bool isDetectorState18 = true;
        bool isDetectorAlert18 = true;
        bool isDetectorState19 = true;
        bool isDetectorAlert19 = true;
        bool isDetectorState20 = true;
        bool isDetectorAlert20 = true;
        bool isDetectorState21 = true;
        bool isDetectorAlert21 = true;
        bool isDetectorState22 = true;
        bool isDetectorAlert22 = true;
        bool isDetectorState23 = true;
        bool isDetectorAlert23 = true;
        bool isDetectorState24 = true;
        bool isDetectorAlert24 = true;
        bool isDetectorState25 = true;
        bool isDetectorAlert25 = true;
        bool isDetectorState26 = true;
        bool isDetectorAlert26 = true;
        bool isDetectorState27 = true;
        bool isDetectorAlert27 = true;
        bool isDetectorState28 = true;
        bool isDetectorAlert28 = true;
        bool isDetectorState29 = true;
        bool isDetectorAlert29 = true;
        bool isDetectorState30 = true;
        bool isDetectorAlert30 = true;
        bool isDetectorState31 = true;
        bool isDetectorAlert31 = true;
        bool isDetectorState32 = true;
        bool isDetectorAlert32 = true;
        private void CheckedDispatcherTimer_Tick(object sender, EventArgs e)
        {
            //Thread.Sleep(200);
            //if (_checkCarSocket.Connected)
            //{
            //    _checkCarSocket.Bind(_checkCarLocal);
            //}
            //byte[] buffer = new byte[255];
            //EndPoint remoteEP = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
            //int len = _checkCarSocket.ReceiveFrom(buffer, ref remoteEP);
            //IPEndPoint ipEndPoint = remoteEP as IPEndPoint;

           // CheckCarService gb20999 = new CheckCarService(buffer, len);
            List<DetectorStateObject> listDSO = DetectorStateObjects.listDetectorStateObject;
            //listDSO = CheckCarByte(buffer);
           
            if (listDSO != null)
            {
                foreach (TextBlock tb in allDetecotr)
                {
                    
                    //Thread.Sleep(500);
                    //tb.Text = "1";
                    foreach (DetectorStateObject dso in listDSO)
                    {
                        string sid = tb.Text.Trim();
                        if (sid.Equals(""))
                        {
                            sid = "0";
                        }
                        byte id = Convert.ToByte(sid);
                        //这里执行线圈存在问题的textblock变更背景色
                        byte detectorIda1 = 0;
                        if (dso.UcDetectorStateAlert1 == 1 && dso.UcDetectorStateId == 1)
                            detectorIda1 = 1;
                        if (dso.UcDetectorStateAlert1 != 0)
                        {
                            if (id == detectorIda1 && id != 0 && id == 1)
                            {
                                if (isDetectorAlert1 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert1 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert1 = true;
                                }
                            }
                        }
                        byte detectorIda2 = 0;
                        if (dso.UcDetectorStateAlert2 == 1 && dso.UcDetectorStateId == 1)
                            detectorIda2 = 2;
                        if (dso.UcDetectorStateAlert2 != 0)
                        {
                            if (id == detectorIda2 && id != 0 && id == 2)
                            {
                                if (isDetectorAlert2 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert2 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert2 = true;
                                }
                            }
                        }
                        byte detectorIda3 = 0;
                        if(dso.UcDetectorStateAlert3 == 1 && dso.UcDetectorStateId ==1)
                            detectorIda3 = 3;
                        if (dso.UcDetectorStateAlert3 != 0)
                        {
                            if (id == detectorIda3 && id != 0 && id == 3)
                            {
                                if (isDetectorAlert3 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert3 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert3 = true;
                                }
                            }
                        }
                        byte detectorIda4 = 0;
                        if(dso.UcDetectorStateAlert4 ==1 && dso.UcDetectorStateId ==1)
                            detectorIda4 = 4;
                        if (detectorIda4 != 0)
                        {
                            if (id == detectorIda4 && id != 0 && id == 4)
                            {
                                if (isDetectorAlert4 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert4 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert4 = true;
                                }
                            }
                        }
                        byte detectorIda5 = 0;
                        if(dso.UcDetectorStateAlert5 ==1 && dso.UcDetectorStateId == 1)
                            detectorIda5 = 5;
                        if (detectorIda5 != 0)
                        {
                            if (id == detectorIda5 && id != 0 && id == 5)
                            {
                                if (isDetectorAlert5 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert5 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert5 = true;
                                }
                            }
                        }
                        byte detectorIda6 = 0;
                        if(dso.UcDetectorStateAlert6 ==1 && (dso.UcDetectorStateId) ==1)
                            detectorIda6 = 6;
                        if (detectorIda6 != 0)
                        {
                            if (id == detectorIda6 && id != 0 && id == 6)
                            {
                                if (isDetectorAlert6 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert6 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert6 = true;
                                }
                            }
                        }
                        byte detectorIda7 = 0;
                        if(dso.UcDetectorStateAlert7 ==1 && (dso.UcDetectorStateId) ==1)
                            detectorIda7 = 7;
                        if (detectorIda7 != 0)
                        {
                            if (id == detectorIda7 && id != 0 && id == 7)
                            {
                                if (isDetectorAlert7 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert7 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert7 = true;
                                }
                            }
                        }
                        byte detectorIda8 = 0;
                        if(dso.UcDetectorStateAlert8 == 1 && (dso.UcDetectorStateId) == 1)
                            detectorIda8 = 8;
                        if (detectorIda8 != 0)
                        {
                            if (id == detectorIda8 && id != 0 && id == 8)
                            {
                                if (isDetectorAlert8 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert8 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert8 = true;
                                }
                            }
                        }
                        byte detectorIda9 = 0;
                        if(dso.UcDetectorStateAlert1 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIda9 = 9;
                        if (detectorIda9 != 0)
                        {
                            if (id == detectorIda9 && id != 0 && id == 9)
                            {
                                if (isDetectorAlert9 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert9 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert9 = true;
                                }
                            }
                        }
                        byte detectorIda10 = 0;
                        if(dso.UcDetectorStateAlert2 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIda10 = 10;
                        if (detectorIda10 != 0)
                        {
                            if (id == detectorIda10 && id != 0 && id == 10)
                            {
                                if (isDetectorAlert10 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert10 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert10 = true;
                                }
                            }
                        }
                        byte detectorIda11 = 0;
                        if(dso.UcDetectorStateAlert3 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIda11 = 11;
                        if (detectorIda11 != 0)
                        {
                            if (id == detectorIda11 && id != 0 && id == 11)
                            {
                                if (isDetectorAlert11 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert11 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert11 = true;
                                }
                            }
                        }
                        byte detectorIda12 = 0;
                        if(dso.UcDetectorStateAlert4 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIda12 = 12;
                        if (detectorIda12 != 0)
                        {
                            if (id == detectorIda12 && id != 0 && id == 12)
                            {
                                if (isDetectorAlert12 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert12 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert12 = true;
                                }
                            }
                        }
                        byte detectorIda13 = 0;
                        if(dso.UcDetectorStateAlert5 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIda13 = 13;
                        if (detectorIda13 != 0)
                        {
                            if (id == detectorIda13 && id != 0 && id == 13)
                            {
                                if (isDetectorAlert13 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert13 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert13 = true;
                                }
                            }
                        }
                        byte detectorIda14 = 0;
                        if (dso.UcDetectorStateAlert6 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIda14 = 14;
                        if (detectorIda14 != 0)
                        {
                            if (id == detectorIda14 && id != 0 && id == 14)
                            {
                                if (isDetectorAlert14 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert14 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert14 = true;
                                }
                            }
                        }
                        byte detectorIda15 = 0;
                        if(dso.UcDetectorStateAlert7 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIda15 = 15;
                        if (detectorIda15 != 0)
                        {
                            if (id == detectorIda15 && id != 0 && id == 15)
                            {
                                if (isDetectorAlert15 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert15 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert15 = true;
                                }
                            }
                        }
                        byte detectorIda16 = 0;
                        if(dso.UcDetectorStateAlert8 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIda16 = 16;
                        if (detectorIda16 != 0)
                        {
                            if (id == detectorIda16 && id != 0 && id == 16)
                            {
                                if (isDetectorAlert16 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert16 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert16 = true;
                                }
                            }
                        }
                        byte detectorIda17 = 0;
                        if(dso.UcDetectorStateAlert1 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIda17 = 17;
                        if (detectorIda17 != 0)
                        {
                            if (id == detectorIda17 && id != 0 && id == 17)
                            {
                                if (isDetectorAlert17 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert17 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert17 = true;
                                }
                            }
                        }
                        byte detectorIda18 = 0;
                        if(dso.UcDetectorStateAlert2 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIda18 = 18;
                        if (detectorIda18 != 0)
                        {
                            if (id == detectorIda18 && id != 0 && id == 18)
                            {
                                if (isDetectorAlert18 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert18 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert18 = true;
                                }
                            }
                        }
                        byte detectorIda19 = 0;
                        if(dso.UcDetectorStateAlert3 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIda19 = 19;
                        if (detectorIda19 != 0)
                        {
                            if (id == detectorIda19 && id != 0 && id == 19)
                            {
                                if (isDetectorAlert19 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert19 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert19 = true;
                                }
                            }
                        }
                        byte detectorIda20 = 0;
                        if(dso.UcDetectorStateAlert4 ==1 && (dso.UcDetectorStateId) == 3)
                            detectorIda20 = 20;
                        if (detectorIda20 != 0)
                        {
                            if (id == detectorIda20 && id != 0 && id == 20)
                            {
                                if (isDetectorAlert20 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert20 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert20 = true;
                                }
                            }
                        }
                        byte detectorIda21 = 0;
                        if (dso.UcDetectorStateAlert5 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIda21 =21;
                        if (detectorIda21 != 0)
                        {
                            if (id == detectorIda21 && id != 0 && id == 21)
                            {
                                if (isDetectorAlert21 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert21 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert21 = true;
                                }
                            }
                        }
                        byte detectorIda22 = 0;
                        if(dso.UcDetectorStateAlert6==1 && (dso.UcDetectorStateId)==3)
                            detectorIda22 = 22;
                        if (detectorIda22 != 0)
                        {
                            if (id == detectorIda22 && id != 0 && id == 22)
                            {
                                if (isDetectorAlert22 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert22 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert22 = true;
                                }
                            }
                        }
                        byte detectorIda23 = 0;
                        if(dso.UcDetectorStateAlert7==1 && (dso.UcDetectorStateId)==3)
                            detectorIda23 = 23;
                        if (detectorIda23 != 0)
                        {
                            if (id == detectorIda23 && id != 0 && id == 23)
                            {
                                if (isDetectorAlert23 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert23 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert23 = true;
                                }
                            }
                        }
                        byte detectorIda24 = 0;
                        if(dso.UcDetectorStateAlert8 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIda24 =24;
                        if (detectorIda24 != 0)
                        {
                            if (id == detectorIda24 && id != 0 && id == 24)
                            {
                                if (isDetectorAlert24 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert24 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert24 = true;
                                }
                            }
                        }
                        byte detectorIda25 = 0;
                        if(dso.UcDetectorStateAlert1 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIda25 = 25;
                        if (detectorIda25 != 0)
                        {
                            if (id == detectorIda25 && id != 0 && id == 25)
                            {
                                if (isDetectorAlert25 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert25 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert25 = true;
                                }
                            }
                        }
                        byte detectorIda26 = 0;
                        if(dso.UcDetectorStateAlert2 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIda26 =26;
                        if (detectorIda26 != 0)
                        {
                            if (id == detectorIda26 && id != 0 && id == 26)
                            {
                                if (isDetectorAlert26 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert26 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert26 = true;
                                }
                            }
                        }
                        byte detectorIda27 = 0;
                        if(dso.UcDetectorStateAlert3 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIda27 = 27;
                        if (detectorIda27 != 0)
                        {
                            if (id == detectorIda27 && id != 0 && id == 27)
                            {
                                if (isDetectorAlert27 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert27 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert27 = true;
                                }
                            }
                        }
                        byte detectorIda28 = 0;
                        if(dso.UcDetectorStateAlert4 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIda28 =28;
                        if (detectorIda28 != 0)
                        {
                            if (id == detectorIda28 && id != 0 && id == 28)
                            {
                                if (isDetectorAlert28 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert28= false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert28 = true;
                                }
                            }
                        }
                        byte detectorIda29 = 0;
                        if(dso.UcDetectorStateAlert5==1 && (dso.UcDetectorStateId)==4)
                            detectorIda29 =29;
                        if (detectorIda29 != 0)
                        {
                            if (id == detectorIda29 && id != 0 && id == 29)
                            {
                                if (isDetectorAlert29 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert29 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert29 = true;
                                }
                            }
                        }
                        byte detectorIda30 = 0;
                        if(dso.UcDetectorStateAlert6 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIda30 = 30;
                        if (detectorIda30 != 0)
                        {
                            if (id == detectorIda30 && id != 0 && id == 30)
                            {
                                if (isDetectorAlert30 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert30 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert30 = true;
                                }
                            }
                        }
                        byte detectorIda31 = 0;
                        if(dso.UcDetectorStateAlert7 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIda31 =31;
                        if (detectorIda31 != 0)
                        {
                            if (id == detectorIda31 && id != 0 && id == 31)
                            {
                                if (isDetectorAlert31 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert31 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert31 = true;
                                }
                            }
                        }
                        byte detectorIda32 = 0;
                        if(dso.UcDetectorStateAlert8==1 && (dso.UcDetectorStateId)==4)
                            detectorIda32 =32;
                        if (detectorIda32 != 0)
                        {
                            if (id == detectorIda32 && id != 0 && id == 32)
                            {
                                if (isDetectorAlert32 == true)
                                {
                                    tb.Background = Brushes.Red;
                                    isDetectorAlert32 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorAlert32 = true;
                                }
                            }
                        }
                      
                        //这里执行线圈有车辆经过的textblock变更背景色。
                        byte detectorIdState1 = 0;
                        if(dso.UcDetectorState1 ==1 && (dso.UcDetectorStateId) == 1)
                            detectorIdState1 = 1;
                        if (detectorIdState1 != 0)
                        {

                            if (id == detectorIdState1 && id != 0)
                            {

                                if (isDetectorState1 == true)
                                {
                                    tb.Background = Brushes.Green;
                                    isDetectorState1 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState1 = true;
                                }

                            }
                        }
                        byte detectorIds2 = 0;
                        if (dso.UcDetectorState2 == 1 && dso.UcDetectorStateId == 1)
                            detectorIds2 = 2;
                        if (dso.UcDetectorState2 != 0)
                        {
                            if (id == detectorIds2 && id != 0 && id == 2)
                            {
                                if (isDetectorState2 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState2 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState2 = true;
                                }
                            }
                        }
                        byte detectorIds3 = 0;
                        if (dso.UcDetectorState3 == 1 && dso.UcDetectorStateId == 1)
                            detectorIds3 = 3;
                        if (dso.UcDetectorState3 != 0)
                        {
                            if (id == detectorIds3 && id != 0 && id == 3)
                            {
                                if (isDetectorState3 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState3 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState3 = true;
                                }
                            }
                        }
                        byte detectorIds4 = 0;
                        if (dso.UcDetectorState4 == 1 && dso.UcDetectorStateId == 1)
                            detectorIds4 = 4;
                        if (detectorIds4 != 0)
                        {
                            if (id == detectorIds4 && id != 0 && id == 4)
                            {
                                if (isDetectorState4 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState4 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState4 = true;
                                }
                            }
                        }
                        byte detectorIds5 = 0;
                        if (dso.UcDetectorState5 == 1 && dso.UcDetectorStateId == 1)
                            detectorIds5 = 5;
                        if (detectorIds5 != 0)
                        {
                            if (id == detectorIds5 && id != 0 && id == 5)
                            {
                                if (isDetectorState5 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState5 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState5 = true;
                                }
                            }
                        }
                        byte detectorIds6 = 0;
                        if (dso.UcDetectorState6 == 1 && (dso.UcDetectorStateId) == 1)
                            detectorIds6 = 6;
                        if (detectorIds6 != 0)
                        {
                            if (id == detectorIds6 && id != 0 && id == 6)
                            {
                                if (isDetectorState6 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState6 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState6 = true;
                                }
                            }
                        }
                        byte detectorIds7 = 0;
                        if (dso.UcDetectorState7 == 1 && (dso.UcDetectorStateId) == 1)
                            detectorIds7 = 7;
                        if (detectorIds7 != 0)
                        {
                            if (id == detectorIds7 && id != 0 && id == 7)
                            {
                                if (isDetectorState7 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState7 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState7 = true;
                                }
                            }
                        }
                        byte detectorIds8 = 0;
                        if (dso.UcDetectorState8 == 1 && (dso.UcDetectorStateId) == 1)
                            detectorIds8 = 8;
                        if (detectorIds8 != 0)
                        {
                            if (id == detectorIds8 && id != 0 && id == 8)
                            {
                                if (isDetectorState8 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState8 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState8 = true;
                                }
                            }
                        }
                        byte detectorIds9 = 0;
                        if (dso.UcDetectorState1 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIds9 = 9;
                        if (detectorIds9 != 0)
                        {
                            if (id == detectorIds9 && id != 0 && id == 9)
                            {
                                if (isDetectorState9 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState9 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState9 = true;
                                }
                            }
                        }
                        byte detectorIds10 = 0;
                        if (dso.UcDetectorState2 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIds10 = 10;
                        if (detectorIds10 != 0)
                        {
                            if (id == detectorIds10 && id != 0 && id == 10)
                            {
                                if (isDetectorState10 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState10 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState10 = true;
                                }
                            }
                        }
                        byte detectorIds11 = 0;
                        if (dso.UcDetectorState3 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIds11 = 11;
                        if (detectorIds11 != 0)
                        {
                            if (id == detectorIds11 && id != 0 && id == 11)
                            {
                                if (isDetectorState11 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState11 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState11 = true;
                                }
                            }
                        }
                        byte detectorIds12 = 0;
                        if (dso.UcDetectorState4 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIds12 = 12;
                        if (detectorIds12 != 0)
                        {
                            if (id == detectorIds12 && id != 0 && id == 12)
                            {
                                if (isDetectorState12 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState12 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState12 = true;
                                }
                            }
                        }
                        byte detectorIds13 = 0;
                        if (dso.UcDetectorState5 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIds13 = 13;
                        if (detectorIds13 != 0)
                        {
                            if (id == detectorIds13 && id != 0 && id == 13)
                            {
                                if (isDetectorState13 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState13 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState13 = true;
                                }
                            }
                        }
                        byte detectorIds14 = 0;
                        if (dso.UcDetectorState6 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIds14 = 14;
                        if (detectorIds14 != 0)
                        {
                            if (id == detectorIds14 && id != 0 && id == 14)
                            {
                                if (isDetectorState14 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState14 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState14 = true;
                                }
                            }
                        }
                        byte detectorIds15 = 0;
                        if (dso.UcDetectorState7 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIds15 = 15;
                        if (detectorIds15 != 0)
                        {
                            if (id == detectorIds15 && id != 0 && id == 15)
                            {
                                if (isDetectorState15 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState15 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState15 = true;
                                }
                            }
                        }
                        byte detectorIds16 = 0;
                        if (dso.UcDetectorState8 == 1 && (dso.UcDetectorStateId) == 2)
                            detectorIds16 = 16;
                        if (detectorIds16 != 0)
                        {
                            if (id == detectorIds16 && id != 0 && id == 16)
                            {
                                if (isDetectorState16 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState16 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState16 = true;
                                }
                            }
                        }
                        byte detectorIds17 = 0;
                        if (dso.UcDetectorState1 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIds17 = 17;
                        if (detectorIds17 != 0)
                        {
                            if (id == detectorIds17 && id != 0 && id == 17)
                            {
                                if (isDetectorState17 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState17 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState17 = true;
                                }
                            }
                        }
                        byte detectorIds18 = 0;
                        if (dso.UcDetectorState2 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIds18 = 18;
                        if (detectorIds18 != 0)
                        {
                            if (id == detectorIds18 && id != 0 && id == 18)
                            {
                                if (isDetectorState18 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState18 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState18 = true;
                                }
                            }
                        }
                        byte detectorIds19 = 0;
                        if (dso.UcDetectorState3 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIds19 = 19;
                        if (detectorIds19 != 0)
                        {
                            if (id == detectorIds19 && id != 0 && id == 19)
                            {
                                if (isDetectorState19 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState19 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState19 = true;
                                }
                            }
                        }
                        byte detectorIds20 = 0;
                        if (dso.UcDetectorState4 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIds20 = 20;
                        if (detectorIds20 != 0)
                        {
                            if (id == detectorIds20 && id != 0 && id == 20)
                            {
                                if (isDetectorState20 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState20 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState20 = true;
                                }
                            }
                        }
                        byte detectorIds21 = 0;
                        if (dso.UcDetectorState5 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIds21 = 21;
                        if (detectorIds21 != 0)
                        {
                            if (id == detectorIds21 && id != 0 && id == 21)
                            {
                                if (isDetectorState21 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState21 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState21 = true;
                                }
                            }
                        }
                        byte detectorIds22 = 0;
                        if (dso.UcDetectorState6 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIds22 = 22;
                        if (detectorIds22 != 0)
                        {
                            if (id == detectorIds22 && id != 0 && id == 22)
                            {
                                if (isDetectorState22 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState22 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState22 = true;
                                }
                            }
                        }
                        byte detectorIds23 = 0;
                        if (dso.UcDetectorState7 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIds23 = 23;
                        if (detectorIds23 != 0)
                        {
                            if (id == detectorIds23 && id != 0 && id == 23)
                            {
                                if (isDetectorState23 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState23 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState23 = true;
                                }
                            }
                        }
                        byte detectorIds24 = 0;
                        if (dso.UcDetectorState8 == 1 && (dso.UcDetectorStateId) == 3)
                            detectorIds24 = 24;
                        if (detectorIds24 != 0)
                        {
                            if (id == detectorIds24 && id != 0 && id == 24)
                            {
                                if (isDetectorState24 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState24 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState24 = true;
                                }
                            }
                        }
                        byte detectorIds25 = 0;
                        if (dso.UcDetectorState1 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIds25 = 25;
                        if (detectorIds25 != 0)
                        {
                            if (id == detectorIds25 && id != 0 && id == 25)
                            {
                                if (isDetectorState25 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState25 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState25 = true;
                                }
                            }
                        }
                        byte detectorIds26 = 0;
                        if (dso.UcDetectorState2 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIds26 = 26;
                        if (detectorIds26 != 0)
                        {
                            if (id == detectorIds26 && id != 0 && id == 26)
                            {
                                if (isDetectorState26 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState26 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState26 = true;
                                }
                            }
                        }
                        byte detectorIds27 = 0;
                        if (dso.UcDetectorState3 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIds27 = 27;
                        if (detectorIds27 != 0)
                        {
                            if (id == detectorIds27 && id != 0 && id == 27)
                            {
                                if (isDetectorState27 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState27 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState27 = true;
                                }
                            }
                        }
                        byte detectorIds28 = 0;
                        if (dso.UcDetectorState4 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIds28 = 28;
                        if (detectorIds28 != 0)
                        {
                            if (id == detectorIds28 && id != 0 && id == 28)
                            {
                                if (isDetectorState28 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState28 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState28 = true;
                                }
                            }
                        }
                        byte detectorIds29 = 0;
                        if (dso.UcDetectorState5 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIds29 = 29;
                        if (detectorIds29 != 0)
                        {
                            if (id == detectorIds29 && id != 0 && id == 29)
                            {
                                if (isDetectorState29 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState29 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState29 = true;
                                }
                            }
                        }
                        byte detectorIds30 = 0;
                        if (dso.UcDetectorState6 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIds30 = 30;
                        if (detectorIds30 != 0)
                        {
                            if (id == detectorIds30 && id != 0 && id == 30)
                            {
                                if (isDetectorState30 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState30 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState30 = true;
                                }
                            }
                        }
                        byte detectorIds31 = 0;
                        if (dso.UcDetectorState7 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIds31 = 31;
                        if (detectorIds31 != 0)
                        {
                            if (id == detectorIds31 && id != 0 && id == 31)
                            {
                                if (isDetectorState31 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState31 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState31 = true;
                                }
                            }
                        }
                        byte detectorIds32 = 0;
                        if (dso.UcDetectorState8 == 1 && (dso.UcDetectorStateId) == 4)
                            detectorIds32 = 32;
                        if (detectorIds32 != 0)
                        {
                            if (id == detectorIds32 && id != 0 && id == 32)
                            {
                                if (isDetectorState32 == true)
                                {
                                    tb.Background = Brushes.DarkSeaGreen;
                                    isDetectorState32 = false;
                                }
                                else
                                {
                                    tb.Background = Brushes.Gray;
                                    isDetectorState32 = true;
                                }
                            }
                        }
                        
                    }
                }
            }
        }
        static List<DetectorStateObject> listDSO = new List<DetectorStateObject>();
        private void CheckCar()
        {
            try
            {
                while (true)
                {
                    ////Thread.Sleep(200);
                    //if (_checkCarSocket.Connected)
                    //{
                    //    _checkCarSocket.Bind(_checkCarLocal);
                    //}
                    //byte[] buffer = new byte[255];
                    //EndPoint remoteEP = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));
                    //int len = _checkCarSocket.ReceiveFrom(buffer, ref remoteEP);
                    //IPEndPoint ipEndPoint = remoteEP as IPEndPoint;
                    ////CheckCarService gb20999 = new CheckCarService(buffer, len);
                    ////List<DetectorStateObject> listDSO = new List<DetectorStateObject>();
                    //listDSO = CheckCarByte(buffer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private delegate void DelegateInitAllDetector();
        private void DispatcherInitAllDetector(object state)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitAllDetector(InitAllDetector));
        }
        private void InitAllDetector()
        {
            allDetecotr.Add(this.detectorEastLeft1);
            allDetecotr.Add(this.detectorEastLeft2);
            allDetecotr.Add(this.detectorEastLeft3);
            allDetecotr.Add(this.detectorEastLeft4);
            allDetecotr.Add(this.detectorEastOther1);
            allDetecotr.Add(this.detectorEastOther2);
            allDetecotr.Add(this.detectorEastOther3);
            allDetecotr.Add(this.detectorEastOther4);
            allDetecotr.Add(this.detectorEastRight1);
            allDetecotr.Add(this.detectorEastRight2);
            allDetecotr.Add(this.detectorEastRight3);
            allDetecotr.Add(this.detectorEastRight4);
            allDetecotr.Add(this.detectorEastStraight1);
            allDetecotr.Add(this.detectorEastStraight2);
            allDetecotr.Add(this.detectorEastStraight3);
            allDetecotr.Add(this.detectorEastStraight4);
            allDetecotr.Add(this.detectorNorthLeft1);
            allDetecotr.Add(this.detectorNorthLeft2);
            allDetecotr.Add(this.detectorNorthLeft3);
            allDetecotr.Add(this.detectorNorthLeft4);
            allDetecotr.Add(this.detectorNorthOther1);
            allDetecotr.Add(this.detectorNorthOther2);
            allDetecotr.Add(this.detectorNorthOther3);
            allDetecotr.Add(this.detectorNorthOther4);
            allDetecotr.Add(this.detectorNorthRight1);
            allDetecotr.Add(this.detectorNorthRight2);
            allDetecotr.Add(this.detectorNorthRight3);
            allDetecotr.Add(this.detectorNorthRight4);
            allDetecotr.Add(this.detectorNorthStraight1);
            allDetecotr.Add(this.detectorNorthStraight2);
            allDetecotr.Add(this.detectorNorthStraight3);
            allDetecotr.Add(this.detectorNorthStraight4);
            allDetecotr.Add(this.detectorSouthLeft1);
            allDetecotr.Add(this.detectorSouthLeft2);
            allDetecotr.Add(this.detectorSouthLeft3);
            allDetecotr.Add(this.detectorSouthLeft4);
            allDetecotr.Add(this.detectorSouthOther1);
            allDetecotr.Add(this.detectorSouthOther2);
            allDetecotr.Add(this.detectorSouthOther3);
            allDetecotr.Add(this.detectorSouthOther4);
            allDetecotr.Add(this.detectorSouthRight2);
            allDetecotr.Add(this.detectorSouthRight1);
            allDetecotr.Add(this.detectorSouthRight3);
            allDetecotr.Add(this.detectorSouthRight4);
            allDetecotr.Add(this.detectorSouthStraight1);
            allDetecotr.Add(this.detectorSouthStraight2);
            allDetecotr.Add(this.detectorSouthStraight3);
            allDetecotr.Add(this.detectorSouthStraight4);
            allDetecotr.Add(this.detectorWestLeft1);
            allDetecotr.Add(this.detectorWestLeft2);
            allDetecotr.Add(this.detectorWestLeft3);
            allDetecotr.Add(this.detectorWestLeft4);
            allDetecotr.Add(this.detectorWestOther1);
            allDetecotr.Add(this.detectorWestOther2);
            allDetecotr.Add(this.detectorWestOther3);
            allDetecotr.Add(this.detectorWestOther4);
            allDetecotr.Add(this.detectorWestRight1);
            allDetecotr.Add(this.detectorWestRight2);
            allDetecotr.Add(this.detectorWestRight3);
            allDetecotr.Add(this.detectorWestRight4);
            allDetecotr.Add(this.detectorWestStraight1);
            allDetecotr.Add(this.detectorWestStraight2);
            allDetecotr.Add(this.detectorWestStraight3);
            allDetecotr.Add(this.detectorWestStraight4);
            initDetectorDisplayTb();
        }
        private void displayDetectorId(byte id,tscui.Models.Detector d)
        {
            if (id == 0x01)//定位方向 北左
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorNorthLeft1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorNorthLeft2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorNorthLeft3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorNorthLeft4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x02)
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorNorthStraight1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorNorthStraight2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorNorthStraight3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorNorthStraight4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x04)
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorNorthRight1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorNorthRight2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorNorthRight3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorNorthRight4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x41)//东左
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorEastLeft1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorEastLeft2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorEastLeft3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorEastLeft4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x42)//东
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorEastStraight1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorEastStraight2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorEastStraight3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorEastStraight4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x44)//东
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorEastRight1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorEastRight2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorEastRight3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorEastRight4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x81)//东
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorSouthLeft1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorSouthLeft2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorSouthLeft3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorSouthLeft4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x82)//东
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorSouthStraight1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorSouthStraight2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorSouthStraight3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorSouthStraight4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x84)//东
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorSouthRight1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorSouthRight2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorSouthRight3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorSouthRight4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0xc1)//东
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorWestLeft1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorWestLeft2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorWestLeft3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorWestLeft4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0xc2)//东
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorWestStraight1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorWestStraight2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorWestStraight3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorWestStraight4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0xc4)//东
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorWestRight1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorWestRight2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorWestRight3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorWestRight4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x05)//北其它
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorNorthOther1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorNorthOther2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorNorthOther3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorNorthOther4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x45)//东其它
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorEastOther1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorEastOther2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorEastOther3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorEastOther4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0x85)//南其它
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorSouthOther1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorSouthOther2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorSouthOther3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorSouthOther4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
            else if (id == 0xc5)//西其它
            {
                if (0x10 == (d.ucDetFlag & 0x10)) // 战略线圈，属于最远一个线圈
                {
                    detectorWestOther1.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x20 == (d.ucDetFlag & 0x20))// 战术线圈，属于第二远一个线圈
                {
                    detectorWestOther2.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x40 == (d.ucDetFlag & 0x40))// 感应线圈，属于比较近一个线圈
                {
                    detectorWestOther3.Text = Convert.ToString(d.ucDetectorId);
                }
                else if (0x80 == (d.ucDetFlag & 0x80))// 请求线圈，属于最近一个线圈
                {
                    detectorWestOther4.Text = Convert.ToString(d.ucDetectorId);
                }
            }
        }
        private void initDetectorDisplayTb()
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;

            List<tscui.Models.Detector> ld = t.ListDetector;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            foreach(tscui.Models.Detector d in ld)
            {
                foreach (PhaseToDirec ptd in lptd)
                {
                    if (ptd.ucPhase == d.ucPhaseId)
                    {
                        displayDetectorId(ptd.ucId,d);
                    }
                }
               
            }
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if(t == null)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(DispatcherInitAllDetector);
            //Thread tDispatcherInitAllDetector = new Thread(DispatcherInitAllDetector);
            //tDispatcherInitAllDetector.IsBackground = true;
            //tDispatcherInitAllDetector.Start();
           // Console.WriteLine(111);
        }

      

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();

            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;

            foreach(Models.Detector d in ld)
            {
                Console.WriteLine(d.ToString());
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            if (t == null)
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Message m = TscDataUtils.SetDetector(t.ListDetector);
          //  MessageBox.Show(m.msg);
            if (m.flag)
            {
                MessageBox.Show(m.msg);
            }
            else
            {
                MessageBox.Show(m.msg);
            }
        }

        private void cbxCarType_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte( Utils.Utils.GetSelectedDetector());
            foreach(Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x01);
                }
            }
        }

        private void cbxCarType_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xfe);
                }
            }
        }

        private void cbxKeyRoad_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xfd);
                }
            }
        }

        private void cbxKeyRoad_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0x02);
                }
            }
        }

        private void cbxFlow_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x04);
                }
            }
        }

        private void cbxOccupancy_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xf7);
                }
            }
        }

        private void cbxFlow_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xfb);
                }
            }
        }

        private void cbxSpeed_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xef);
                }
            }
        }

        private void cbxQueun_Unchecked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag & 0xdf);
                }
            }
        }

        private void cbxOccupancy_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x08);
                }
            }
        }

        private void cbxSpeed_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x10);
                }
            }
        }

        private void cbxQueun_Checked(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucOptionFlag = (byte)(d.ucOptionFlag | 0x20);
                }
            }
        }

        private void tbxFlow_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.usSaturationFlow = Convert.ToInt16(tbxFlow.Text);
                }
            }
        }

        private void tbxOccupany_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucSaturationOccupy = Convert.ToByte(tbxOccupany.Text);
                }
            }
        }

        private void tbkVaildTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Models.Detector> ld = t.ListDetector;
            byte detectorId = Convert.ToByte(Utils.Utils.GetSelectedDetector());
            foreach (Models.Detector d in ld)
            {
                if (d.ucDetectorId == detectorId)
                {
                    d.ucValidTime = Convert.ToByte(tbkVaildTime.Text);
                }
            }
        }


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TscData td = (TscData)Application.Current.Properties[Define.TSC_DATA];
            if (td == null)
                return;
         
            Udp.StartReceiveCheckCar();
            Udp.sendUdpCheckCar(td.Node.sIpAddress, td.Node.iPort, Define.DETECTOR_STATUS_TABLE);
            //Thread t = new Thread(DispatcherCheckCar);
            //t.IsBackground = true;
            //t.SetApartmentState(ApartmentState.STA);
            //t.Start();
           // ThreadPool.QueueUserWorkItem(DispatcherCheckCar);

            checkDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            checkDispatcherTimer.Tick += new EventHandler(CheckedDispatcherTimer_Tick);
            checkDispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            checkDispatcherTimer.Start();
           // ThreadPool.QueueUserWorkItem(DispatcherCheckCar);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (td == null)
            {
                return;
            }
            checkDispatcherTimer.Stop();
            Udp.sendUdpCheckCar(td.Node.sIpAddress, td.Node.iPort, Define.DETECTOR_DISABLED_STATUS_TABLE);
            
        }

     


    }
}
