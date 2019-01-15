using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Apex.MVVM;
using Apex;
using tscui.Models;
using tscui.Service;

namespace tscui.Views
{
    /// <summary>
    /// Interaction logic for ExamplePopup.xaml
    /// </summary>
    public partial class Validate : UserControl
    {
        public Validate()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, RoutedEventArgs e)
        {
            TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if (td != null && td.bValidate == false)
            {
                if (TbxValidPasswd.Password.Equals("root"))
                {
                    td.bValidate = true;

                }
                else
                {

                    string PasswdStringGet =TscDataUtils.GetSysSetPasswd();
                    if (TbxValidPasswd.Password.Equals(PasswdStringGet))
                     {
                         td.bValidate = true;

                     }
                }
                if (td.bValidate == false)
                {
                    LblValidateResult.Visibility = Visibility.Visible;
                    return;
                }
            }
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void Btn_CancelClick(object sender, RoutedEventArgs e)
        {
            ApexBroker.GetShell().ClosePopup(this, true);

        }

        private void LblValidateResult_GotFocus(object sender, RoutedEventArgs e)
        {
           // LblValidateResult.Visibility = ;
            return;
        }



    }
}
