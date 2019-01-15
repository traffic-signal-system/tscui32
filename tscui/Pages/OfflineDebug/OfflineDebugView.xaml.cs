using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Apex.MVVM;
using System.Windows;
using tscui.Models;
using DataFormats = System.Windows.DataFormats;
using DragDropEffects = System.Windows.DragDropEffects;
using DragEventArgs = System.Windows.DragEventArgs;
using MessageBox = System.Windows.MessageBox;
using UserControl = System.Windows.Controls.UserControl;

namespace tscui.Pages.OfflineDebug
{
    /// <summary>
    /// Interaction logic for ThePagesView.xaml
    /// </summary>
    [View(typeof(OfflineDebugViewModel))]
    public partial class OfflineDebugView : UserControl, IView
    {
        TscData td;
        private Process p;
        public OfflineDebugView()
        {
            InitializeComponent();
        }
        public void OnActivated()
        {
           
        }
        public void OnDeactivated()
        {
        }

        private void Grid_Drop(object sender, DragEventArgs e)
        {
            try
            {
                string filename = ((System.Array) e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                string destfilename = System.Environment.CurrentDirectory + "\\GbAitonTsc.db";
                datafilename.Content = "加载离线数据文件->" + filename;
                if (datafilename.Content.ToString().IndexOf(".db") > -1)
                {
                    File.Copy(@filename, @destfilename, true);
                    MessageBox.Show("数据文件加载成功!","离线调试",MessageBoxButton.OK,MessageBoxImage.Information);
                  
                    //Startdebugbtn.IsEnabled = true;
                    //Savedatabtn.IsEnabled = true;
                    //CloseDebugbtn.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("请选择正确的数据文件!", "离线调试", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据文件加载异常!", "离线调试", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void datafilename_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop) == true)
                e.Effects = DragDropEffects.Link;                         
            else 
                e.Effects = DragDropEffects.None;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(System.Environment.CurrentDirectory);
                string tscpath = info.Parent.FullName + "\\tscwin32\\wintscv32_xp.exe";
               // Process.Start(tscpath);
                if (p == null || p.HasExited)
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo(tscpath);
                    psInfo.WindowStyle = ProcessWindowStyle.Hidden; //隐藏窗口
                    p = Process.Start(psInfo);
                    if (p != null)
                    {
                        MessageBox.Show("离线调试开启成功!", "离线调试", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("启动离线异常，可在开始菜单手动启动!", "离线调试", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = "GbAitonTsc.db"; // Default file name
                dlg.DefaultExt = ".db"; // Default file extension
                dlg.Filter = "数据文件|*.db|其他类型文件|*.*"; // Filter files by extension
                dlg.InitialDirectory = "C:\\";
                DialogResult result = dlg.ShowDialog();
                string tscdatapath = System.Environment.CurrentDirectory + "\\GbAitonTsc.db";
                if (result == DialogResult.OK)
                {
                    string filepath = dlg.FileName;
                    if (File.Exists(tscdatapath))
                    {
                        File.Copy(@tscdatapath, @filepath, true);
                        MessageBox.Show("数据文件已保存到:" + filepath, "离线调试", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("数据文件未发现:", "离线调试", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据文件保存异常", "离线调试", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TscData t = Utils.Utils.GetTscDataByApplicationCurrentProperties();
                if (p != null && !p.HasExited)
                {
                    p.Kill();
                    MessageBox.Show("关闭离线调试成功", "离线调试", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                  foreach (Process p1 in Process.GetProcesses())
                 {
                    if (p1.ProcessName.IndexOf("wintscv32") > -1)  //
                   {
                        if (!p1.CloseMainWindow())
                        {
                            p1.Kill();
                            MessageBox.Show("关闭离线调试成功", "离线调试", MessageBoxButton.OK, MessageBoxImage.Information);
                            return;
                        }
                        else
                        {

                            MessageBox.Show("关闭离线调试成功", "离线调试", MessageBoxButton.OK, MessageBoxImage.Information);

                            return;
                        }
                   }
                  }
                    MessageBox.Show("没有启动离线调试", "离线调试", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("关闭离线调试异常", "离线调试", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "信号机数据文件|*.db";
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string destfilename = System.Environment.CurrentDirectory + "\\GbAitonTsc.db";
                    datafilename.Content = "加载离线数据文件->" + openFileDialog1.FileName;
                    if (datafilename.Content.ToString().IndexOf(".db") > -1)
                    {
                        File.Copy(@openFileDialog1.FileName, @destfilename, true);
                        MessageBox.Show("数据文件加载成功!", "离线调试", MessageBoxButton.OK, MessageBoxImage.Information);

                     
                    }
                    else
                    {
                        MessageBox.Show("请选择正确的数据文件!", "离线调试", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据文件加载异常!", "离线调试", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

   
        
    }
}
