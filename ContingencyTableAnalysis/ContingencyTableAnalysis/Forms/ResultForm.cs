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
            foreach (var item in results)
            {
                ListViewItem lvitem = new ListViewItem(item.Key);
                
                lvitem.SubItems.Add(String.Join(",  ", item.Value));
                ResultList.Items.Add(lvitem); //item.Value.ToString()
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

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Результаты анализа.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(1);
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets[1];

                // todo 1 доделать сохранение в ексель
                for (int row = 1; row <= ResultList.Items.Count; row++) // начиная с 1, так как индексация у екселя начинается с 1 
                {
                    var resultList = ResultList.Items[row - 1].SubItems;//[1].ToString().Split(',');

                    for (int column = 1; column <= resultList.Count; column++)
                    {
                        xlWorkSheet.Cells[row, column] = resultList[column-1];
                    }
                }

                /////////////////
                


                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();

                // Open the newly saved excel file
                if (System.IO.File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
    }
}
