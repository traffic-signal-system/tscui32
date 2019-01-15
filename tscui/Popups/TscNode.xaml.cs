using System.Windows;
using System.Windows.Controls;
using Apex;
using tscui.Models;
using System.Data.SQLite;
using System;

namespace tscui.Views
{
    /// <summary>
    /// Interaction logic for ExamplePopup.xaml
    /// </summary>
    public partial class TscNode : UserControl
    {
        int OperType;
        int id;
        string ip;
        string descrip;
        public TscNode(int OperType,int id = 0x0 ,string ip="", string descrip="")
        {
            this.OperType = OperType;
            this.id = id;
            this.ip = ip;
            this.descrip = descrip;
            InitializeComponent();
            if (OperType == 0x1)
            {
                TitleTbx.Text = "添加信号机信息";
               
            }
            else if (OperType == 0x2)
            {
                TitleTbx.Text = "修改信号机信息";
                TbxIp.Text = ip;
                TbxDescrip.Text = descrip;

            }
            else if (OperType == 0x3)
            {
                TitleTbx.Text = "删除信号机信息";
                string sql = "delete from Tbl_TscNode where ucTscIp = ";
                Utils.SQLiteHelper.ExecuteNonQuery(sql, null);
            }
        }

        private void button_OK_Click(object sender, RoutedEventArgs e)
        {
            TscData td = Utils.Utils.GetTscDataByApplicationCurrentProperties();
            if(OperType == 0x1)
            {
                if (!Utils.Utils.bIp(TbxIp.Text.Trim()) && TbxIp.Text != String.Empty)
                {
                    MessageBox.Show("请输入正确IP地址！", "指定IP", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                string sql = "insert into Tbl_TscNode values((select max(ucId) from Tbl_TscNode)+1 ,@IP,@DECRIP,'TscV32')";

                SQLiteParameter[] parameters = new SQLiteParameter[]
                {
                     new SQLiteParameter("@IP",TbxIp.Text.Trim()),
                     new SQLiteParameter("@DECRIP",TbxDescrip.Text.Trim())
                };

                Utils.SQLiteHelper.ExecuteNonQuery(sql, parameters);
            }
            else if (OperType == 0x2)
            {
                if (!Utils.Utils.bIp(TbxIp.Text.Trim()) && TbxIp.Text != String.Empty)
                {
                    MessageBox.Show("请输入正确IP地址！", "指定IP", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                string sql = "update Tbl_TscNode set ucTscIp =@IP,ucTscDescrp=@DECRIP where ucId = @ID";

                SQLiteParameter[] parameters = new SQLiteParameter[]
                {
                     new SQLiteParameter("@IP",TbxIp.Text.Trim()),
                     new SQLiteParameter("@DECRIP",TbxDescrip.Text.Trim()),
                     new SQLiteParameter("@ID",id)
                };
               int affectrows = Utils.SQLiteHelper.ExecuteNonQuery(sql, parameters);
            }
            else if (OperType == 0x3)
            {
                string sql = "delete from Tbl_TscNode where ucId = " ;
                Utils.SQLiteHelper.ExecuteNonQuery(sql, null);
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
