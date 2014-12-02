using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Apex;
using Apex.MVVM;
using tscui.Models;
using tscui.Pages;

namespace tscui.Pages.Music
{
    /// <summary>
    /// The MusicViewModel ViewModel class.
    /// </summary>
    [ViewModel]
    public class MusicViewModel : PageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusicViewModel"/> class.
        /// </summary>
        public MusicViewModel()
        {
            Title = "高级相位";


        }
    }
       
}
