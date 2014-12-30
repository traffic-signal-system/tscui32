using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using System.Windows;
using System.Windows.Media.Imaging;
using tscui.Models;
using tscui.Service;
using System.Windows.Threading;

namespace tscui.Pages.Stage
{
    /// <summary>
    /// Interaction logic for StageView.xaml
    /// </summary>
    [View(typeof(StageViewModel))]
    public partial class StageView : UserControl,IView
    {
        public static List<StageItem> lsi = new List<StageItem>();
        public delegate void InitStageItemToLSI();
        public delegate void DelegateInitcbxCoordination();
        public delegate void DelegateInitStageNumber();
        TscData t;
        private void initStageItemList()
        {
            lsi.Add(stage1);
            lsi.Add(stage2);
            lsi.Add(stage3);
            lsi.Add(stage4);
            lsi.Add(stage5);
            lsi.Add(stage6);
            lsi.Add(stage7);
            lsi.Add(stage8);
            lsi.Add(stage9);
            lsi.Add(stage10);
            lsi.Add(stage11);
            lsi.Add(stage12);
            lsi.Add(stage13);
            lsi.Add(stage14);
            lsi.Add(stage15);
            lsi.Add(stage16);
        }
        public static StageItem currentStage ;
        public StageView()
        {
            InitializeComponent();
            this.Stageviewcanvas.AddHandler(Image.MouseLeftButtonDownEvent, new RoutedEventHandler(StageImageMouseLeftButton_Down));
            this.Stageviewcanvas.AddHandler(Image.MouseRightButtonDownEvent, new RoutedEventHandler(StageImageMouseRightButton_Down));


        }

