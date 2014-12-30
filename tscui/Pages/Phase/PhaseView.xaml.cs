using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Effects;
using Apex.MVVM;
using Apex.Behaviours;
using System.Windows;
using Apex;
using tscui.Pages.Music;
using tscui.Views;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using tscui.Service;
using tscui.Models;
using System.Windows.Threading;
using System.Threading;

namespace tscui.Pages.Phase
{
    /// <summary>
    /// Interaction logic for PhaseView.xaml
    /// </summary>
    [View(typeof(PhaseViewModel))]
    public partial class PhaseView : UserControl, IView
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer1;

        public PhaseView()
        {
            
            InitializeComponent();
            this.TrafficCanvas.AddHandler(Image.MouseLeftButtonDownEvent, new RoutedEventHandler(ImageMouseLeftButton_Down));
           
            
            
        }

        private void ImageMouseLeftButton_Down(object sender, RoutedEventArgs e)
        {
            try
            {
                if (e.OriginalSource != null)
                {
                    Image ClickImage = e.OriginalSource as Image;
                    if (ClickImage != null)
                    {
                        if (ClickImage.Name != "backgroundimage")
                            DirecPhaseCombox.Text = ClickImage.ToolTip.ToString();
                    }
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("获取方向异常!");
            }
        }
        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);
            //  Handle the 'show popup' executed event.ShowPopupCommandSouthRight/ShowPopupCommandSouthOther
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthLeft.Executed += ShowPopupCommandSouthLeft_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthStaight.Executed += ShowPopupCommandSouthStaight_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthRight.Executed += ShowPopupCommandSouthRight_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthOther.Executed += ShowPopupCommandSouthOther_Executed;
            ((PhaseViewModel)DataContext).ShowFailePopup.Executed += ShowFailePopup_Excuted;
            
            
        }
        void ShowFailePopup_Excuted(object sender, CommandEventArgs args)
        {
            FailePopup ep1 = new FailePopup();
            ApexBroker.GetShell().ShowPopup(ep1);
 
        }
        void ShowPopupCommandSouthRight_Executed(object sender, CommandEventArgs args)
        {
            ;
        }
        void ShowPopupCommandSouthOther_Executed(object sender, CommandEventArgs args)
        {
            ;
        }
        void ShowPopupCommandSouthStaight_Executed(object sender, CommandEventArgs args)
        {
            ;

        }

        void ep1_RadioSelectedEvent()
        {
            ;
        }
        void ep2_RadioSelectedEvent()
        {
            ;

        }
        void ep3_RadioSelectedEvent()
        {
            ;
        }
        void ep4_RadioSelectedEvent()
        {
            ;
        }
        void ShowPopupCommandSouthLeft_Executed(object sender, CommandEventArgs args)
        {
            ;
        }
        public void OnDeactivated()
        {
            //  Remove the handler for the 'show popup' executed event.
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthLeft.Executed -= ShowPopupCommandSouthLeft_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthStaight.Executed -= ShowPopupCommandSouthStaight_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthRight.Executed -= ShowPopupCommandSouthRight_Executed;
            ((PhaseViewModel)DataContext).ShowPopupCommandSouthOther.Executed -= ShowPopupCommandSouthOther_Executed;
            ((PhaseViewModel)DataContext).ShowFailePopup.Executed += ShowFailePopup_Excuted;
        }



        List<tscui.Pages.Music.MusicView.DirecNumer> dirnum = new List<tscui.Pages.Music.MusicView.DirecNumer>();
        private void InitDirecNumber()
        {
            dirnum.Add(new MusicView.DirecNumer() { name = "北左", value = 1 });
            dirnum.Add(new MusicView.DirecNumer() { name = "北直", value = 2 });
            dirnum.Add(new MusicView.DirecNumer() { name = "北右", value = 4 });
            dirnum.Add(new MusicView.DirecNumer() { name = "北人行", value = 8 });
            dirnum.Add(new MusicView.DirecNumer() { name = "北调头", value = 0 });
            dirnum.Add(new MusicView.DirecNumer() { name = "北其他", value = 5 });
            dirnum.Add(new MusicView.DirecNumer() { name = "西北其他", value = 0xe5 });

            dirnum.Add(new MusicView.DirecNumer() { name = "东左", value = 65 });
            dirnum.Add(new MusicView.DirecNumer() { name = "东直", value = 66 });
            dirnum.Add(new MusicView.DirecNumer() { name = "东右", value = 68 });
            dirnum.Add(new MusicView.DirecNumer() { name = "东人行", value = 72 });
            dirnum.Add(new MusicView.DirecNumer() { name = "东调头", value = 0x40 });
            dirnum.Add(new MusicView.DirecNumer() { name = "东其他", value = 69 });
            dirnum.Add(new MusicView.DirecNumer() { name = "东北其他", value = 0x25 });


            dirnum.Add(new MusicView.DirecNumer() { name = "南左", value = 129 });
            dirnum.Add(new MusicView.DirecNumer() { name = "南直", value = 130 });
            dirnum.Add(new MusicView.DirecNumer() { name = "南右", value = 132 });
            dirnum.Add(new MusicView.DirecNumer() { name = "南人行", value = 136 });
            dirnum.Add(new MusicView.DirecNumer() { name = "南调头", value = 0x80 });
            dirnum.Add(new MusicView.DirecNumer() { name = "南其他", value = 133 });
            dirnum.Add(new MusicView.DirecNumer() { name = "东南其他", value = 0x65 });

            dirnum.Add(new MusicView.DirecNumer() { name = "西左", value = 193 });
            dirnum.Add(new MusicView.DirecNumer() { name = "西直", value = 194 });
            dirnum.Add(new MusicView.DirecNumer() { name = "西右", value = 196 });
            dirnum.Add(new MusicView.DirecNumer() { name = "西人行", value = 200 });
            dirnum.Add(new MusicView.DirecNumer() { name = "西调头", value = 0xc0 });
            dirnum.Add(new MusicView.DirecNumer() { name = "西其他", value = 197 });
            dirnum.Add(new MusicView.DirecNumer() { name = "西南其他", value = 0xa5 });
        }


        List<MusicView.ChannelPhaseOverlap> lcpo = new List<MusicView.ChannelPhaseOverlap>();
        private void InitPhaseOverlap()
        {
            for (byte a = 1; a < 33; a++)
                lcpo.Add(new MusicView.ChannelPhaseOverlap() { id = a, name = "p" + a, isPhase = true });
            for (byte b = 1; b < 17; b++)
                lcpo.Add(new MusicView.ChannelPhaseOverlap() { id = b, name = "op" + b, isPhase = false });
        }

        #region 设置相位按钮隐藏
        //private void SetPhaseButtonShow(bool swichflag)
        //{
        //    try
        //    {
        //        switch (swichflag)
        //        {
        //            case false:
        //                this.SouthLeft.Visibility = System.Windows.Visibility.Hidden;
        //                this.SouthRight.Visibility = System.Windows.Visibility.Hidden;
        //                this.SouthStraight.Visibility = System.Windows.Visibility.Hidden;
        //                this.SouthOther.Visibility = System.Windows.Visibility.Hidden;
        //                this.NorthLeft.Visibility = System.Windows.Visibility.Hidden;
        //                this.NorthRight.Visibility = System.Windows.Visibility.Hidden;
        //                this.NorthStraight.Visibility = System.Windows.Visibility.Hidden; ;
        //                this.NorthOther.Visibility = System.Windows.Visibility.Hidden;
        //                this.WestLeft.Visibility = System.Windows.Visibility.Hidden;
        //                this.WestRight.Visibility = System.Windows.Visibility.Hidden;
        //                this.WestStraight.Visibility = System.Windows.Visibility.Hidden;
        //                this.WestOther.Visibility = System.Windows.Visibility.Hidden;
        //                this.EastLeft.Visibility = System.Windows.Visibility.Hidden;
        //                this.EastRight.Visibility = System.Windows.Visibility.Hidden;
        //                this.EastStraight.Visibility = System.Windows.Visibility.Hidden;
        //                this.EastOther.Visibility = System.Windows.Visibility.Hidden;
        //                this.EastPedestrain1.Visibility = System.Windows.Visibility.Hidden;
        //                this.WestPedestrain1.Visibility = System.Windows.Visibility.Hidden;
        //                this.NorthPedestrain1.Visibility = System.Windows.Visibility.Hidden;
        //                this.SouthPedestrain1.Visibility = System.Windows.Visibility.Hidden;
        //                this.imgWestTurn.Visibility = Visibility.Hidden;
        //                this.imgEastTurn.Visibility = Visibility.Hidden;
        //                this.imgSouthTurn.Visibility = Visibility.Hidden;
        //                this.imgNorthTurn.Visibility = Visibility.Hidden;


        //                break;
        //            case true:
        //                this.SouthLeft.Visibility = System.Windows.Visibility.Visible;
        //                this.SouthRight.Visibility = System.Windows.Visibility.Visible;
        //                this.SouthStraight.Visibility = System.Windows.Visibility.Visible;
        //                this.SouthOther.Visibility = System.Windows.Visibility.Visible;
        //                this.NorthLeft.Visibility = System.Windows.Visibility.Visible;
        //                this.NorthRight.Visibility = System.Windows.Visibility.Visible;
        //                this.NorthStraight.Visibility = System.Windows.Visibility.Visible; ;
        //                this.NorthOther.Visibility = System.Windows.Visibility.Visible;
        //                this.WestLeft.Visibility = System.Windows.Visibility.Visible;
        //                this.WestRight.Visibility = System.Windows.Visibility.Visible;
        //                this.WestStraight.Visibility = System.Windows.Visibility.Visible;
        //                this.WestOther.Visibility = System.Windows.Visibility.Visible;
        //                this.EastLeft.Visibility = System.Windows.Visibility.Visible;
        //                this.EastRight.Visibility = System.Windows.Visibility.Visible;
        //                this.EastStraight.Visibility = System.Windows.Visibility.Visible;
        //                this.EastOther.Visibility = System.Windows.Visibility.Visible;
        //                this.EastPedestrain1.Visibility = System.Windows.Visibility.Visible;
        //                this.WestPedestrain1.Visibility = System.Windows.Visibility.Visible;
        //                this.NorthPedestrain1.Visibility = System.Windows.Visibility.Visible;
        //                this.SouthPedestrain1.Visibility = System.Windows.Visibility.Visible;
        //                this.imgWestTurn.Visibility = Visibility.Visible;
        //                this.imgEastTurn.Visibility = Visibility.Visible;
        //                this.imgSouthTurn.Visibility = Visibility.Visible;
        //                this.imgNorthTurn.Visibility = Visibility.Visible;
        //                break;

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}
       
        #endregion


        #region 刷新灯组状态

       

        private void LampRhshStar()
        {
            dispatcherTimer1 = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer1.Tick += new EventHandler(dispatcherTimer1_Tick);
            dispatcherTimer1.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer1.Start();
 
        }
        private void updateRed(PhaseToDirec ptd)
        {
            if (ptd.ucId == Define.NORTH_LEFT)
            {
                imgNorthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT)
            {
                imgNorthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_RIGHT)
            {
                imgNorthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_OTHER)
            {
                imgNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_TURN_AROUND)
            {
                imgNorthTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_NORTH_OTHER)
            {
                imgWestNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
            {
                imgNorthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
            {
                imgNorthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT)
            {
                imgEastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_STRAIGHT)
            {
                imgEastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT)
            {
                imgEastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_OTHER)
            {
                imgEastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
            {
                imgEastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
            {
                imgEastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.EAST_TURN_AROUND)
            {
                imgEastTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_NORTH_OTHER)
            {
                imgEastNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }


            if (ptd.ucId == Define.SOUTH_LEFT)
            {
                imgSouthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT)
            {
                imgSouthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT)
            {
                imgSouthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_OTHER)
            {
                imgSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
            {
                imSouthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
            {
                imSouthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_TURN_AROUND)
            {
                imgSouthTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_SOUTH_OTHER)
            {
                imgEastSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.WEST_LEFT)
            {
                imgWestLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_STRAIGHT)
            {
                imgWestStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT)
            {
                imgWestRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_OTHER)
            {
                imgWestOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
            {
                imgWestPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
            {
                imgWestPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.WEST_TURN_AROUND)
            {
                imgWestTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.WEST_SOUTH_OTHER)
            {
                imgWestSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            }
        }

        private void updateYellow(PhaseToDirec ptd)
        {
            if (ptd.ucId == Define.NORTH_LEFT)
            {
                imgNorthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT)
            {
                imgNorthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_RIGHT)
            {
                imgNorthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_OTHER)
            {
                imgNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
            {
                imgNorthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
            {
                imgNorthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.NORTH_TURN_AROUND)
            {
                imgNorthTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_NORTH_OTHER)
            {
                imgWestNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            
            
            if (ptd.ucId == Define.EAST_LEFT)
            {
                imgEastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_STRAIGHT)
            {
                imgEastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT)
            {
                imgEastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_OTHER)
            {
                imgEastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
            {
                imgEastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
            {
                imgEastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
             if (ptd.ucId == Define.EAST_TURN_AROUND)
            {
                imgEastTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_NORTH_OTHER)
            {
                imgEastNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.SOUTH_LEFT)
            {
                imgSouthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT)
            {
                imgSouthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT)
            {
                imgSouthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_OTHER)
            {
                imgSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
            {
                imSouthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
            {
                imSouthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_TURN_AROUND)
            {
                imgSouthTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_SOUTH_OTHER)
            {
                imgEastSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            
            
            if (ptd.ucId == Define.WEST_LEFT)
            {
                imgWestLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_STRAIGHT)
            {
                imgWestStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT)
            {
                imgWestRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_OTHER)
            {
                imgWestOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
            {
                imgWestPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
            {
                imgWestPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_TURN_AROUND)
            {
                imgWestTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.WEST_SOUTH_OTHER)
            {
                imgWestSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/yellowlight1.png", UriKind.Relative));
            }

        }

        private void updateGreen(PhaseToDirec ptd)
        {
            if (ptd.ucId == Define.NORTH_LEFT)
            {
                imgNorthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT)
            {
                imgNorthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_RIGHT)
            {
                imgNorthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_OTHER)
            {
                imgNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
            {
                imgNorthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
            {
                imgNorthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.NORTH_TURN_AROUND)
            {
                imgNorthTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_NORTH_OTHER)
            {
                imgWestNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }


            if (ptd.ucId == Define.EAST_LEFT)
            {
                imgEastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_STRAIGHT)
            {
                imgEastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT)
            {
                imgEastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_OTHER)
            {
                imgEastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
            {
                imgEastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
            {
                imgEastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.EAST_TURN_AROUND)
            {
                imgEastTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_NORTH_OTHER)
            {
                imgEastNorthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.SOUTH_LEFT)
            {
                imgSouthLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT)
            {
                imgSouthStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT)
            {
                imgSouthRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_OTHER)
            {
                imgSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
            {
                imSouthPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
            {
                imSouthPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_TURN_AROUND)
            {
                imgSouthTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_SOUTH_OTHER)
            {
                imgEastSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }



            if (ptd.ucId == Define.WEST_LEFT)
            {
                imgWestLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_STRAIGHT)
            {
                imgWestStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT)
            {
                imgWestRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_OTHER)
            {
                imgWestOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
            {
                imgWestPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
            {
                imgWestPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_TURN_AROUND)
            {
                imgWestTurn.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }

            if (ptd.ucId == Define.WEST_SOUTH_OTHER)
            {
                imgWestSouthOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
        }
        private void dispatcherTimer1_Tick(object sender, EventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Channel> lc = t.ListChannel;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
           
            if (tscui.Models.ReportTscStatus.resportSuccessFlag)
            {
                this.workmode_label.Content = "工作模式：" + tscui.Models.ReportTscStatus.sWorkModel.ToString();
                this.controlmode_label.Content = "控制方式：" + tscui.Models.ReportTscStatus.sControlModel.ToString();
                this.workstatus_label.Content = "工作状态：" + tscui.Models.ReportTscStatus.sWorkStatus.ToString();

                this.time_NO_label.Content = "方案号：" + tscui.Models.ReportTscStatus.iCurrentTimePattern.ToString();
                this.run_NO_label.Content = "时段号：" + tscui.Models.ReportTscStatus.iCurrentSchedule.ToString();
                this.lblCurrentStage.Content = "当前阶段：" + tscui.Models.ReportTscStatus.iCurrentStage.ToString();
                 this.label_CycleTime.Content = "周期时长： " + tscui.Models.ReportTscStatus.iCycleTime.ToString();
                 this.label_iCurrentStagePattern.Content = "阶段配时号： " + tscui.Models.ReportTscStatus.iCurrentStagePattern.ToString();
                 this.label_iStageCount.Content = "阶段总数： " + tscui.Models.ReportTscStatus.iStageCount.ToString();
                 this.label_iStageTotalTime.Content = "阶段总时长： " + tscui.Models.ReportTscStatus.iStageTotalTime.ToString();
                 this.label_iStageRunTime.Content = "阶段运行时长： " + tscui.Models.ReportTscStatus.iStageRunTime.ToString();
            List <uint> redList =   tscui.Models.ReportTscStatus.listChannelRedStatus;
            List <uint> yellowList =   tscui.Models.ReportTscStatus.listChannelYellowStatus;
            List <uint> greenList =   tscui.Models.ReportTscStatus.listChannelGreenStatus;
            #region 红灯图片刷新
            for (int i = 0; i < redList.Count; i++)
            {
                foreach (Channel c in lc)
                {
                    if ((i+1) == c.ucId)
                    {
                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucPhase != 0)
                            {
                                if (ptd.ucPhase == c.ucSourcePhase)
                                {
                                    if (redList[i] == 1)
                                    {
                                        updateRed(ptd);
                                      //  break;
                                    }
                                }
                               /// break;
                            }
                            else
                            {
                                if (ptd.ucOverlapPhase != 0)
                                {
                                    if (ptd.ucOverlapPhase == c.ucSourcePhase)
                                    {
                                        if(redList[i] == 1)
                                        {
                                            updateRed(ptd);
                                            //break;
                                        }
                                       
                                    }
                                    
                                }
                            }
                           // break;
                        }
                       // break;
                    }
                    
                }
                
                //南行左
            
            }
            #endregion

            #region 黄灯图片刷新
            for (int i = 0; i < yellowList.Count; i++)
            {
                foreach (Channel c in lc)
                {
                    if ((i+1) == c.ucId)
                    {
                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucPhase != 0)
                            {
                                if (ptd.ucPhase == c.ucSourcePhase)
                                {
                                    if (yellowList[i] == 1)
                                    {
                                        updateYellow(ptd);
                                      ///  break;
                                    }
                                }
                            }
                            else
                            {
                                if (ptd.ucOverlapPhase != 0)
                                {
                                    if (ptd.ucOverlapPhase == c.ucSourcePhase)
                                    {
                                        if(yellowList[i] == 1)
                                        { 
                                            updateYellow(ptd);
                                            //break;
                                        }
                                    }
                                }
                            }
                        }
                       // break;
                    }

                }
            }

                #endregion

            #region 绿灯图片刷新
            for (int i = 0; i < greenList.Count; i++)
            {
                foreach (Channel c in lc)
                {
                    if ((i+1) == c.ucId)
                    {
                        foreach (PhaseToDirec ptd in lptd)
                        {
                            if (ptd.ucPhase != 0)
                            {
                                if (ptd.ucPhase == c.ucSourcePhase)
                                {
                                    if (greenList[i] == 1)
                                    {
                                        updateGreen(ptd);
                                        //break;
                                    }
                                    
                                }
                            }
                            else
                            {
                                if (ptd.ucOverlapPhase != 0)
                                {
                                    if (ptd.ucOverlapPhase == c.ucSourcePhase)
                                    {
                                        if (greenList[i] == 1)
                                        {
                                            updateGreen(ptd);
                                            //break;
                                        }
                                    }
                                }
                            }
                            
                        }
                        //break;
                    }

                }

            }
                #endregion

            }
            
           

           
        }
        #endregion
        
        private void Image_ImageFailed(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {
            ;
        }

        private void Image_ImageFailed_1(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {
            ;
        }

        private void lampRush_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.GrpDirecPhase.Visibility = Visibility.Hidden; //隐藏方向相位 信息
                tscui.Models.ReportTscStatus reportTscStatus = new Models.ReportTscStatus();
                TscDataUtils.GetReportStatus();
                LampRhshStar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("刷新当前运行状态 信息异常!");
            }
            
        }
      
        private void InitPhaseToButtonByDirec()
        {
            if (t == null)
                return;
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();

            if (DirecPhaseCombox.Items.Count == 0)//   InitDirecNumber();
            {
                if (dirnum.Count == 0)
                {
                    InitDirecNumber();
                }
                DirecPhaseCombox.ItemsSource = dirnum;
            }

            if (DirectPhaseIdCombox.Items.Count == 0)
            {

                if (lcpo.Count ==0)
                    InitPhaseOverlap();
                DirectPhaseIdCombox.ItemsSource = lcpo;
            }
           
          
        }

      
        TscData t;
        private delegate void DelegateInitPhaseToButtonByDirec();
        private void DispatcherInitPhaseToButtonByDirec(object state)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitPhaseToButtonByDirec(InitPhaseToButtonByDirec));
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                MessageBox.Show("请选择一信号机后，再切换到此界面！");
                this.Visibility = Visibility.Hidden;
                return;
            }
            this.Visibility = Visibility.Visible;
            ThreadPool.QueueUserWorkItem(DispatcherInitPhaseToButtonByDirec);
            ////InitPhaseToButtonByDirec();
        }

  
        private void phase1_Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void phase4_Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    
        

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (t == null)
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Message m1 = TscDataUtils.SetPhaseToDirec(t.ListPhaseToDirec);
           // Message m2 = TscDataUtils.SetPhase(t.ListPhase);
            //Message m3 = TscDataUtils.SetChannel(t.ListChannel);
            //Message m4 = TscDataUtils.SetOverlapPhase(t.ListOverlapPhase);

            if (m1.flag )
            {
                MessageBox.Show("方向保存成功");
            }
            else
            {
                MessageBox.Show("方向保存失败！");
            }
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            
            if (t == null)
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            foreach(tscui.Models.Phase p in t.ListPhase)
            {
                //Console.WriteLine(p.ucId);
            }
        }

        private void lampRush_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            
            if (t == null)
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            this.GrpDirecPhase.Visibility = Visibility.Visible;

            dispatcherTimer1.Stop();
            Udp.sendUdp(t.Node.sIpAddress, t.Node.iPort, Define.REPORT_TSC_STATUS_CANCEL);
        }

        private void savePhaseAbout(object state)
        {
            DateTime dt1 = DateTime.Now;
            
            if (t == null)
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            TscDataUtils.SetPhaseToDirec(t.ListPhaseToDirec);
            TscDataUtils.SetPhase(t.ListPhase);
            TscDataUtils.SetChannel(t.ListChannel);
            TscDataUtils.SetOverlapPhase(t.ListOverlapPhase);
            DateTime dt2 = DateTime.Now;
            TimeSpan dt3 = dt2 - dt1;
            Console.WriteLine(dt3.TotalSeconds);
            
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //ThreadPool.QueueUserWorkItem(savePhaseAbout);
                
                if(echoCountDownDispatcherTimer != null)
                {
                    echoCountDownDispatcherTimer.Stop();
                }
                if(dispatcherTimer1 != null)
                {
                    dispatcherTimer1.Stop();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Phase: "+ex.ToString());
            }
            
        }

        DispatcherTimer echoCountDownDispatcherTimer;
        private void cbxEchoCountDown_Checked(object sender, RoutedEventArgs e)
        {
            TscData td = (TscData)Application.Current.Properties[Define.TSC_DATA];
            if (td == null)
                return;
            EchoCntDowns echoCountDown = new EchoCntDowns();
            Udp.StartReceiveEchoCountDown();
            Udp.sendUdpEchoCountDown(td.Node.sIpAddress, Define.GBT_PORT, Define.ECHO_TSC_COUNT_DOWN);
            
            echoCountDownDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            echoCountDownDispatcherTimer.Tick += new EventHandler(CountDownDispatcherTimer_Tick);
            echoCountDownDispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            echoCountDownDispatcherTimer.Start();
        }
        private void CountDownDispatcherTimer_Tick(object sender, EventArgs e)
        {
            foreach(EhoCntDown ecd in EchoCntDowns._listEhoCntDown)
            {
                ecd.usFigure--;
                
                if(ecd.Direc == 0)
                {
                    if (ecd.Color == 0x01)
                    {
                        NorthCntDown.Foreground = new SolidColorBrush(Colors.Green);
                    }
                    else if (ecd.Color == 0x02)
                    {
                        NorthCntDown.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (ecd.Color == 0x03)
                    {
                        NorthCntDown.Foreground = new SolidColorBrush(Colors.Red);
                    }   
                    NorthCntDown.Text = "" + ecd.usFigure;
                }
                if (ecd.Direc == 1)
                {
                    if (ecd.Color == 0x01)
                    {
                        EastCntDown.Foreground = new SolidColorBrush(Colors.Green);
                    }
                    else if (ecd.Color == 0x02)
                    {
                        EastCntDown.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (ecd.Color == 0x03)
                    {
                        EastCntDown.Foreground = new SolidColorBrush(Colors.Red);
                    }
                    EastCntDown.Text = "" + ecd.usFigure;
                }
                if (ecd.Direc == 2)
                {
                    if (ecd.Color == 0x01)
                    {
                        SouthCntDown.Foreground = new SolidColorBrush(Colors.Green);
                    }
                    else if (ecd.Color == 0x02)
                    {
                        SouthCntDown.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (ecd.Color == 0x03)
                    {
                        SouthCntDown.Foreground = new SolidColorBrush(Colors.Red);
                    }
                    SouthCntDown.Text = "" + ecd.usFigure;
                }
                if (ecd.Direc == 3)
                {
                    if (ecd.Color == 0x01)
                    {
                        WestCntDown.Foreground = new SolidColorBrush(Colors.Green);
                    }
                    else if (ecd.Color == 0x02)
                    {
                        WestCntDown.Foreground = new SolidColorBrush(Colors.Yellow);
                    }
                    else if (ecd.Color == 0x03)
                    {
                        WestCntDown.Foreground = new SolidColorBrush(Colors.Red);
                    }
                    WestCntDown.Text = "" + ecd.usFigure;
                }
            }
            
        }

        private void cbxEchoCountDown_Unchecked(object sender, RoutedEventArgs e)
        {
            
            if (t == null)
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Udp.sendUdp(t.Node.sIpAddress, t.Node.iPort, Define.ECHO_TSC_COUNT_DOWN_CANCEL);
            echoCountDownDispatcherTimer.Stop();
            SouthCntDown.Text = "";
            NorthCntDown.Text = "";
            EastCntDown.Text = "";
            WestCntDown.Text = "";
        }

        private void rbnManaul_Checked(object sender, RoutedEventArgs e)
        {
            Message msg = TscDataUtils.SetCtrlMunual();
            
        }

        private void rbnManaul_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void rbnSelf_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void rbnSelf_Checked(object sender, RoutedEventArgs e)
        {
            Message msg = TscDataUtils.SetCtrlSelf();
          
        }

        private void btnNextStep_Click(object sender, RoutedEventArgs e)
        {
            Message msg = TscDataUtils.SetNextStep();
        }

        private void btnNextDirec_Click(object sender, RoutedEventArgs e)
        {
            Message msg = TscDataUtils.SetNextDirec();
        }

        private void btnNextPhase_Click(object sender, RoutedEventArgs e)
        {
            Message msg = TscDataUtils.SetNextPhase();
        }

        private void btnNorth_Click(object sender, RoutedEventArgs e)
        {
            Message msg = TscDataUtils.SetCtrlNorth();
        }

        private void btnEast_Click(object sender, RoutedEventArgs e)
        {
            Message msg = TscDataUtils.SetCtrlEast();
        }

        private void btnSouth_Click(object sender, RoutedEventArgs e)
        {
            Message msg = TscDataUtils.SetCtrlSouth();
        }

        private void btnWest_Click(object sender, RoutedEventArgs e)
        {
            Message msg = TscDataUtils.SetCtrlWest();
        }

        private void bsrRoadCount_Spin(object sender, Xceed.Wpf.Toolkit.SpinEventArgs e)
        {

        }

        private void DirecPhaseCombox_SelectChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                {
                    return;
                }
                opchannels.Content = "";
                roadcount.Content = "";
                DirectPhaseIdCombox.SelectedIndex = -1;
                List<PhaseToDirec> tscdirecphase = t.ListPhaseToDirec;

                foreach (PhaseToDirec direcphase in tscdirecphase)
                {
                    if (DirecPhaseCombox.SelectedIndex == -1)
                        return;
                    if (direcphase.ucId == ((MusicView.DirecNumer)(DirecPhaseCombox.SelectedValue)).value)
                    {
                        roadcount.Content = direcphase.ucRoadCnt.ToString();
                        foreach (MusicView.ChannelPhaseOverlap cpo in lcpo)
                        {
                            if (cpo.id == direcphase.ucPhase && cpo.isPhase == true && direcphase.ucOverlapPhase == 0)
                            {
                                DirectPhaseIdCombox.SelectedIndex = cpo.id - 1;
                                break;
                            }
                            else if (cpo.id == direcphase.ucOverlapPhase && cpo.isPhase == false && direcphase.ucPhase == 0)
                            {
                                DirectPhaseIdCombox.SelectedIndex = cpo.id + 0x20 - 1;
                                break;
                            }

                        }
                        foreach (Channel ch in t.ListChannel)
                        {
                            byte phaseid = ((MusicView.ChannelPhaseOverlap) (DirectPhaseIdCombox.SelectedValue)).id;
                            bool bisphase =((MusicView.ChannelPhaseOverlap) (DirectPhaseIdCombox.SelectedValue)).isPhase;
                            if (phaseid == ch.ucSourcePhase)
                            {
                                if ((bisphase == true && ch.ucType != 0x4) || (bisphase == false && ch.ucType == 0x4))
                                {
                                    opchannels.Content += ch.ucId.ToString() + " ,";
                                    if (ch.ucType == 0x4)
                                    {
                                        opchannels.Background = Brushes.Yellow;
                                    }
                                    else if (ch.ucType == 0x3)
                                    {
                                        opchannels.Background = Brushes.Green;
                                    }
                                    else
                                    {
                                        opchannels.Background = Brushes.Red;
                                    }
                                }
                            }
                        }
                        break;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("获取方向相关参数异常!");
            }

        }


    }
}
