using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;
using tscui.Pages;

namespace tscui.ViewModels
{
    /// <summary>
    /// The PicturesViewModel ViewModel class.
    /// </summary>
    public class DetectorAdvancedViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PicturesViewModel"/> class.
        /// </summary>
        public DetectorAdvancedViewModel()
        {
            Title = (string)App.Current.Resources.MergedDictionaries[3]["tsc_menu_adv_detector"]; 
        }
    }
}
