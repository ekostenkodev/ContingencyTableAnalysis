using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContingencyTableAnalysis.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;


namespace ContingencyTableAnalysis
{
    public partial class ucDataCreation : UserControl
    {

        public string FileDataSource = null; // адрес загруженного файла в grid
        public bool DataSaved = true; // переменная, отображающая, сохранены ли данные(и нужно ли их перезаписывать)

        
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
            file.Filter = "Файлы xls,xlsx|*.xls;*.xlsx|Файлы csv,txt|*.csv;*.txt";

            if (file.ShowDialog() == DialogResult.OK)
            {
                DownloadDataFromFile(file.FileName);
            }
        }

        public void SaveDataToExcel(string fileName)
        {
            // todo сохранение неправильно работает, если изменить открытые данные, то первые значения в столбцах не сохраняются
            DataCreationGrid.SelectAll();
            DataObject dataObj = DataCreationGrid.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            object misValue = System.Reflection.Missing.Value;
            Excel.Application xlexcel = new Excel.Application();

            xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
            Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // Format column D as text before pasting results, this was required for my data
            Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
            rng.NumberFormat = "@";

            // Paste clipboard results to worksheet range
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
            // Delete blank column A and select cell A1
            Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
            delRng.Delete(Type.Missing);
            xlWorkSheet.get_Range("A1").Select();

            // Save the excel file under the captured location from the SaveFileDialog
            xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlexcel.DisplayAlerts = true;
            xlWorkBook.Close(true, misValue, misValue);
            xlexcel.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlexcel);

            // Clear Clipboard and DataGridView selection
            Clipboard.Clear();
            DataCreationGrid.ClearSelection();
            
        }
        public void SaveDataToTxt(string fileName)
        {
            //todo savedatatotxt
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

                case ".csv":
                case ".txt":
                    SaveDataToTxt(fileName);
                    break;

                default:
                    break;
            }



            DataSaved = true;




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

        private DataTable getDataFromExcel(string dataSource, string pathExtension)
        {
            string connectionString;

            if(pathExtension == ".xls")
                connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = '" + dataSource + "';Extended Properties=\"Excel 8.0;HDR=YES;\"";
            else
                connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + dataSource + "';Extended Properties=\"Excel 12.0;HDR=YES;\"";

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
        private DataTable getDataFromTxt(string dataSource, string pathExtension)
        {
            return null;
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
                    dataTable = getDataFromExcel(dataSource, pathExtension);
                    break;

                case ".csv":
                case ".txt":
                    dataTable = getDataFromTxt(dataSource, pathExtension);
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
