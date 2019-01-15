using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;

namespace tscui.Db
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    [View(typeof(object))]
    public partial class View1 : UserControl, IView
    {
        public View1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the view is activated.
        /// </summary>
        public void OnActivated()
        {
        }

        /// <summary>
        /// Called when the view is deactivated.
        /// </summary>
        public void OnDeactivated()
        {
        }

        /// <summary>
        /// Gets the ViewModel.
        /// </summary>
        public object ViewModel
        {
            get { return (object)DataContext; }
        }
    }
}
