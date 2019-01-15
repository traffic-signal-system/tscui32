using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Apex.Controls;
using Apex.MVVM;
using tscui.Pages;

namespace tscui.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    [View(typeof(MainViewModel))]
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
       
        }

        private void Click_ENChose(object sender, System.Windows.RoutedEventArgs e)
        {
            ResourceDictionary langRd = null;
            try
            {
                langRd = Application.LoadComponent(new Uri(@"Resources/Lang/DefaultLanguage.xaml", UriKind.Relative)) as ResourceDictionary;
            }
            catch
            {
                ;
            }
            if (langRd != null)
            {
                if (this.Resources.MergedDictionaries.Count > 3)
                {
                    this.Resources.MergedDictionaries.RemoveAt(3);
                }
                this.Resources.MergedDictionaries.Add(langRd);
            }
        }

        private void Click_CNChose(object sender, RoutedEventArgs e)
        {
            ResourceDictionary langRd = null;
            try
            {
                langRd = Application.LoadComponent(new Uri(@"Resources/Lang/zh-CN.xaml", UriKind.Relative)) as ResourceDictionary;
            }
            catch
            {
                ;
            }
            if (langRd != null)
            {
                if (this.Resources.MergedDictionaries.Count > 3)
                {
                    this.Resources.MergedDictionaries.RemoveAt(3);
                }
                this.Resources.MergedDictionaries.Add(langRd);
            }
          //  viewBroker.ViewModel = null;

        }
    }
}
