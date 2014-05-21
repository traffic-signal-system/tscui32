using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.BaseTime
{
    /// <summary>
    /// The SeasonTimeViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class SeasonTimeViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeasonTimeViewModel"/> class.
        /// </summary>
        public SeasonTimeViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = (string)App.Current.Resources.MergedDictionaries[3]["tsc_menu_basetime_week"]; 
            //  Create the example command
        }

    }
}
