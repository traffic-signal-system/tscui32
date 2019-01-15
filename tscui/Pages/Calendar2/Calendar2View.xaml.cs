using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Models;
using System.Windows;
using tscui.Service;
using System.Threading;

namespace tscui.Pages.Calendar2
{
    /// <summary>
    /// Interaction logic for CalendarView.xaml
    /// </summary>
    [View(typeof(Calendar2ViewModel))]
    public partial class Calendar2View : UserControl,IView
    {
        TscData td =  Utils.Utils.GetTscDataByApplicationCurrentProperties();
        public Calendar2View()
        {
            InitializeComponent();
            this.Monthgroup.AddHandler(CheckBox.CheckedEvent, new RoutedEventHandler(MonthGroup_Checked));
            this.Monthgroup.AddHandler(CheckBox.UncheckedEvent, new RoutedEventHandler(MonthGroup_UnChecked));
            this.DayGroup.AddHandler(CheckBox.CheckedEvent, new RoutedEventHandler(DayGroup_Checked));
            this.DayGroup.AddHandler(CheckBox.UncheckedEvent, new RoutedEventHandler(DayGroup_UnChecked));
        }

        private void DayGroup_UnChecked(object sender, RoutedEventArgs e)
        {
            if (td == null)
                return;
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {
                    if (e.OriginalSource != null)
                    {
                        CheckBox dayCheckBox = e.OriginalSource as CheckBox;
                        if (dayCheckBox != null)
                        {
                            for (Byte dayindex = 1; dayindex <= 12; dayindex++)
                            {
                                if (dayCheckBox.Name == "day" + dayindex)
                                {
                                    p.ulDayFlag &= (uint)(~(1 << dayindex));
                                    e.Handled = true;
                                    return;
                                }
                            }


                        }
                    }

                }
            } 
        }

