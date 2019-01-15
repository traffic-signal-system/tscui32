using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.Calendar2
{
    /// <summary>
    /// The CalendarViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class Calendar2ViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarViewModel"/> class.
        /// </summary>
        public Calendar2ViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
         //   Title = (string)App.Current.Resources.MergedDictionaries[3]["tsc_menu_basetime_calendar"];
            Title = "①按特殊月日";
        }

        /// <summary>
        /// The Contacts observable collection.
        /// </summary>
        private ObservableCollection<Calendar2ViewModel> CalendarProperty =
          new ObservableCollection<Calendar2ViewModel>();

        /// <summary>
        /// Gets the Contacts observable collection.
        /// </summary>
        /// <value>The Contacts observable collection.</value>
        public ObservableCollection<Calendar2ViewModel> Calendars
        {
            get { return CalendarProperty; }
        }

    }
}
