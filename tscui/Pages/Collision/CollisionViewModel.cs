using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex.MVVM;

namespace tscui.Pages.Collision
{
    /// <summary>
    /// The CollisionViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class CollisionViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollisionViewModel"/> class.
        /// </summary>
        public CollisionViewModel()
        {
            //  TODO: Use the following snippets to help build viewmodels:
            //      apexnp - Creates a Notifying Property
            //      apexc - Creates a Command.
            Title = (string)App.Current.Resources.MergedDictionaries[3]["tsc_menu_basetime_collision"];
        }



    }
}
