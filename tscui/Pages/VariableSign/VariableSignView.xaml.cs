﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Apex.MVVM;
using Apex.Behaviours;
using tscui.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace tscui.Pages.VariableSign
{
    /// <summary>
    /// Interaction logic for VariableSignView.xaml
    /// </summary>
    [View(typeof(VariableSignViewModel))]
    public partial class VariableSignView : UserControl,IView
    {
        public VariableSignView()
        {
            InitializeComponent();
        }
         public void OnActivated()
        {
            //throw new NotImplementedException();
            SlideFadeInBehaviour.DoSlideFadeIn(this);
        }

        public void OnDeactivated()
        {
            //throw new NotImplementedException();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (t == null)
            {
                MessageBox.Show((string)App.Current.Resources.MergedDictionaries[3]["msg_vs_selected_tsc"], "信号机", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ObservableCollection<CntDownDev> occdd =  new ObservableCollection<CntDownDev>(t.ListCntDownDev);
            dgdVariableSign.ItemsSource = occdd;
        }
    }
}
