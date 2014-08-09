using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace tscui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
           // base.OnStartup(e);
            LoadLanguage();
        }

        private void LoadLanguage()
        {
            CultureInfo currentCultureInfo = CultureInfo.CurrentCulture;
            
            //currentCultureInfo = CultureInfo.CreateSpecificCulture("zh_CN");
            ResourceDictionary langRd = null;
           
            try
            {
                langRd =
                    Application.LoadComponent(
                             new Uri(@"Resources/Lang/" + currentCultureInfo.Name + ".xaml", UriKind.Relative))
                    as ResourceDictionary;
            }
            catch
            {
            }
            //this.Resources.MergedDictionaries.Add(langRd);
            if (langRd != null)
            {
                if (this.Resources.MergedDictionaries.Count > 3)
                {
                    this.Resources.MergedDictionaries.RemoveAt(3);
                }
               this.Resources.MergedDictionaries.Add(langRd);
            }


        }
    }
}
