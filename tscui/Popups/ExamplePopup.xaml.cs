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
using Xceed.Wpf.Toolkit;
using tscui.Models;
using tscui.Service;
using System.Windows.Threading;
using System.Threading;

namespace tscui.Views
{
    public delegate void RadioSelectedHandler();
    /// <summary>
    /// Interaction logic for ExamplePopup.xaml
    /// </summary>
    public partial class ExamplePopup : UserControl
    {
      //  public event RadioSelectedHandler RadioSelectedEvent;

        public ExamplePopup()
        {
            InitializeComponent();
        }

        private void phase1_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 1)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }
            
            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase2_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 2)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }
            
            ApexBroker.GetShell().ClosePopup(this, true);
        
        }

        private void phase3_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 3)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase4_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 4)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase5_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 5)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase6_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 6)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase7_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 7)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase8_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 8)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase9_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 9)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase10_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 10)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase11_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 11)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase12_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 12)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase13_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 13)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase14_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 14)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase15_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 15)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase16_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 16)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase17_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 17)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase18_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 18)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase19_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 19)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase20_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 20)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase21_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 21)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase22_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 22)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase23_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 23)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase24_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 24)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase25_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 25)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase26_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 26)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase27_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 27)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase28_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 28)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase29_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 29)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase30_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 30)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase31_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 31)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void phase32_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_PHASE);
            foreach (Phase p in t.ListPhase)
            {
                if (p.ucId == 32)
                {
                    Utils.Utils.SetPhaseByCurrent(p);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase1_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 1)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase2_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 2)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase3_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 3)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase4_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 4)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase5_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 5)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase6_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 6)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase7_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 7)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase8_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 8)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase9_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 9)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase10_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 10)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase11_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 11)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase12_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 12)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase13_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 13)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase14_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 14)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase15_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 15)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }

        private void overlapPhase16_Click(object sender, RoutedEventArgs e)
        {
            TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            Utils.Utils.SetPhaseOverlapPhaseType(Define.SELECTED_PHASE_OVERLAP_TYPE_OVERLAPPHASE);
            foreach (OverlapPhase op in t.ListOverlapPhase)
            {
                if (op.ucId == 16)
                {
                    Utils.Utils.SetOverLapPhaseByCurrent(op);
                    break;

                }
            }

            ApexBroker.GetShell().ClosePopup(this, true);
        }
       
  
    }
    public class OverlapPhaseType
    {
        public string name { set; get; }
        public byte value { set; get; }
    }
    public class PhaseType
    {
        public string typeName { set; get; }
        public byte ucType { set; get; }
    }
    public class PhaseOption
    {
        public string optionName { set; get; }
        public byte ucOption { set; get; }
    }
}
