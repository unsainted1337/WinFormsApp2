using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;

        public Form1()
        {
            InitializeComponent();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Priority_TextChanged(object sender, EventArgs e)
        {

        }

        private void Requirement_TextChanged(object sender, EventArgs e)
        {

        }

        private void Module_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submodule_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            ObjExcel.SheetsInNewWorkbook = 1;
           //Таблица.
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            ObjWorkSheet.Cells[1, 1] = "ID";
            ObjWorkSheet.Cells[1, 2] = "Приоритет";
            ObjWorkSheet.Cells[1, 3] = "Требование";
            ObjWorkSheet.Cells[1, 4] = "Модуль";
            ObjWorkSheet.Cells[1, 5] = "Подмодуль";
            ObjWorkSheet.Cells[1, 6] = "Заглавие";
            ObjWorkSheet.Cells[1, 7] = "Результат";
            ObjWorkSheet.Cells[2, 1] = ID.Text;
            ObjWorkSheet.Cells[2, 2] = Priority.Text;
            ObjWorkSheet.Cells[2, 3] = Requirement.Text;
            ObjWorkSheet.Cells[2, 4] = Module.Text;
            ObjWorkSheet.Cells[2, 5] = Submodule.Text;
            ObjWorkSheet.Cells[2, 6] = Title.Text;
            ObjWorkSheet.Cells[2, 7] = Result.Text;
            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;

        }

       
    }

    
}