        private void StageImageMouseRightButton_Down(object sender, RoutedEventArgs e)
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                if (e.OriginalSource != null)
                {
                    Image ClickImage = e.OriginalSource as Image;
                    if (ClickImage != null)
                    {
                        if (currentStage != null)
                        {
                            List<StagePattern> lsp = t.ListStagePattern;
                            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                            Byte DirecNumber = 0xff;
                            string DirecName = ClickImage.Name;

                            BitmapImage imageredlight = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
                            BitmapImage imageredlight1 = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));

                            switch (DirecName)
                            {
                                case "northLeft":
                                    currentStage.northLeft.Source = imageredlight;
                                    northLeft.Source = imageredlight;
                                    DirecNumber = Define.NORTH_LEFT;
                                    break;
                                case "northStraight":
                                    currentStage.northStraight.Source = imageredlight;
                                    northStraight.Source = imageredlight;
                                    DirecNumber = Define.NORTH_STRAIGHT;
                                    break;
                                case "northRight":
                                    currentStage.northRight.Source = imageredlight;
                                    northRight.Source = imageredlight;
                                    DirecNumber = Define.NORTH_RIGHT;
                                    break;
                                case "northPedestrain1":
                                    currentStage.northPedestrain1.Source = imageredlight1;
                                    northPedestrain1.Source = imageredlight1;
                                    DirecNumber = Define.NORTH_PEDESTRAIN_ONE;
                                    break;
                                case "northTurn":
                                    currentStage.northTurn.Source = imageredlight;
                                    northTurn.Source = imageredlight;
                                    DirecNumber = Define.NORTH_TURN_AROUND;

                                    //MessageBox.Show("NorthTurn");
                                    break;
                                case "northOther":
                                    currentStage.northOther.Source = imageredlight;
                                    northOther.Source = imageredlight;
                                    DirecNumber = Define.NORTH_OTHER;
                                    break;
                                case "WestNorthOther":
                                    currentStage.westNorthOther.Source = imageredlight;
                                    WestNorthOther.Source = imageredlight;
                                    DirecNumber = Define.WEST_NORTH_OTHER;
                                    break;

                                case "eastLeft":
                                    currentStage.eastLeft.Source = imageredlight1;
                                    eastLeft.Source = imageredlight1;
                                    DirecNumber = Define.EAST_LEFT;
                                    break;
                                case "eastStraight":
                                    currentStage.eastStraight.Source = imageredlight1;
                                    eastStraight.Source = imageredlight1;
                                    DirecNumber = Define.EAST_STRAIGHT;
                                    break;
                                case "eastRight":
                                    currentStage.eastRight.Source = imageredlight1;
                                    eastRight.Source = imageredlight1;
                                    DirecNumber = Define.EAST_RIGHT;
                                    break;
                                case "eastPedestrain1":
                                    currentStage.eastPedestrain1.Source = imageredlight1;
                                    eastPedestrain1.Source = imageredlight;
                                    DirecNumber = Define.EAST_PEDESTRAIN_ONE;
                                    break;
                                case "eastTurn":
                                    currentStage.eastTurn.Source = imageredlight1;
                                    eastTurn.Source = imageredlight1;
                                    DirecNumber = Define.EAST_TURN_AROUND;
                                    break;
                                case "eastOther":
                                    currentStage.eastOther.Source = imageredlight1;
                                    eastOther.Source = imageredlight1;
                                    DirecNumber = Define.EAST_OTHER;
                                    break;
                                case "eastNorthOther":
                                    currentStage.eastNorthOther.Source = imageredlight1;
                                    eastNorthOther.Source = imageredlight1;
                                    DirecNumber = Define.EAST_NORTH_OTHER;
                                    break;
                                //南
                                case "southLeft":
                                    currentStage.southLeft.Source = imageredlight;
                                    southLeft.Source = imageredlight;
                                    DirecNumber = Define.SOUTH_LEFT;
                                    break;
                                case "southStraight":
                                    currentStage.southStraight.Source = imageredlight;
                                    southStraight.Source = imageredlight;
                                    DirecNumber = Define.SOUTH_STRAIGHT;
                                    break;
                                case "southRight":
                                    currentStage.southRight.Source = imageredlight;
                                    southRight.Source = imageredlight;
                                    DirecNumber = Define.SOUTH_RIGHT;
                                    break;
                                case "southPedestrain1":
                                    currentStage.southPedestrain1.Source = imageredlight1;
                                    southPedestrain1.Source = imageredlight1;
                                    DirecNumber = Define.SOUTH_PEDESTRAIN_ONE;
                                    break;
                                case "southTurn":
                                    currentStage.southTurn.Source = imageredlight;
                                    southTurn.Source = imageredlight;
                                    // southTurn.Visibility = Visibility.Hidden;
                                    DirecNumber = Define.SOUTH_TURN_AROUND;
                                    // Xceed.Wpf.Toolkit.MessageBox.Show("南调头");
                                    break;
                                case "southOther":
                                    currentStage.southOther.Source = imageredlight;
                                    southOther.Source = imageredlight;
                                    DirecNumber = Define.SOUTH_OTHER;
                                    // Xceed.Wpf.Toolkit.MessageBox.Show("南其他");
                                    break;
                                case "eastSouthOther":
                                    currentStage.eastSouthOther.Source = imageredlight;
                                    eastSouthOther.Source = imageredlight;
                                    DirecNumber = Define.EAST_SOUTH_OTHER;
                                    break;
                                //西
                                case "westLeft":
                                    currentStage.westLeft.Source = imageredlight1;
                                    westLeft.Source = imageredlight1;
                                    DirecNumber = Define.WEST_LEFT;
                                    break;
                                case "westStraight":
                                    currentStage.westStraight.Source = imageredlight1;
                                    westStraight.Source = imageredlight1;
                                    DirecNumber = Define.WEST_STRAIGHT;
                                    break;
                                case "westRight":
                                    currentStage.westRight.Source = imageredlight1;
                                    westRight.Source = imageredlight1;
                                    DirecNumber = Define.WEST_RIGHT;
                                    break;
                                case "westPedestrain1":
                                    currentStage.westPedestrain1.Source = imageredlight;
                                    westPedestrain1.Source = imageredlight;
                                    DirecNumber = Define.WEST_PEDESTRAIN_ONE;
                                    break;
                                case "westTurn":
                                    currentStage.westTurn.Source = imageredlight1;
                                    westTurn.Source = imageredlight1;
                                    DirecNumber = Define.WEST_TURN_AROUND;
                                    break;
                                case "westOther":
                                    currentStage.westOther.Source = imageredlight1;
                                    westOther.Source = imageredlight1;
                                    DirecNumber = Define.WEST_OTHER;
                                    break;
                                case "westSouthOther":
                                    currentStage.westSouthOther.Source = imageredlight1;
                                    westSouthOther.Source = imageredlight1;
                                    DirecNumber = Define.WEST_SOUTH_OTHER;
                                    break;
                                default:
                                    return;

                            }
                            foreach (StagePattern sp in lsp)
                            {
                                if (sp.ucStagePatternId == sldStagePatternId.Value)
                                {
                                    if (Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                                    {
                                        uint ap = sp.usAllowPhase;

                                        foreach (PhaseToDirec ptd in lptd)
                                        {
                                            if (ptd.ucId == DirecNumber)
                                            {
                                                sp.usAllowPhase = returnUnAllowPhase(ptd, ap);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["msg_stage_selected_stage"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("取消方向相位放行异常!");
            }
        }

        private void StageImageMouseLeftButton_Down(object sender, RoutedEventArgs e)
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                if (e.OriginalSource != null)
                {
                    Image ClickImage = e.OriginalSource as Image;
                    if (ClickImage != null)
                    {
                        if (currentStage != null)
                         {
                             List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                             List<Pattern> lp = t.ListPattern;
                             List<StagePattern> lsp = t.ListStagePattern;
                             Byte DirecNumber = 0xff;
                             string DirecName = ClickImage.Name;
                             BitmapImage imaggreenlight = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
                             BitmapImage imagegreenlight1 = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
                             switch (DirecName)
                             {
                                 case "northLeft" :
                                      currentStage.northLeft.Source = imaggreenlight;
                                      northLeft.Source = imaggreenlight;
                                      DirecNumber = Define.NORTH_LEFT;
                                     break;
                                 case  "northStraight":
                                     currentStage.northStraight.Source = imaggreenlight;
                                     northStraight.Source = imaggreenlight;
                                     DirecNumber = Define.NORTH_STRAIGHT;
                                     break;
                                 case "northRight":
                                     currentStage.northRight.Source = imaggreenlight;
                                     northRight.Source = imaggreenlight;
                                     DirecNumber = Define.NORTH_RIGHT;
                                     break;
                                 case "northPedestrain1" :
                                     currentStage.northPedestrain1.Source = imagegreenlight1;
                                     northPedestrain1.Source = imagegreenlight1;
                                     DirecNumber = Define.NORTH_PEDESTRAIN_ONE;
                                     break;
                                 case "northTurn":
                                     currentStage.northTurn.Source = imaggreenlight;
                                     northTurn.Source = imaggreenlight;
                                     DirecNumber = Define.NORTH_TURN_AROUND;
                                     break;
                                 case "northOther":
                                     currentStage.northOther.Source = imaggreenlight;
                                     northOther.Source = imaggreenlight;
                                     DirecNumber = Define.NORTH_OTHER;
                                     break;
                                 case "WestNorthOther":
                                     currentStage.westNorthOther.Source = imaggreenlight;
                                     WestNorthOther.Source = imaggreenlight;
                                     DirecNumber = Define.WEST_NORTH_OTHER;
                                     break;

                                 case "eastLeft":
                                     currentStage.eastLeft.Source = imagegreenlight1;
                                     eastLeft.Source = imagegreenlight1;
                                     DirecNumber = Define.EAST_LEFT;
                                     break;
                                 case "eastStraight":
                                     currentStage.eastStraight.Source = imagegreenlight1;
                                     eastStraight.Source = imagegreenlight1;
                                     DirecNumber = Define.EAST_STRAIGHT;
                                     break;
                                 case "eastRight":
                                     currentStage.eastRight.Source = imagegreenlight1;
                                     eastRight.Source = imagegreenlight1;
                                     DirecNumber = Define.EAST_RIGHT;
                                     break;
                                 case "eastPedestrain1":
                                     currentStage.eastPedestrain1.Source = imaggreenlight;
                                     eastPedestrain1.Source = imaggreenlight;
                                     DirecNumber = Define.EAST_PEDESTRAIN_ONE;
                                     break;
                                 case "eastTurn":
                                     currentStage.eastTurn.Source = imagegreenlight1;
                                     eastTurn.Source = imagegreenlight1;
                                     DirecNumber = Define.EAST_TURN_AROUND;
                                     break;
                                 case "eastOther":
                                     currentStage.eastOther.Source = imagegreenlight1;
                                     eastOther.Source = imagegreenlight1;
                                     DirecNumber = Define.EAST_OTHER;
                                     break;
                                 case "eastNorthOther":
                                     currentStage.eastNorthOther.Source = imagegreenlight1;
                                     eastNorthOther.Source = imagegreenlight1;
                                     DirecNumber = Define.EAST_NORTH_OTHER;
                                     break;
                                 //南
                                 case "southLeft":
                                     currentStage.southLeft.Source = imaggreenlight;
                                     southLeft.Source = imaggreenlight;
                                     DirecNumber = Define.SOUTH_LEFT;
                                     break;
                                 case "southStraight":
                                     currentStage.southStraight.Source = imaggreenlight;
                                     southStraight.Source = imaggreenlight;
                                     DirecNumber = Define.SOUTH_STRAIGHT;
                                     break;
                                 case "southRight":
                                     currentStage.southRight.Source = imaggreenlight;
                                     southRight.Source = imaggreenlight;
                                     DirecNumber = Define.SOUTH_RIGHT;
                                     break;
                                 case "southPedestrain1":
                                     currentStage.southPedestrain1.Source = imagegreenlight1;
                                     southPedestrain1.Source = imagegreenlight1;
                                     DirecNumber = Define.SOUTH_PEDESTRAIN_ONE;
                                     break;
                                 case "southTurn":
                                     currentStage.southTurn.Source = imaggreenlight;
                                     southTurn.Source = imaggreenlight;
                                    // southTurn.Visibility = Visibility.Hidden;
                                     DirecNumber = Define.SOUTH_TURN_AROUND;
                                    // Xceed.Wpf.Toolkit.MessageBox.Show("南调头");
                                     break;
                                 case "southOther":
                                     currentStage.southOther.Source = imaggreenlight;
                                     southOther.Source = imaggreenlight;
                                     DirecNumber = Define.SOUTH_OTHER;
                                    // Xceed.Wpf.Toolkit.MessageBox.Show("南其他");
                                     break;
                                 case "eastSouthOther":
                                     currentStage.eastSouthOther.Source = imaggreenlight;
                                     eastSouthOther.Source = imaggreenlight;
                                     DirecNumber = Define.EAST_SOUTH_OTHER;
                                     break;
                                 //西
                                 case "westLeft":
                                     currentStage.westLeft.Source = imagegreenlight1;
                                     westLeft.Source = imagegreenlight1;
                                     DirecNumber = Define.WEST_LEFT;
                                     break;
                                 case "westStraight":
                                     currentStage.westStraight.Source = imagegreenlight1;
                                     westStraight.Source = imagegreenlight1;
                                     DirecNumber = Define.WEST_STRAIGHT;
                                     break;
                                 case "westRight":
                                     currentStage.westRight.Source = imagegreenlight1;
                                     westRight.Source = imagegreenlight1;
                                     DirecNumber = Define.WEST_RIGHT;
                                     break;
                                 case "westPedestrain1":
                                     currentStage.westPedestrain1.Source = imaggreenlight;
                                     westPedestrain1.Source = imaggreenlight;
                                     DirecNumber = Define.WEST_PEDESTRAIN_ONE;
                                     break;
                                 case "westTurn":
                                     currentStage.westTurn.Source = imagegreenlight1;
                                     westTurn.Source = imagegreenlight1;
                                     DirecNumber = Define.WEST_TURN_AROUND;
                                     break;
                                 case "westOther":
                                     currentStage.westOther.Source = imagegreenlight1;
                                     westOther.Source = imagegreenlight1;
                                     DirecNumber = Define.WEST_OTHER;
                                     break;
                                 case "westSouthOther":
                                     currentStage.westSouthOther.Source = imagegreenlight1;
                                     westSouthOther.Source = imagegreenlight1;
                                     DirecNumber = Define.WEST_SOUTH_OTHER;
                                     break;
                                 default:
                                     return;

                             }
                             foreach (PhaseToDirec ptd in lptd)
                             {
                                 if (ptd.ucId == DirecNumber)
                                 {
                                     if (ptd.ucPhase != 0)
                                     {
                                         setPatternAndStagePattern(lp, lsp, currentStage, ptd);
                                         break;

                                     }
                                 }
                             }
                        }
                    else
                    {
                       MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["msg_stage_selected_stage"]);
                    }
                  }
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("选择方向相位放行异常!");
            }
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
            //初始化当前阶段
            currentStage = stage1;
            DispatcherInitStageNum();
            DispatcherInitStageItem();
            DispatcherInitCoordination();
            //初始化所有数据到界面上
            initStageAttriable(t);
          
           

        }
        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {

        }
        public void BigMap4SmallMap(StageItem si)
        {
            try
            {
                //北方向
                this.northLeft.Source = si.northLeft.Source;
                this.northStraight.Source = si.northStraight.Source;
                this.northRight.Source = si.northRight.Source;
                this.northOther.Source = si.northOther.Source;
                this.northPedestrain1.Source = si.northPedestrain1.Source;
                this.northPedestrain2.Source = si.northPedestrain2.Source;
                this.northTurn.Source = si.northTurn.Source;
                this.WestNorthOther.Source = si.westNorthOther.Source;
                //南方向
                this.southLeft.Source = si.southLeft.Source;
                this.southStraight.Source = si.southStraight.Source;
                this.southRight.Source = si.southRight.Source;
                this.southOther.Source = si.southOther.Source;
                this.southPedestrain1.Source = si.southPedestrain1.Source;
                this.southPedestrain2.Source = si.southPedestrain2.Source;
                this.southTurn.Source = si.southTurn.Source;
                this.eastSouthOther.Source = si.eastSouthOther.Source;

                //东方向
                this.eastLeft.Source = si.eastLeft.Source;
                this.eastStraight.Source = si.eastStraight.Source;
                this.eastRight.Source = si.eastRight.Source;
                this.eastOther.Source = si.eastOther.Source;
                this.eastPedestrain1.Source = si.eastPedestrain1.Source;
                this.eastPedestrain2.Source = si.eastPedestrain2.Source;
                this.eastTurn.Source = si.eastTurn.Source;
                this.eastNorthOther.Source = si.eastNorthOther.Source;

                //西方向
                this.westLeft.Source = si.westLeft.Source;
                this.westStraight.Source = si.westStraight.Source;
                this.westRight.Source = si.westRight.Source;
                this.westOther.Source = si.westOther.Source;
                this.westPedestrain1.Source = si.westPedestrain1.Source;
                this.westPedestrain2.Source = si.westPedestrain2.Source;
                this.westTurn.Source = si.westTurn.Source;
                this.westSouthOther.Source = si.westSouthOther.Source;
            }
            catch (Exception ex)
            {

                MessageBox.Show("右边小图转左边大图异常!");
            }

        }



        /// <summary>
        /// 通过点击小图，可以将数据更新给
        /// 周期
        /// 相位差
        /// 协调相位
        /// 感应
        /// 红灯时间
        /// 绿灯时间
        /// 黄灯时间
        /// </summary>
        /// <param name="currentStage"></param>
        private void smallMap4Form(StageItem currentStage)
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                List<Pattern> lp = t.ListPattern;
                if (t.ListStagePattern.Count == 0)
                {
                    StagePattern newStagePattern = new StagePattern();
                    newStagePattern.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                    newStagePattern.ucStageNo = 1;
                    newStagePattern.ucGreenTime = 10;
                    newStagePattern.ucYellowTime = 3;
                    newStagePattern.ucRedTime = 0;
                    newStagePattern.usAllowPhase = 0;
                    newStagePattern.ucOption = 1;
                    t.ListStagePattern.Add(newStagePattern);
                }
                List<StagePattern> lsp = t.ListStagePattern;

                foreach (Pattern p in lp)
                {
                    if (sldSchemeId.Value == p.ucPatternId)
                    {
                        if (p.ucStagePatternId == (byte)(sldStagePatternId.Value))
                        {
                            tbxCycle.Text = p.ucCycleTime.ToString();
                            tbxOffset.Text = p.ucOffset.ToString();
                            cbxCoordination.SelectedItem = p.ucCoorPhase;
                            cbxReaction.IsChecked = false;
                        }
                        foreach (StagePattern sp in lsp)
                        {

                            if (sp.ucStagePatternId == Convert.ToByte(sldStagePatternId.Value) && sp.ucStageNo == Convert.ToByte(currentStage.lblNumber.Content.ToString()))
                            {
                                sldGreenTime.Value = sp.ucGreenTime;
                                sldYellowTime.Value = sp.ucYellowTime;
                                sldRedTime.Value = sp.ucRedTime;
                                break;

                            }
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取阶段" +currentStage.lblNumber +"信息异常!");

            }


        }
       
        private uint returnUnAllowPhase(PhaseToDirec  ptd, uint ap)
        {
            uint temp = 1;
            uint c = (~(temp << (ptd.ucPhase - 1))) & ap;
            //ap = c;
            return c;
        }
        /// <summary>
        /// /返回当前 checkbox是否被选中
        /// 选中：  表示为感应阶段，0x00
        /// 不选中：表示不是感应阶段，0x01
        /// </summary>
        /// <returns></returns>
        public byte returnReactionTrueOrFalse()
        {
            if (cbxReaction.IsChecked == true)
            {
                return 0x00;
            }
            else
            {
                return 0x01;
            }
        }
        /// <summary>
        /// 将allowPhase 通过左移 phase -1 位。
        /// </summary>
        /// <param name="phase"></param>
        /// <param name="allowPhase"></param>
        /// <returns></returns>
        private uint returnAllowPhase(byte phase,uint allowPhase)
        {
            uint temp = 1;
            //uint tempint = Convert.ToUInt32(phase);
            uint c = (temp << (phase-1)) | allowPhase;
            return c;
        }
        private void setPatternAndStagePattern(List<Pattern> lp ,List<StagePattern> lsp , StageItem currentStage,PhaseToDirec ptd)
        {
            //半断是新增加stage还是，老的更新用的
            Pattern ptemp= null;
           // List<Pattern> lptemp = new List<Pattern>();
            bool newPattern = false;
            bool oldPattern = false;
            foreach(Pattern p in lp)
            {
               
                if (sldSchemeId.Value == p.ucPatternId )
                {
                    p.ucCoorPhase = Convert.ToByte(cbxCoordination.SelectedItem);
                    p.ucCycleTime = Convert.ToByte(tbxCycle.Text);
                    p.ucOffset = Convert.ToByte(tbxOffset.Text);
                    p.ucPatternId = Convert.ToByte(sldSchemeId.Value);
                    p.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                    oldPattern = true;
                    //if (sldStagePatternId.Value == p.ucStagePatternId)
                    //{
                    //    p.ucCoorPhase = Convert.ToByte(cbxCoordination.SelectedItem);
                    //    p.ucCycleTime = Convert.ToByte(tbxCycle.Text);
                    //    p.ucOffset = Convert.ToByte(tbxOffset.Text);
                    //    p.ucPatternId = Convert.ToByte(sldSchemeId.Value);
                    //    p.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                    //}
                    //else
                    //{
                       
                    //}
                    //p.ucPatternId = Convert.ToByte(sldSchemeId.Value);
                    //p.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                    //ptemp = null;
                }
                else
                {
                    newPattern = true;
                }
            
            }
            if (!oldPattern)
            {
                if (newPattern)
                {
                    ptemp = new Pattern();
                    ptemp.ucCoorPhase = Convert.ToByte(cbxCoordination.SelectedItem);
                    ptemp.ucCycleTime = Convert.ToByte(tbxCycle.Text);
                    ptemp.ucOffset = Convert.ToByte(tbxOffset.Text);
                    ptemp.ucPatternId = Convert.ToByte(sldSchemeId.Value);
                    ptemp.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                    lp.Add(ptemp);
                }
               
            }
            //if (!lp.Contains(ptemp))//这里主要 是，新的方案号需要增加。旧的方案，不用进行增加，
            //{
                
            //}
           
            

            foreach (StagePattern sp in lsp)
            {
                if (sp.ucStagePatternId == sldStagePatternId.Value)
                {
                    
                    if (sp.ucStageNo == Convert.ToByte(currentStage.lblNumber.Content))
                    {
                        sp.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                        sp.ucStageNo = Convert.ToByte(currentStage.lblNumber.Content);
                        sp.ucGreenTime = Convert.ToByte(sldGreenTime.Value);
                        sp.ucYellowTime = Convert.ToByte(sldYellowTime.Value);
                        sp.ucRedTime = Convert.ToByte(sldRedTime.Value);
                        sp.ucOption = returnReactionTrueOrFalse();
                        sp.usAllowPhase = returnAllowPhase(ptd.ucPhase, sp.usAllowPhase);
                        Console.WriteLine(sp.usAllowPhase);
                        break;
                    }
                    else if(sp.ucStageNo == 0)
                    {
                        sp.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
                        sp.ucStageNo = Convert.ToByte(currentStage.lblNumber.Content);
                        sp.ucGreenTime = Convert.ToByte(sldGreenTime.Value);
                        sp.ucYellowTime = Convert.ToByte(sldYellowTime.Value);
                        sp.ucRedTime = Convert.ToByte(sldRedTime.Value);
                        sp.ucOption = returnReactionTrueOrFalse();
                        sp.usAllowPhase = returnAllowPhase(ptd.ucPhase, sp.usAllowPhase);
                        Console.WriteLine(sp.usAllowPhase);
                        break;
                    }
                    else
                    {
                        //MessageBox.Show("研发专用，程序异常。没有进行stage，stageNo 不为0，也不为小图上的编号\n");
                    }
                }
            }
               
        }
   
        #region 子阶段鼠标单击选中处理
        private void stage1_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage1;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }
        private void stage2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage2;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage3_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage3;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage4_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage4;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage5_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage5;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage6_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage6;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage7_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage7;
            BigMap4SmallMap(currentStage);
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage8_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage8;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage9_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage9;
            BigMap4SmallMap(currentStage); //MessageBox.Show("stage1");
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage10_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage10;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage11_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage11;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage12_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage12;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage13_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage13;
            BigMap4SmallMap(currentStage); //MessageBox.Show("stage1");
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage14_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage14;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage15_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage15;
            BigMap4SmallMap(currentStage);//MessageBox.Show("stage1");
            smallMap4Form(currentStage);
            stageNumber.Content = currentStage.lblNumber.Content;
        }

        private void stage16_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            currentStage = stage16;
            smallMap4Form(currentStage);
            BigMap4SmallMap(currentStage); //MessageBox.Show("stage1");
            stageNumber.Content = currentStage.lblNumber.Content;
        }
        #endregion
        private void savePattern()
        {
            List<Pattern> lp = t.ListPattern;
            Pattern newpattern = new Pattern();
            newpattern.ucPatternId = (byte)(sldSchemeId.Value);
            newpattern.ucCycleTime = Convert.ToByte(tbxCycle.Text);
            newpattern.ucCoorPhase = Convert.ToByte(cbxCoordination.Text);
            newpattern.ucOffset = Convert.ToByte(tbxOffset.Text);
            newpattern.ucStagePatternId = Convert.ToByte(sldStagePatternId.Value);
            bool baddnewpattern = true;
            foreach (Pattern p in t.ListPattern)
             {
                 if (p.ucPatternId == ((byte)sldSchemeId.Value))
                 {
                      p.ucCycleTime = newpattern.ucCycleTime;
                      p.ucCoorPhase = newpattern.ucCoorPhase;
                      p.ucOffset = newpattern.ucOffset;
                      p.ucStagePatternId = newpattern.ucStagePatternId;
                      baddnewpattern = false;
                      break;
                  }
             }
            if (baddnewpattern == true)
            {
                MessageBox.Show("该方案不存在，新添加此方案！");
                t.ListPattern.Add(newpattern);    
            }
            
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (t == null)
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            savePattern();
            Message msgPattern = TscDataUtils.SetPattern(t.ListPattern);
            System.Threading.Thread.Sleep(500);
            Message msgStagePattern = TscDataUtils.SetStagePattern(t.ListStagePattern);
            if (!msgStagePattern.flag || !msgPattern.flag)
            {
                MessageBox.Show("对象：" + msgStagePattern.obj + "\n内容：" + msgStagePattern.msg);
            }
            else
            {
                MessageBox.Show("方案和阶段配时保存成功");
            }
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            if (t == null)
                return;
            List<StagePattern> lsp = t.ListStagePattern;
            List<Pattern> lp = t.ListPattern;
        }
        private void visiableStage(StagePattern sp)
        {
            if (sp == null)
                return;
            switch (sp.ucStageNo)
            {
                case 1:
                    stage1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    stage2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    stage3.Visibility = Visibility.Visible;
                    break;
                case 4:
                    stage4.Visibility = Visibility.Visible;
                    break;
                case 5:
                    stage5.Visibility = Visibility.Visible;
                    break;
                case 6:
                    stage6.Visibility = Visibility.Visible;
                    break;
                case 7:
                    stage7.Visibility = Visibility.Visible;
                    break;
                case 8:
                    stage8.Visibility = Visibility.Visible;
                    break;
                case 9:
                    stage9.Visibility = Visibility.Visible;
                    break;
                case 10:
                    stage10.Visibility = Visibility.Visible;
                    break;
                case 11:
                    stage11.Visibility = Visibility.Visible;
                    break;
                case 12:
                    stage12.Visibility = Visibility.Visible;
                    break;
                case 13:
                    stage13.Visibility = Visibility.Visible;
                    break;
                case 14:
                    stage14.Visibility = Visibility.Visible;
                    break;
                case 15:
                    stage15.Visibility = Visibility.Visible;
                    break;
                case 16:
                    stage16.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
           
        }
        /// <summary>
        /// 问题代码 ，请不要调用
        /// </summary>
        /// <param name="l"></param>
        private void clearStagePatternByNoStageNu(List<StagePattern> l)
        {
            foreach(StagePattern p in l)
            {
                if (p.ucStageNo ==0 )
                {
                    l.Remove(p);
                }
            }
        }
        public void initcbxCoordination()
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                return;
            List<PhaseToDirec> lptd = t.ListPhaseToDirec;
            
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucPhase != 0)
                {
                    cbxCoordination.Items.Add(ptd.ucPhase);
                }
            }
        }
        /// <summary>
        /// 初始化每个Stage的编号。
        /// </summary>
        public void initStageNumber()
        {
            stage1.lblNumber.Content = "1";
            stage2.lblNumber.Content = "2";
            stage3.lblNumber.Content = "3";
            stage4.lblNumber.Content = "4";
            stage5.lblNumber.Content = "5";
            stage6.lblNumber.Content = "6";
            stage7.lblNumber.Content = "7";
            stage8.lblNumber.Content = "8";
            stage9.lblNumber.Content = "9";
            stage10.lblNumber.Content = "10";
            stage11.lblNumber.Content = "11";
            stage12.lblNumber.Content = "12";
            stage13.lblNumber.Content = "13";
            stage14.lblNumber.Content = "14";
            stage15.lblNumber.Content = "15";
            stage16.lblNumber.Content = "16";
        }

