using System;
using Apex.MVVM;
using System.Windows;

namespace tscui.Pages.OfflineDebug
{
    /// <summary>
    /// The ThePagesViewModel ViewModel class.
    /// </summary>
    public class OfflineDebugViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThePagesViewModel"/> class.
        /// </summary>
        public OfflineDebugViewModel()
        {
            Title = (string)App.Current.Resources.MergedDictionaries[3]["tsc_menu_offline"]; 
            DegradationCommand1 = new Command(DoDegradationCommand);
        }
        public Command DegradationCommand1 { get; private set; }
        private void DoDegradationCommand(object parameter)
        {
            ;

        }
        /// <summary>


        
    }
}