        private void DayGroup_Checked(object sender, RoutedEventArgs e)
        {
            if (td == null)
                return;
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {
                    if (e.OriginalSource != null)
                    {
                        CheckBox dayCheckBox = e.OriginalSource as CheckBox;
                        if (dayCheckBox != null)
                        {
                            for (Byte daytheindex = 1; daytheindex <= 31; daytheindex++)
                            {
                                if (dayCheckBox.Name == "day" + daytheindex)
                                {
                                    p.ulDayFlag |= (uint)(1 << daytheindex);
                                    e.Handled = true;
                                    return;
                                }
                            }


                        }
                    }

                }
            }
        }

        private void MonthGroup_UnChecked(object sender, RoutedEventArgs e)
        {
            if (td == null)
                return;
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {
                    if (e.OriginalSource != null)
                    {
                        CheckBox monthCheckBox = e.OriginalSource as CheckBox;
                        if (monthCheckBox != null)
                        {
                            for (Byte montheindex = 1; montheindex <= 12; montheindex++)
                            {
                                if (monthCheckBox.Name == "Mon" + montheindex)
                                {
                                    p.usMonthFlag &= (ushort)(~(1 << montheindex));
                                    e.Handled = true;
                                    return;
                                }
                            }


                        }
                    }

                }
            }
        }

        private void MonthGroup_Checked(object sender, RoutedEventArgs e)
        {
            if (td == null)
                return;
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {
                    if (e.OriginalSource != null)
                    {
                        CheckBox monthCheckBox = e.OriginalSource as CheckBox;
                        if (monthCheckBox != null)
                        {
                            for (Byte montheindex = 1; montheindex <= 12; montheindex++)
                            {
                                if (monthCheckBox.Name == "Mon" + montheindex)
                                {
                                    p.usMonthFlag |= (ushort) (1 << montheindex);
                                    e.Handled = true;
                                    return;
                                }
                            }
                           
              
                        }
                    }

                }
            }
        }

        public void OnActivated()
        {
           // throw new NotImplementedException();
           SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
           // throw new NotImplementedException();
        }
       
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (td == null)
                {   
                    Visibility = Visibility.Hidden;
                    MessageBox.Show("当前未选定信号机IP!!!","时基",MessageBoxButton.OK,MessageBoxImage.Error);
                    return;
                }
                else
                {
                    Visibility = Visibility.Visible;
                }
                List<Plan> lp = td.ListPlan;
                if (lp == null)
                    return;
                foreach (Plan p in lp)
                {
                    if (p.ucId >= 1 && p.ucId <= 20)
                    {
                        lbxPlanId.Items.Add(p.ucId);

                        if (lbxPlanId.SelectedIndex != 0x0)
                            lbxPlanId.SelectedIndex = 0x0;
                    }
                }

                List<Schedule> ls = td.ListSchedule;
                if (ls == null)
                    return;
                List<byte> li = new List<byte>();
                foreach (Schedule s in ls)
                {
                    if (!li.Contains(s.ucId) && s.ucId != 0 && s.ucEventId !=0)
                        li.Add(s.ucId);
                }
                cbxScheduleId.ItemsSource = li;
               
            }
            catch(Exception ex )
            {
                return;
            }
            
        }
 
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Utils.Utils.bValidate() == false)
                    return;
                for (Byte planindex = 0; planindex < td.ListPlan.Count; planindex++)
                {
                    if (td.ListPlan[planindex].ucId >= 1 && td.ListPlan[planindex].ucId <= 20)
                    {
                        if (td.ListPlan[planindex].ulDayFlag == 0x0 || td.ListPlan[planindex].usMonthFlag == 0x0)
                        {
                            for (Byte lbxplanidx = 0; lbxplanidx < lbxPlanId.Items.Count; lbxplanidx++)
                            {
                                if (td.ListPlan[planindex].ucId == Convert.ToByte(lbxPlanId.Items[lbxplanidx]))
                                {
                                    lbxPlanId.Items.RemoveAt(lbxplanidx);
                                    break;
                                }
                            }
                            td.ListPlan.RemoveAt(planindex);
                            --planindex;
                        }
                     
                    }
                }
                Message m = TscDataUtils.SetPlanByCalendar(td.ListPlan);
                if (m.flag)
                {
                    MessageBox.Show(m.msg);
                }
                else
                {
                    MessageBox.Show(m.msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("时基保存异常!", "时基", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

        }

        private void Monall_Checked(object sender, RoutedEventArgs e)
        {
            for (byte index = 1; index < 13; index++)
            {
                string checkboxname = "Mon" + index;
                object checkobj = this.FindName(checkboxname);
                CheckBox checkedbox = checkobj as CheckBox;
                if (checkedbox != null)
                {
                    checkedbox.IsChecked = true;
                
                }
            }
        }

        private void Monall_Unchecked(object sender, RoutedEventArgs e)
        {
            for (byte index = 1; index < 13; index++)
            {
                string checkboxname = "Mon" + index;
                object checkobj = this.FindName(checkboxname);
                CheckBox checkedbox = checkobj as CheckBox;
                if (checkedbox != null)
                {
                     checkedbox.IsChecked = false;
                 
                }
            }
        }

        private void dayall_Unchecked(object sender, RoutedEventArgs e)
        {
            for (byte index = 1; index < 32; index++)
            {
                string checkboxname = "day" + index;
                CheckBox checkedbox = (CheckBox)(this.FindName(checkboxname));
                if (checkedbox != null)
                {
                     checkedbox.IsChecked = false;
                 
                }
            }
        }

        private void dayall_Checked(object sender, RoutedEventArgs e)
        {
            for (byte index = 1; index < 32; index++)
            {
                string checkboxname = "day" + index;
                CheckBox checkedbox = (CheckBox)(this.FindName(checkboxname));
                if (checkedbox != null)
                {
                   checkedbox.IsChecked = true;
                 
                }
            }
        }

        private void lbxPlanId_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                if (td.ListPlan == null) //获取时基为空或者失败
                {
                    td.ListPlan = new List<Plan>();
                    List<Plan> lp = td.ListPlan; ;

                    Plan pt = new Plan();
                    pt.ucId = 0x1;
                    pt.ucScheduleId = Convert.ToByte(cbxScheduleId.SelectedItem);
                    pt.ucWeekFlag = 254;
                    lbxPlanId.Items.Add(pt.ucId);
                    lp.Add(pt);
                }
                else
                {
                    Plan pt = new Plan();
                    List<Plan> lp = td.ListPlan; ;

                    foreach (Plan p in lp)
                    {
                        for (byte i = 1; i <= 20; i++)
                        {
                            if (!lbxPlanId.Items.Contains(i) && !(p.ucId == i))
                            {

                                pt.ucId = i;
                                pt.ucScheduleId = Convert.ToByte(cbxScheduleId.SelectedItem);
                                pt.ucWeekFlag = 254;
                                break;
                            }
                        }
                        break;
                    }
                    if (pt.ucId >= 1 && pt.ucId <= 20)
                    {
                        lbxPlanId.Items.Add(pt.ucId);
                        lp.Add(pt);
                    }
                }
              
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void lbxPlanId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (td == null)
                return;
            List<Plan> lp = td.ListPlan;
            byte planid  = Convert.ToByte(lbxPlanId.SelectedItem);;
    //        cbxScheduleId.SelectedItem = p.ucScheduleId;
            
            foreach (Plan p in lp)
            {
                if (p.ucId == planid)
                {
                    cbxScheduleId.SelectedItem = p.ucScheduleId;
                 
                    ushort month = p.usMonthFlag;
                    uint day = p.ulDayFlag;
                    
                    for (byte index = 1; index < 13; index++)
                    {
                        string checkboxname = "Mon" + index;
                        object checkobj = this.FindName(checkboxname);
                        CheckBox checkedbox = checkobj as CheckBox;
                        if (checkedbox != null)
                        {
                            //   checkedbox.IsChecked = false;
                            if (((month >> index) & 0x1) == 0x1)
                            {
                                checkedbox.IsChecked = true;
                            }
                            else
                            {
                                checkedbox.IsChecked = false;
                            }
                        }
                    }
                    for (byte index = 1; index < 32; index++)
                    {
                        string checkboxname = "day" + index;
                        CheckBox checkedbox = (CheckBox)(this.FindName(checkboxname));
                        if (checkedbox != null)
                        {
                            // checkedbox.IsChecked = false;
                            if (((day >> index) & 0x1) == 0x1)
                            {
                                checkedbox.IsChecked = true;
                            }
                            else
                            {
                                checkedbox.IsChecked = false;
                            }
                        }
                    }
                  
                    break;
                }


            }
        }


        private void cbxScheduleId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (td == null)
                return;
            List<Plan> lp = td.ListPlan;
            foreach (Plan p in lp)
            {
                if (p.ucId == Convert.ToByte(lbxPlanId.SelectedItem))
                {
                    p.ucScheduleId = Convert.ToByte(cbxScheduleId.SelectedItem);
                    break;
                }
            }
        }

        private void Delete_Plan(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToByte(lbxPlanId.SelectedItem) == 0x0)
                    return;
                if (
                    MessageBox.Show("确定要删除时基:" + Convert.ToByte(lbxPlanId.SelectedItem).ToString() + "?", "删除",
                        MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    for (Byte planindex = 0; planindex < td.ListPlan.Count; planindex++)
                    {
                        if (td.ListPlan[planindex].ucId >= 1 && td.ListPlan[planindex].ucId <= 20)
                        {
                            if (td.ListPlan[planindex].ucId == (Convert.ToByte(lbxPlanId.SelectedItem)))
                            {
                                td.ListPlan.RemoveAt(planindex);
                                break;
                            }
                        }
                    }
                    lbxPlanId.Items.Remove(lbxPlanId.SelectedItem);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除时基异常!", "时基", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        private void daysingle_Checked(object sender, RoutedEventArgs e)
        {
            for (byte index = 1; index < 32; index++)
            {
                string checkboxname = "day" + index;
                CheckBox checkedbox = (CheckBox)(this.FindName(checkboxname));
                if (checkedbox != null)
                {
                    if(index %2 == 0x1)
                    {
                        checkedbox.IsChecked = true;
                    }
                    else
                    {
                        checkedbox.IsChecked = false ;
                    }
                }
            }
        }

        private void daydouble_Checked(object sender, RoutedEventArgs e)
        {
            for (byte index = 1; index < 32; index++)
            {
                string checkboxname = "day" + index;
                CheckBox checkedbox = (CheckBox)(this.FindName(checkboxname));
                if (checkedbox != null)
                {
                    if (index %2 == 0x0)
                    {
                        checkedbox.IsChecked = true;
                    }
                    else
                    {
                        checkedbox.IsChecked = false;
                    }
                }
            }
        }

    }
}
