using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContingencyTableAnalysis.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace ContingencyTableAnalysis
{
    public partial class ucDataCreation : UserControl
    {

        public string FileDataSource = null; // адрес загруженного файла в grid
        public bool DataSaved = true; // переменная, отображающая, сохранены ли данные(и нужно ли их перезаписывать)
        const char separatorTxt = '|';

        
        public ucDataCreation()
        {
            InitializeComponent();
        }


        private void dc_addColumn_Click(object sender, EventArgs e)
        {
            GridColumnWithMark column = new GridColumnWithMark() { HeaderText = "Признак " + (DataCreationGrid.ColumnCount + 1),Name = "Признак " + (DataCreationGrid.ColumnCount + 1) };
            DataCreationGrid.Columns.Add(column);
        }

        private void DataCreationGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.ColumnIndex < 0) // необходимо это условие, ибо при нажатии на левую колонку GridView вызывается этот метод, где e.ColumnIndex == -1 -> приводит к ошибке
                    return;
                
                MetroFramework.Controls.MetroGrid metroGrid = (MetroFramework.Controls.MetroGrid)sender;
                System.Drawing.Point mouseLocation = metroGrid.PointToClient(Cursor.Position); // relative position
                ShowContextMenuColumn((GridColumnWithMark)metroGrid.Columns[e.ColumnIndex], mouseLocation);
                
            }
        }
        public void OpenDataFile()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Файлы xls,xlsx,csv,txt|*.xls;*.xlsx;*.csv;*.txt";

            if (file.ShowDialog() == DialogResult.OK)
            {
                DownloadDataFromFile(file.FileName);
            }
        }

        public void ShowData()
        {
            Console.WriteLine("----------------------------------");
            for (int row = 0; row < DataCreationGrid.RowCount; row++)
            {
                for (int column = 0; column < DataCreationGrid.ColumnCount; column++)
                {
                    Console.Write(DataCreationGrid.Rows[row].Cells[column].Value+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------");
        }

        private void copyGridtoClipboard()
        {
            Clipboard.Clear();
            if (DataCreationGrid.GetClipboardContent() != null)
            {
                DataCreationGrid.SelectAll();
                Clipboard.SetDataObject(DataCreationGrid.GetClipboardContent());
                Clipboard.GetData(DataFormats.Text);
                IDataObject dt = Clipboard.GetDataObject();
                if (dt.GetDataPresent(typeof(string)))
                {
                    string tb = (string)(dt.GetData(typeof(string)));
                    Encoding encoding = Encoding.GetEncoding(1251);
                    byte[] dataStr = encoding.GetBytes(tb);
                    Clipboard.SetDataObject(encoding.GetString(dataStr));
                }
            }
        }

        public void SaveDataToExcel(string fileName)
        {
            copyGridtoClipboard();

            object misValue = System.Reflection.Missing.Value;
            Excel.Application xlexcel = new Excel.Application();
            Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.ActiveSheet;
            xlexcel.Visible = false;
            xlexcel.DisplayAlerts = false;
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();

            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            // Delete blank column A and select cell A1
            Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
            delRng.Delete(Type.Missing);
            xlWorkSheet.get_Range("A1").Select();


            xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xlWorkBook.Close(true, misValue, misValue);
            xlexcel.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlexcel);

            Clipboard.Clear();
            DataCreationGrid.ClearSelection();

            /*
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;

                //Write Headers
                for (int col = 0; col < DataCreationGrid.Columns.Count; col++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + col];
                    myRange.Value2 = DataCreationGrid.Columns[col].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (int row = 0; row < DataCreationGrid.Rows.Count; row++)
                {
                    for (int col = 0; col < DataCreationGrid.Columns.Count; col++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + row, StartCol + col];
                            myRange.Value2 = DataCreationGrid[col, row].Value == null ? "" : DataCreationGrid[col, row].Value;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
            */

        }
        public void SaveDataToTxt(string fileName)
        {
            TextWriter writer = new StreamWriter(fileName);

            foreach (GridColumnWithMark column in DataCreationGrid.Columns)
            {
                writer.Write(column.Name + separatorTxt);
            }
            writer.WriteLine("");

            for (int i = 0; i < DataCreationGrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DataCreationGrid.Columns.Count; j++)
                {
                    writer.Write(DataCreationGrid.Rows[i].Cells[j].Value.ToString() + separatorTxt);
                }
                writer.WriteLine("");
            }
            writer.Close();
        }

        public void SaveData(bool asNew)
        {
            if (DataSaved && !asNew)
                return;

            string fileName;

            if (asNew || FileDataSource == null)
            {
                SaveFileDialog showDialog = new SaveFileDialog();
                showDialog.Filter = "Файл xls|*.xls|Файл txt|*.txt";
                showDialog.FileName = "Набор данных";
                if (showDialog.ShowDialog() != DialogResult.OK)
                    return;
                fileName = showDialog.FileName;
            }
            else
            {
                fileName = FileDataSource;
            }

            switch (System.IO.Path.GetExtension(fileName))
            {
                case ".xls":
                    SaveDataToExcel(fileName);
                    break;

                case ".txt":
                    SaveDataToTxt(fileName);
                    break;

                default:
                    break;
            }



            DataSaved = true;
            MessageBox.Show("Данные сохранены");




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

        public void CreateData()
        {
            if (FileDataSource != null)
            {
                ClearGridData();
            }

        }

        public void ClearGridData()
        {
            FileDataSource = null;

            DataCreationGrid.Rows.Clear();
            DataCreationGrid.Columns.Clear();
        }

        public DataTable GetDataFromExcel(string dataSource, string pathExtension)
        {

            string connectionString;

            if(pathExtension == ".xls")
                connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = '" + dataSource + "';Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1;\"";
            else
                connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + dataSource + "';Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1;\"";

            DataTable dataTable;
            
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                var sheetName = dtSchema.Rows[0].Field<string>("TABLE_NAME");
                OleDbDataAdapter MyCommand = new OleDbDataAdapter(String.Format("select * from [{0}]", sheetName),conn);
                MyCommand.TableMappings.Add("Table", "Net");
                dataTable = new DataTable();
                MyCommand.Fill(dataTable);
            }
            
            return dataTable;
        }
        public DataTable GetDataFromTxt(string dataSource, string pathExtension)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(dataSource);
            string[] columnnames = file.ReadLine().Split(separatorTxt);
            DataTable dataTable = new DataTable();
            foreach (string c in columnnames)
            {
                dataTable.Columns.Add(c);
            }
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                DataRow dr = dataTable.NewRow();
                string[] values = newline.Split(separatorTxt);
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dataTable.Rows.Add(dr);
            }
            file.Close();
            return dataTable;
        }

        public void DownloadDataFromFile(string dataSource)
        {
            FileDataSource = dataSource;

            DataTable dataTable = null;
            string pathExtension = System.IO.Path.GetExtension(dataSource);
            switch (pathExtension)
            {
                case ".xls":
                case ".xlsx":
                    dataTable = GetDataFromExcel(dataSource, pathExtension);
                    break;

                case ".csv":
                case ".txt":
                    dataTable = GetDataFromTxt(dataSource, pathExtension);
                    break;

                default:
                    break;
            }

            DataCreationGrid.Rows.Clear();
            DataCreationGrid.Columns.Clear();

            foreach (var item in dataTable.Columns)
            {
                GridColumnWithMark column = new GridColumnWithMark() { HeaderText = item.ToString(), Name = item.ToString() };
                DataCreationGrid.Columns.Add(column);
            }

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataCreationGrid.Rows.Add();

                for (int column = 0; column < dataTable.Columns.Count; column++)
                {
                    DataCreationGrid.Rows[row].Cells[column].Value = dataTable.Rows[row].ItemArray[column].ToString();

                }
            }

            DataSaved = true;
            
        }

        public void ShowContextMenuColumn(GridColumnWithMark column, Point mouseLocation)
        {
            column.ShowContextMenu(DataCreationGrid, mouseLocation);
        }


        private void DataCreationGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            DataSaved = false;
            MetroFramework.Controls.MetroGrid metroGrid = (MetroFramework.Controls.MetroGrid)sender;

            if (e.RowIndex == -1)
                return;
            var value = metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            GridColumnWithMark column = (GridColumnWithMark)metroGrid.Columns[e.ColumnIndex];

            if (value != null && !metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().All(char.IsDigit) && !column.Qualitative)
            {
                MessageBox.Show("Нельзя вводить строковые значения в количественные признаки");
                metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            }

            ((GridColumnWithMark)metroGrid.Columns[e.ColumnIndex]).CellValueChanged(e.RowIndex, metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            

              
        }

    }


}