        private void initBigMapArrow()
        {
            List<PhaseToDirec> lptd = Utils.Utils.GetTscDataByApplicationCurrentProperties().ListPhaseToDirec;
            if (lptd == null)
                return;
            foreach (PhaseToDirec ptd in lptd)
            {
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_LEFT)
                {
                    northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_LEFT_STRAIGHT)
                {
                   // northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_LEFT_STRAIGHT_RIGHT)
                {
                   // northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_OTHER)
                {
                    northOther.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_PEDESTRAIN_ONE)
                {
                    northPedestrain1.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_PEDESTRAIN_TWO)
                {
                    northPedestrain2.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_RIGHT)
                {
                    northRight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_RIGHT_STRAIGHT)
                {
                   // northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_STRAIGHT)
                {
                    northStraight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.NORTH_TURN_AROUND)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                //东
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_LEFT)
                {
                    eastLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_LEFT_STRAIGHT)
                {
                    //east.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_LEFT_STRAIGHT_RIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_OTHER)
                {
                    eastOther.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_PEDESTRAIN_ONE)
                {
                    eastPedestrain1.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_PEDESTRAIN_TWO)
                {
                    eastPedestrain2.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_RIGHT)
                {
                    eastRight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_RIGHT_STRAIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_STRAIGHT)
                {
                    eastStraight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.EAST_TURN_AROUND)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                
                //东
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_LEFT)
                {
                    southLeft.Visibility = Visibility.Hidden;
                }

                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_LEFT_STRAIGHT)
                {
                    //east.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_LEFT_STRAIGHT_RIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_OTHER)
                {
                    southOther.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE)
                {
                    southPedestrain1.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO)
                {
                    southPedestrain2.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_RIGHT)
                {
                    southRight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_RIGHT_STRAIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_STRAIGHT)
                {
                    southStraight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.SOUTH_TURN_AROUND)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                //西
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_LEFT)
                {
                    westLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_LEFT_STRAIGHT)
                {
                    //east.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_LEFT_STRAIGHT_RIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_OTHER)
                {
                    westOther.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_PEDESTRAIN_ONE)
                {
                    westPedestrain1.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_PEDESTRAIN_TWO)
                {
                    westPedestrain2.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_RIGHT)
                {
                    westRight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_RIGHT_STRAIGHT)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_STRAIGHT)
                {
                    westStraight.Visibility = Visibility.Hidden;
                }
                if (ptd.ucPhase == 0 && ptd.ucId == Define.WEST_TURN_AROUND)
                {
                    //northLeft.Visibility = Visibility.Hidden;
                }
            }
        }
       
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="t"></param>
        private void initStageAttriable(TscData t)
        {
            try
            {
                if (t == null)
                    return;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                List<Pattern> lp = t.ListPattern;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (Pattern p in lp)
                {                    
                    tbxCycle.Text = p.ucCycleTime.ToString();
                    cbxCoordination.SelectedItem = p.ucCoorPhase;
                    tbxOffset.Text = p.ucOffset.ToString();
                    sldStagePatternId.Value = p.ucStagePatternId;
                    foreach (StagePattern sp in lsp)
                    {
                        if (sp.ucStageNo != 0)
                        {
                            visiableStage(sp);  //stage 默认是不显示的。只有存在的情况下才显示出来。ucStageNo为0不存在。
                            uint ap = sp.usAllowPhase;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((ap >> i) & 0x01) == 0x01)
                                {
                                    foreach (PhaseToDirec ptd in lptd)
                                    {
                                        if (ptd.ucPhase != 0)
                                        {
                                            if (ptd.ucPhase == (i + 1))
                                            {
                                                //初始化
                                                InitStageDirec(ptd, sp);
                                            }
                                        }
                                        else
                                        {
                                            initDirecArrow(ptd, sp);
                                        }
                                    }
                                }
                            }

                            sldGreenTime.Value = sp.ucGreenTime;
                            sldYellowTime.Value = sp.ucYellowTime;
                            sldRedTime.Value = sp.ucRedTime;
                            cbxReaction.IsChecked = true;//sp.ucOption;
                            // sp.ucStageNo   各个阶段编号，已经固定生成
                            
                        }
                    }
                    sldSchemeId.Value = p.ucPatternId;   //sldSchemeId有一个valuechanged事件。必需要放到其它属性之后 。不然会存在 问题
                    break;   //第一条方案记录，及些方案数据的stagepatternid 相关的stagepattern 数据列出。 其它不进行显示
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
        /// <summary>
        /// 根据方向表，可以得到哪个方向有配置相位。哪个方向没有配置相位，
        /// 根据方向表的相位字段，可以将方向隐藏起来
        /// </summary>
        /// <param name="ptd"></param>
        /// <param name="sp"></param>
        private void initDirecArrow(PhaseToDirec ptd, StagePattern sp)
        {
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_ONE && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northPedestrain1.Visibility = Visibility.Hidden;
                northPedestrain1.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_PEDESTRAIN_TWO && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northPedestrain2.Visibility = Visibility.Hidden;
                northPedestrain2.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_TURN_AROUND && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_LEFT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_RIGHT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_LEFT_STRAIGHT_RIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));

            }
            if (ptd.ucId == Define.NORTH_LEFT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northLeft.Visibility = Visibility.Hidden;
                northLeft.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_STRAIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northStraight.Visibility = Visibility.Hidden;
                northStraight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_RIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northRight.Visibility = Visibility.Hidden;
                northRight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.NORTH_OTHER && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.northOther.Visibility = Visibility.Hidden;
                northOther.Visibility = Visibility.Hidden;
            }
            // 南
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_ONE && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southPedestrain1.Visibility = Visibility.Hidden;
                southPedestrain1.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_PEDESTRAIN_TWO && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southPedestrain2.Visibility = Visibility.Hidden;
                southPedestrain2.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_LEFT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT_STRAIGHT_RIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_RIGHT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.SOUTH_LEFT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southLeft.Visibility = Visibility.Hidden;
                southLeft.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_OTHER && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southOther.Visibility = Visibility.Hidden;
                southOther.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_RIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southRight.Visibility = Visibility.Hidden;
                southRight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.SOUTH_STRAIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.southStraight.Visibility = Visibility.Hidden;
                southStraight.Visibility = Visibility.Hidden;
            }
            // 西
            if (ptd.ucId == Define.WEST_PEDESTRAIN_ONE && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westPedestrain1.Visibility = Visibility.Hidden;
                westPedestrain1.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_PEDESTRAIN_TWO && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westPedestrain2.Visibility = Visibility.Hidden;
                westPedestrain2.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_LEFT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT_STRAIGHT_RIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_RIGHT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.WEST_LEFT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westLeft.Visibility = Visibility.Hidden;
                westLeft.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_STRAIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westStraight.Visibility = Visibility.Hidden;
                westStraight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_RIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westRight.Visibility = Visibility.Hidden;
                westRight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.WEST_OTHER && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.westOther.Visibility = Visibility.Hidden;
                westOther.Visibility = Visibility.Hidden;
            }

            if (ptd.ucId == Define.EAST_PEDESTRAIN_ONE && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastPedestrain1.Visibility = Visibility.Hidden;
                eastPedestrain1.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_PEDESTRAIN_TWO && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastPedestrain2.Visibility = Visibility.Hidden;
                eastPedestrain2.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_LEFT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT_STRAIGHT_RIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_RIGHT_STRAIGHT && ptd.ucPhase == 0)
            {
                //StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                //si.eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            }
            if (ptd.ucId == Define.EAST_LEFT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastLeft.Visibility = Visibility.Hidden;
                eastLeft.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_STRAIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastStraight.Visibility = Visibility.Hidden;
                eastStraight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_RIGHT && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastRight.Visibility = Visibility.Hidden;
                eastRight.Visibility = Visibility.Hidden;
            }
            if (ptd.ucId == Define.EAST_OTHER && ptd.ucPhase == 0)
            {
                StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                si.eastOther.Visibility = Visibility.Hidden;
                eastOther.Visibility = Visibility.Hidden;
            }



        }
        /// <summary>
        /// 通过stageno 得到stageitem对象
        /// </summary>
        /// <param name="stageNo"></param>
        /// <returns></returns>
        private StageItem returnStageItemObjectByStageNo(byte stageNo)
        {
            switch (stageNo)
            {
                case 1:
                    return stage1;
                case 2:
                    return stage2;
                case 3:
                    return stage3;
                case 4:
                    return stage4;
                case 5:
                    return stage5;
                case 6:
                    return stage6;
                case 7:
                    return stage7;
                case 8:
                    return stage8;
                case 9:
                    return stage9;
                case 10:
                    return stage10;
                case 11:
                    return stage11;
                case 12:
                    return stage12;
                case 13:
                    return stage13;
                case 14:
                    return stage14;
                case 15:
                    return stage15;
                case 16:
                    return stage16;
                default:
                    return null;
            }
            
            
        }

        private void ResetStageDirec(StageItem si)
        {
            if (si == null)
                return;
            BitmapImage redBitmapImage = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            BitmapImage redBitmapImage1 = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            //北方
            si.northPedestrain1.Source = redBitmapImage1;
            si.northPedestrain2.Source = redBitmapImage1;
            si.northLeft.Source = redBitmapImage;
            si.northStraight.Source = redBitmapImage;
            si.northRight.Source = redBitmapImage;
            si.northOther.Source = redBitmapImage;
            si.northTurn.Source = redBitmapImage;
            si.westNorthOther.Source = redBitmapImage;
            //东方
            si.eastPedestrain1.Source = redBitmapImage;
            si.eastPedestrain2.Source = redBitmapImage;
            si.eastLeft.Source = redBitmapImage1;
            si.eastStraight.Source = redBitmapImage1;
            si.eastRight.Source = redBitmapImage1;
            si.eastOther.Source = redBitmapImage1;
            si.eastTurn.Source = redBitmapImage1;
            si.eastNorthOther.Source = redBitmapImage1;

            //南方
            si.southPedestrain1.Source = redBitmapImage1;
            si.southPedestrain2.Source = redBitmapImage1;
            si.southLeft.Source = redBitmapImage;
            si.southOther.Source = redBitmapImage;
            si.southRight.Source = redBitmapImage;
            si.southStraight.Source = redBitmapImage;
            si.southTurn.Source = redBitmapImage;
            si.eastSouthOther.Source = redBitmapImage;

            //西方
            si.westPedestrain1.Source = redBitmapImage;
            si.westPedestrain2.Source = redBitmapImage;
            si.westLeft.Source = redBitmapImage1;
            si.westStraight.Source = redBitmapImage1;
            si.westRight.Source = redBitmapImage1;
            si.westOther.Source = redBitmapImage1;
            si.westTurn.Source = redBitmapImage1;
            si.westSouthOther.Source = redBitmapImage1;
        }


        /// <summary>
        /// 通过方向 表和阶段表可以确定，相应的相位已经配置上去。
        /// </summary>
        /// <param name="ptd"></param>
        /// <param name="sp"></param>
        private void InitStageDirec(PhaseToDirec ptd,StagePattern sp)
        {
            if (ptd == null || sp == null)
            {
                MessageBox.Show("相位方向表或阶段配时表为空，无法初始化阶段配时图");
                return;
            }
            StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
            BitmapImage greenimage = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative));
            BitmapImage greenimage1 = new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight1.png", UriKind.Relative));
            new BitmapImage(new Uri("/tscui;component/Resources/Images/greenlight.png", UriKind.Relative)); 
            switch (ptd.ucId)
            {
                //北方
                case  (Define.NORTH_PEDESTRAIN_ONE) :
                    si.northPedestrain1.Source = greenimage1;
                    break;
                case (Define.NORTH_PEDESTRAIN_TWO):
                    si.northPedestrain2.Source = greenimage1;
                    break;
                case (Define.NORTH_LEFT):
                    si.northLeft.Source = greenimage;
                    break;
                case (Define.NORTH_STRAIGHT):
                    si.northStraight.Source = greenimage;
                    break;
                case (Define.NORTH_RIGHT):
                    si.northRight.Source = greenimage;
                    break;
                case (Define.NORTH_TURN_AROUND):
                    si.northTurn.Source = greenimage;
                    break;
                case (Define.NORTH_OTHER):
                    si.northOther.Source = greenimage;
                    break;
                case (Define.WEST_NORTH_OTHER):
                    si.westNorthOther.Source = greenimage;
                    break;
                  //南方
                case (Define.SOUTH_PEDESTRAIN_ONE):
                    si.southPedestrain1.Source = greenimage1;
                    break;
                case (Define.SOUTH_PEDESTRAIN_TWO):
                    si.southPedestrain2.Source = greenimage1;
                    break;
                case (Define.SOUTH_LEFT):
                    si.southLeft.Source = greenimage;
                    break;
                case (Define.SOUTH_STRAIGHT):
                    si.southStraight.Source = greenimage;
                    break;
                case (Define.SOUTH_RIGHT):
                    si.southRight.Source = greenimage;
                    break;
                case (Define.SOUTH_TURN_AROUND) :
                    si.southTurn.Source = greenimage;
                    break;
                case (Define.SOUTH_OTHER) :
                    si.southOther.Source = greenimage;
                    break;
                case (Define.EAST_SOUTH_OTHER):
                    si.eastSouthOther.Source = greenimage;
                    break;
                //东方
                case (Define.EAST_PEDESTRAIN_ONE):
                    si.eastPedestrain1.Source = greenimage;
                    break;
                case (Define.EAST_PEDESTRAIN_TWO):
                    si.eastPedestrain2.Source = greenimage;
                    break;
                case (Define.EAST_LEFT):
                    si.eastLeft.Source = greenimage1;
                    break;
                case (Define.EAST_STRAIGHT):
                    si.eastStraight.Source = greenimage1;
                    break;
                case (Define.EAST_RIGHT):
                    si.eastRight.Source = greenimage1;
                    break;
                case (Define.EAST_TURN_AROUND):
                    si.eastTurn.Source = greenimage1;
                    break;
                case (Define.EAST_OTHER):
                    si.eastOther.Source = greenimage1;
                    break;
                case (Define.EAST_NORTH_OTHER):
                    si.eastNorthOther.Source = greenimage1;
                    break;
                //西方
                case (Define.WEST_PEDESTRAIN_ONE):
                    si.westPedestrain1.Source = greenimage;
                    break;
                case (Define.WEST_PEDESTRAIN_TWO):
                    si.westPedestrain2.Source = greenimage;
                    break;
                case (Define.WEST_LEFT):
                    si.westLeft.Source = greenimage1;
                    break;
                case (Define.WEST_STRAIGHT):
                    si.westStraight.Source = greenimage1;
                    break;
                case (Define.WEST_RIGHT):
                    si.westRight.Source = greenimage1;
                    break;
                case (Define.WEST_TURN_AROUND):
                    si.westTurn.Source = greenimage1;
                    break;
                case (Define.WEST_OTHER):
                    si.westOther.Source = greenimage1;
                    break;
                case (Define.WEST_SOUTH_OTHER):
                    si.westSouthOther.Source = greenimage1;
                    break;
                default:
                    break;
            }

            return;
           
        

        }
        

        private void DispatcherInitStageNum()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitStageNumber(initStageNumber));
        }
        private void DispatcherInitStageItem()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new InitStageItemToLSI(initStageItemList));
        }
        private void DispatcherInitCoordination()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitcbxCoordination(initcbxCoordination));
        }
       

        private void StackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ///MessageBox.Show("addd stage");
        }


        private void hiddenStageAll()
        {
            foreach (StageItem si in lsi)
            {
              si.Visibility = Visibility.Hidden;
            }
        }
        /// <summary>
        /// 隐藏所有的stage 图
        /// </summary>
        private void hiddenStage(StagePattern sp)
        {
          
            foreach (StageItem si in lsi)
            {
                if (sp.usAllowPhase == 0)
                {
                    si.Visibility = Visibility.Hidden;
                    //break;
                }
            }
        }
        private void clearStageByDeleteStage(TscData t,StageItem si)
        {
            if (t == null)
                return;
            List<StagePattern> lsp = t.ListStagePattern;
            foreach(StagePattern sp in lsp)
            {
                if(sldStagePatternId.Value == sp.ucStagePatternId)
                {
                    if (sp.ucStageNo == Convert.ToByte(si.lblNumber.Content))
                    {
                        sp.ucStageNo = 0;
                        sp.ucGreenTime = 0;
                        sp.ucOption = 0;
                        sp.ucRedTime = 0;
                        sp.ucYellowTime = 0;
                        sp.usAllowPhase = 0;
                    }
                }
                
            }
        }
        private void ScrollViewer_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                if (lsi[0] == stage1)
                {
                    lsi.Reverse();
                }
                foreach (StageItem si in lsi)
                {
                    if (si.Visibility == Visibility.Visible)
                    {
                        si.Visibility = Visibility.Hidden;
                        clearStageByDeleteStage(t, si);
                        bigMapInitArllowRed();
                        lsi.Reverse();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除阶段");
            }
        }
        private void bigMapInitArllowRed()
        {
            northLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            northOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            northRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            northStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            northPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            northPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));

            eastLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            eastPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            eastPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));

            southLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            southPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            southPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));

            westLeft.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westOther.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westRight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westStraight.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            westPedestrain1.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            westPedestrain2.Source = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
        }
        private void createStageByInitArllowRed(StageItem si)
        {
            BitmapImage redlight = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight.png", UriKind.Relative));
            BitmapImage redlight1 = new BitmapImage(new Uri("/tscui;component/Resources/Images/redlight1.png", UriKind.Relative));
            //北方
            si.northLeft.Source  = redlight;
            si.northOther.Source = redlight;
            si.northRight.Source = redlight;
            si.northStraight.Source = redlight;
            si.northPedestrain1.Source = redlight1;
            si.northPedestrain2.Source = redlight1;
            si.northTurn.Source = redlight;
            si.westNorthOther.Source = redlight;
            //东方
            si.eastLeft.Source = redlight1;
            si.eastOther.Source = redlight1;
            si.eastRight.Source = redlight1;
            si.eastStraight.Source = redlight1;
            si.eastPedestrain1.Source = redlight;
            si.eastPedestrain2.Source = redlight;
            si.eastTurn.Source = redlight1;
            si.eastNorthOther.Source = redlight1;
            //南方
            si.southLeft.Source = redlight;
            si.southOther.Source = redlight;
            si.southRight.Source = redlight;
            si.southStraight.Source = redlight;
            si.southPedestrain1.Source = redlight1;
            si.southPedestrain2.Source = redlight1;
            si.southTurn.Source = redlight;
            si.eastSouthOther.Source = redlight;
            //西方
            si.westLeft.Source = redlight1;
            si.westOther.Source = redlight1;
            si.westRight.Source = redlight1;
            si.westStraight.Source = redlight1;
            si.westPedestrain1.Source = redlight;
            si.westPedestrain2.Source = redlight;
            si.westTurn.Source = redlight1;
            si.westSouthOther.Source = redlight1;
        }
        /// <summary>
        /// 双击，创建新的stage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScrollViewer_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (lsi[0] != stage1)
            {
                lsi.Reverse();
            }
            foreach(StageItem si in lsi)
            {
                if (si.Visibility == Visibility.Hidden)
                {
                    si.Visibility = Visibility.Visible;
                    createStageByInitArllowRed(si);
                    break;
                }
            }
        }

        #region 阶段配时-切换方案号
        private void sldSchemeId_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            initStageAttriableByPatternId();
        }
        private void initStageAttriableByPatternId()
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                List<Pattern> lp = t.ListPattern;
                if (lp.Count == 0)
                {
                    MessageBox.Show("方案表加载数量为0!");
                    return;
                }
                foreach (Pattern p in lp)
                {
                    if (p.ucPatternId ==((byte) sldSchemeId.Value))
                    {
                        tbxCycle.Text = p.ucCycleTime.ToString();
                        cbxCoordination.SelectedItem = p.ucCoorPhase;
                        tbxOffset.Text = p.ucOffset.ToString();
                        sldStagePatternId.Value = p.ucStagePatternId;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("加载方案表异常!");
            }
        }
        #endregion
        #region 阶段配时-切换阶段配时号
        private void sldStagePatternId_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            DisplayStageByStagePatternIdChange();
        }
        private void DisplayStageByStagePatternIdChange()
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                List<StagePattern> lsp = t.ListStagePattern;
                List<PhaseToDirec> lptd = t.ListPhaseToDirec;
                //每次都要把stage清空，再由下面的进行显示 
                hiddenStageAll();
                foreach (StagePattern sp in lsp)
                {
                    if (((byte)sldStagePatternId.Value) == sp.ucStagePatternId)
                    {
                        if (sp.ucStageNo != 0)
                        {
                            //在进行显示之前将所有的相位重置成红灯状态
                            StageItem si = returnStageItemObjectByStageNo(sp.ucStageNo);
                            ResetStageDirec(si);

                            visiableStage(sp); //stage 默认是不显示的。只有存在的情况下才显示出来。ucStageNo为0不存在。
                            //if (sldStagePatternId.Value == sp.ucStagePatternId)
                            //{
                            uint ap = sp.usAllowPhase;
                            for (int i = 0; i < 32; i++)
                            {
                                if (((ap >> i) & 0x01) == 0x01)
                                {
                                    foreach (PhaseToDirec ptd in lptd)
                                    {
                                        if (ptd.ucPhase != 0)
                                        {
                                            if (ptd.ucPhase == (i + 1))
                                            {
                                                //初始化
                                                InitStageDirec(ptd, sp);
                                                //Define.NORTH_LEFT
                                            }
                                        }
                                        else
                                        {
                                            initDirecArrow(ptd, sp);
                                        }

                                    }
                                }
                            }
                            //sldGreenTime.Value = sp.ucGreenTime;
                            //sldYellowTime.Value = sp.ucYellowTime;
                            //sldRedTime.Value = sp.ucRedTime;
                            //cbxReaction.IsChecked = true;//sp.ucOption;
                            // sp.ucStageNo   各个阶段编号，已经固定生成
                            //}
                        }
                    }

                }
                if (lsp.Count > 0)
                {
                    currentStage = stage1;
                    foreach (StagePattern sp in lsp)
                    {
                        if (sp.ucStagePatternId == Convert.ToByte(sldStagePatternId.Value) &&
                            sp.ucStageNo == Convert.ToByte(currentStage.lblNumber.Content.ToString()))
                        {
                            sldGreenTime.Value = sp.ucGreenTime;
                            sldYellowTime.Value = sp.ucYellowTime;
                            sldRedTime.Value = sp.ucRedTime;
                        }
                    }
                    BigMap4SmallMap(currentStage);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取阶段配时信息异常!");
            }
        }
        #endregion




        private void SaveStagePattern(object state)
        {
            if (t == null)
                return;
            
            Message msgPattern = TscDataUtils.SetPattern(t.ListPattern);
            if (!msgPattern.flag)
            {
                MessageBox.Show( msgPattern.obj + "\n" + msgPattern.msg);
            }
            Message msgStagePattern = TscDataUtils.SetStagePattern(t.ListStagePattern);
            if (!msgStagePattern.flag)
            {
                MessageBox.Show(msgStagePattern.obj + "\n" + msgStagePattern.msg);
            }
        }
        private void sldValueChanged()
        {

            try
            {
                //  Thread.Sleep(500);
                Slider sld = sldGreenTime;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (StagePattern sp in lsp)
                {
                    if (currentStage != null)
                    {
                        if (sp.ucStagePatternId == Convert.ToByte(sldStagePatternId.Value) && Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            sp.ucGreenTime = Convert.ToByte(sld.Value);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                //  Thread.Sleep(500);
                Slider sld = sldYellowTime;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (StagePattern sp in lsp)
                {
                    if (currentStage != null)
                    {
                        if (sp.ucStagePatternId == Convert.ToByte(sldStagePatternId.Value) && Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            sp.ucYellowTime = Convert.ToByte(sld.Value);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            try
            {
                ///   Thread.Sleep(500);
                Slider sld = sldRedTime;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (StagePattern sp in lsp)
                {
                    if (currentStage != null)
                    {
                        if (sp.ucStagePatternId == Convert.ToByte(sldStagePatternId.Value) && Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            sp.ucRedTime = Convert.ToByte(sld.Value);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           


        }
        private void sldGreenTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                //  Thread.Sleep(500);
                Slider sld = sldGreenTime;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (StagePattern sp in lsp)
                {
                    if (currentStage != null && sldStagePatternId != null && sld!=null)
                    {
                        if (sp.ucStagePatternId == Convert.ToByte(sldStagePatternId.Value) && Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            sp.ucGreenTime = Convert.ToByte(sld.Value);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                  MessageBox.Show(ex.ToString());
            }
            
        }

        private void sldYellowTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            try
            {
                //  Thread.Sleep(500);
                Slider sld = sldYellowTime;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (StagePattern sp in lsp)
                {
                    if (currentStage != null && sldStagePatternId != null && sld != null)
                    {
                        if (sp.ucStagePatternId == Convert.ToByte(sldStagePatternId.Value) && Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            sp.ucYellowTime = Convert.ToByte(sld.Value);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sldRedTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            try
            {
                ///   Thread.Sleep(500);
                Slider sld = sldRedTime;
                t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (t == null)
                    return;
                List<StagePattern> lsp = t.ListStagePattern;
                foreach (StagePattern sp in lsp)
                {
                    if (currentStage != null && sldStagePatternId != null && sld != null)
                    {
                        if (sp.ucStagePatternId == Convert.ToByte(sldStagePatternId.Value) && Convert.ToByte(currentStage.lblNumber.Content) == sp.ucStageNo)
                        {
                            sp.ucRedTime = Convert.ToByte(sld.Value);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }



    }
}
