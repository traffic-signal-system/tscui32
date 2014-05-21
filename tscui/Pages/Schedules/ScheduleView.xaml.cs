using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using tscui.Service;
using tscui.Models;
using System.Collections;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace tscui.Pages.Schedules
{
    public enum OrderStatus { None, New, Processing, Shipped, Received };
        
    /// <summary>
    /// Interaction logic for CountDownView.xaml
    /// </summary>
    [View(typeof(ScheduleViewModel))]
    public partial class ScheduleView : UserControl,IView
    {
       


        public ScheduleView()
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
        /// <summary>
        /// 得到eventid不为0 的第一条数据 的ScheduleId数据
        /// 并赋予sldScheduleID
        /// </summary>
        /// <param name="ls"></param>
        private void initSldScheduleId(List<Schedule> ls)
        {
            foreach (Schedule s in ls)
            {
                if (s.ucEventId != 0)
                {
                    sldScheduleId.Value = s.ucId;
                    break;

                }
            }
        }
        /// <summary>
        /// 返回EventId不为0 的数据。
        /// 主要是EventId为0的数据不是合法的数据
        /// </summary>
        /// <param name="ls"></param>
        /// <returns></returns>
        private List<Schedule> initSchedule2DataGrid(List<Schedule> ls)
        {
            List<Schedule> newLs = new List<Schedule>();
            foreach (Schedule s in ls)
            {
                if(s.ucId == sldScheduleId.Value)
                {
                    newLs.Add(s);
                }
            }
            return newLs;
        }
        TscData t ;
        private delegate void DelegateInitSchedule();
        private void DispatcherInitSchedule(object state)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new DelegateInitSchedule(InitSchedule));
        }
        private void InitSchedule()
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            if (t == null)
            {
                return;
            }
            List<Schedule> ls = t.ListSchedule;
            //scheduleDataGrid.ItemsSource = ls;
            initSldScheduleId(ls);      //
            // t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            string selfcontrol = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_self_control"];
            string off = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_off"];
            string flashing = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_flashing"];
            string allred = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_allred"];
            string reaction = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_reaction"];
            string one = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_self_one"];
            string maincoordination = (string)App.Current.Resources.MergedDictionaries[3]["dic_maincoordination"];
            string system = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_system"];
            string manual = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_manual"];
            List<ScheduleCtrl> lsc = new List<ScheduleCtrl>();
            lsc.Add(new ScheduleCtrl() { name = selfcontrol, value = (byte)0 });
            lsc.Add(new ScheduleCtrl() { name = off, value = (byte)1 });
            lsc.Add(new ScheduleCtrl() { name = flashing, value = 2 });
            lsc.Add(new ScheduleCtrl() { name = allred, value = 3 });
            lsc.Add(new ScheduleCtrl() { name = reaction, value = 6 });
            lsc.Add(new ScheduleCtrl() { name = one, value = 8 });
            lsc.Add(new ScheduleCtrl() { name = maincoordination, value = 11 });
            lsc.Add(new ScheduleCtrl() { name = system, value = 12 });
            lsc.Add(new ScheduleCtrl() { name = manual, value = 13 });
            cbxucCtrl.ItemsSource = lsc;

            List<Pattern> lp = t.ListPattern;
            ucTimePatternId.ItemsSource = lp;
            string hd = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_hd_control"];
            string nofun = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_no_fun"];
            string nospecial = (string)App.Current.Resources.MergedDictionaries[3]["dic_schedule_no_special"];
            List<ScheduleAuxOut> lsao = new List<ScheduleAuxOut>();
            lsao.Add(new ScheduleAuxOut() { name = hd, value = 8 });
            lsao.Add(new ScheduleAuxOut() { name = nofun, value = 0 });

            List<ScheduleSpecialOut> lsso = new List<ScheduleSpecialOut>();
            lsso.Add(new ScheduleSpecialOut() { name = nospecial, value = 0 });
            
        }
        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            if(t == null)
            {
                return;
            }
            ThreadPool.QueueUserWorkItem(DispatcherInitSchedule);
        }

        private void tbkScheduleId_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            List<Schedule> ls = t.ListSchedule;
            
        }

        private void sldScheduleId_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
                return;
            scheduleDataGrid.ItemsSource = initSchedule2DataGrid(t.ListSchedule);
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (t == null)
                return;
            TscDataUtils.SetSchedule(t.ListSchedule);
        }

        private void UserControl_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            { 
            ThreadPool.QueueUserWorkItem(SaveSchedule);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Schedule: " + ex.ToString());
            }
        }

        private void SaveSchedule(object state)
        {
            if (t == null)
                return;
            TscDataUtils.SetSchedule(t.ListSchedule);
        }
    }
    public class ScheduleCtrl
    {
        public string name { get; set; }
        public byte value { get; set; }
    }
    public class ScheduleAuxOut
    {
        public string name { get; set; }
        public byte value { get; set; }
    }
    public class ScheduleSpecialOut
    {
        public string name { get; set; }
        public byte value { get; set; }
    }
    public class TimePatternId
    {
        public string name { get; set; }
        public byte value { get; set; }
    }
}
