using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace ContingencyTableAnalysis
{
    public partial class ResultForm : MetroFramework.Forms.MetroForm
    {
        public ResultForm(IDictionary<string, List<double>> results)
        {
            InitializeComponent();
            SaveResultBtn.Image = (Image)(new Bitmap(Properties.Resources.save_icon, new Size(16, 16)));
            FillResultList(results);           
        }
        public void FillResultList(IDictionary<string, List<double>> results)
        {            
            foreach (var result in results)
            {
                ListViewItem listItem = new ListViewItem(result.Key);
                string[] values = new string[result.Value.Count];
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = result.Value[i].ToString();
                }
                listItem.SubItems.Add(String.Join(",  ", values));
                ResultList.Items.Add(listItem); //item.Value.ToString()
            }
        }

        private void ExitResultBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void SaveResultBtn_Click(object sender, EventArgs e)
        {


            Microsoft.Office.Interop.Excel.Application xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets[1];

            xlWorkSheet.StandardWidth = 20;
            xlWorkSheet.Cells[1, 1] = ResultList.Columns[0].Text;
            xlWorkSheet.Cells[1, 2] = ResultList.Columns[1].Text;

            for (int row = 2; row < ResultList.Items.Count+1; row++) // начиная с 2, так как индексация у екселя начинается с 1 +  первая строка - header'ы
            {
                xlWorkSheet.Cells[row, 1] = ResultList.Items[row - 1].SubItems[0].Text; // имя параметра
                xlWorkSheet.Cells[row, 2] = ResultList.Items[row - 1].SubItems[1].Text;

                /* если потребуется разделять значения по клеткам экселя
                var resultList = ResultList.Items[row].SubItems[1].Text.Split(',');

                for (int column = 2; column < resultList.Length+2; column++)
                {
                    xlWorkSheet.Cells[row, column] = resultList[column-2]; // имя параметра

                }
                */
            }

            /////////////////



            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlexcel);

            Clipboard.Clear();


        }
    }
}
