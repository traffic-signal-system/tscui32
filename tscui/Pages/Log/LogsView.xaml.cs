using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Pages.Log;
using System.Collections.Generic;
using tscui.Models;
using System.Windows.Data;
using System.Windows;
using tscui.Service;

namespace tscui.Pages.Log
{
    /// <summary>
    /// Interaction logic for ThePagesView.xaml
    /// </summary>
    [View(typeof(LogsViewModel))]
    public partial class LogsView : UserControl, IView
    {
        //private List<EventLog> listEventLog;
        private ListView myListView;
        private GridView myGridView;
        public LogsView()
        {
            InitializeComponent();
        }

        public void OnActivated()
        {
            //  Fade in all of the elements.
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
        }
        private void refreshLog()
        {
            
            TscData td = (TscData)Application.Current.Properties[Define.TSC_DATA];
            if (td == null)
            {
                MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["msg_log_selected_tsc"]);

            }
            else
            {
                myListView.ItemsSource = TscDataUtils.GetEventLog();
            }
            
        }
        private void splLog_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            //<SnippetListViewView>
            myListView = new ListView();
            //<SnippetGridViewColumn>

            //<SnippetGridViewAllowsColumnReorder>
            myGridView = new GridView();
            myGridView.AllowsColumnReorder = true;
            myGridView.ColumnHeaderToolTip = (string)App.Current.Resources.MergedDictionaries[3]["tsc_log_headertooltip"];
            //</SnippetGridViewAllowsColumnReorder>
           
            //<SnippetGridViewColumnProperties>
            GridViewColumn gvc1 = new GridViewColumn();
            gvc1.DisplayMemberBinding = new Binding("ucEventId");
            gvc1.Header = (string)App.Current.Resources.MergedDictionaries[3]["tsc_log_id"];
            gvc1.Width = 30;
            //</SnippetGridViewColumnProperties>
            myGridView.Columns.Add(gvc1);
            GridViewColumn gvc2 = new GridViewColumn();
            gvc2.DisplayMemberBinding = new Binding("sEventType");
            gvc2.Header = (string)App.Current.Resources.MergedDictionaries[3]["tsc_log_type"]; 
            gvc2.Width = 100;
            myGridView.Columns.Add(gvc2);
            //<SnippetAddToColumns>
            GridViewColumn gvc3 = new GridViewColumn();
            gvc3.DisplayMemberBinding = new Binding("ulEventTime");
            gvc3.Header = (string)App.Current.Resources.MergedDictionaries[3]["tsc_log_time"];
            gvc3.Width = 120;
            myGridView.Columns.Add(gvc3);

            GridViewColumn gvc4 = new GridViewColumn();
            gvc4.DisplayMemberBinding = new Binding("sEventDesc");
            gvc4.Header = (string)App.Current.Resources.MergedDictionaries[3]["tsc_log_value"];
            gvc4.Width = 700;
            myGridView.Columns.Add(gvc4);
            //</SnippetAddToColumns>

            //</SnippetGridViewColumn>
            //ItemsSource is ObservableCollection of EmployeeInfo objects
            //myListView.ItemsSource = new myTscs();
            //Thread thread = new Thread();
            myListView.View = myGridView;
            myListView.Height = 550;
            // myListView.
            splLog.Children.Add(myListView);
            refreshLog();
        }

        private void btnGetLog_Click(object sender, RoutedEventArgs e)
        {
            refreshLog();
        }
    }
}
