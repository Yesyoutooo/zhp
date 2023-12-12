using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;


namespace zhp
{
    public partial class UserControl3 : UserControl
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel.Worksheet xlWorksheet;
        public UserControl3()
        {
            InitializeComponent();
            Create_Excel();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void Create_Excel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWorkbook = xlApp.Workbooks.Add(Missing.Value);
                xlWorksheet = xlWorkbook.ActiveSheet;
                Create_Table();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, err.Source);
                xlWorkbook.Close();
                xlApp.Quit();
                xlWorkbook = null;
                xlApp = null;
            }
        }
        private void Create_Table()
        {
            string[] fejlecek = new string[]
            {
                "OperaCíme",
                "Zeneszerző"
            };

        }
    }
}
