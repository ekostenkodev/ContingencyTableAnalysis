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

namespace ContingencyTableAnalysis
{
    public partial class ucDataCreation : UserControl
    {

        public ucDataCreation()
        {
            InitializeComponent();

            // todo убрать
            /*
            GridColumnWithMark column1 = new GridColumnWithMark() { HeaderText = "Признак " + (DataCreationGrid.ColumnCount + 1), Name = "Признак " + (DataCreationGrid.ColumnCount + 1), Qualitative = false };
            DataCreationGrid.Columns.Add(column1);
            GridColumnWithMark column2 = new GridColumnWithMark() { HeaderText = "Признак " + (DataCreationGrid.ColumnCount + 1), Name = "Признак " + (DataCreationGrid.ColumnCount + 1), Qualitative = false };
            DataCreationGrid.Columns.Add(column2);
            DataCreationGrid.Rows.Add();
            DataCreationGrid.Rows.Add();
            column1.DataGridView.Rows[0].Cells[column1.Index].Value = 5;
            column1.DataGridView.Rows[1].Cells[column1.Index].Value = 25;
            column2.DataGridView.Rows[0].Cells[column2.Index].Value = 30;
            column2.DataGridView.Rows[1].Cells[column2.Index].Value = 60;
            */
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
                if (e.ColumnIndex < 0) // нужно, ибо при нажатии на левую колонку GridView вызывается этот метод, где e.ColumnIndex == -1
                    return;
                
                MetroFramework.Controls.MetroGrid metroGrid = (MetroFramework.Controls.MetroGrid)sender;
                System.Drawing.Point mouseLocation = metroGrid.PointToClient(Cursor.Position); // relative position
                ShowContextMenuColumn((GridColumnWithMark)metroGrid.Columns[e.ColumnIndex], mouseLocation);
                
            }
        }

        public void DownloadData(string dataSource)
        {
            if (DataCreationGrid.DataSource != null) // todo проверка на сохранение
                DataCreationGrid.DataSource = null;

            OleDbConnection MyConnection;
            DataSet DtSet;
            OleDbDataAdapter MyCommand;
            // C:\Users\Дарья\Desktop\MS_lab1\MS_lab1\var1.xls
            MyConnection = new OleDbConnection(String.Format(@"provider=Microsoft.Jet.OLEDB.4.0;
Data Source='{0}';Extended Properties=Excel 8.0;", dataSource));
            MyCommand = new OleDbDataAdapter("select * from [База данных$]", MyConnection);
            MyCommand.TableMappings.Add("Table", "Net");
            DtSet = new DataSet();
            MyCommand.Fill(DtSet);

            DataCreationGrid.Rows.Clear();
            DataCreationGrid.Columns.Clear();
            // todo переделать
            int index = 0;
            foreach (var item in DtSet.Tables[0].Columns)
            {
                GridColumnWithMark column = new GridColumnWithMark() { HeaderText = item.ToString(), Name = item.ToString() };
                DataCreationGrid.Columns.Add(column);
                index++;
            }
            for (int i = 0; i < DtSet.Tables[0].Rows.Count; i++)
            {
                DataCreationGrid.Rows.Add();
            }

            for (int row = 1; row < DtSet.Tables[0].Rows.Count; row++)
            {
                
                for (int column = 0; column < DtSet.Tables[0].Columns.Count; column++)
                {
                    DataCreationGrid.Rows[row].Cells[column].Value = DtSet.Tables[0].Rows[row].ItemArray[column].ToString();

                }
            }

            
            


        }

        public void ShowContextMenuColumn(GridColumnWithMark column, System.Drawing.Point mouseLocation)
        {
            //todo при возможности переписать, много ненужных переменных
            ContextMenu _contextMenu = new ContextMenu();

            var columnChangeName = new System.Windows.Forms.MenuItem("Переименовать признак");
            var columnChangeMark = new System.Windows.Forms.MenuItem("Вид признака");
            var columnDelete = new System.Windows.Forms.MenuItem("Удалить признак");
            var radio_1 = new System.Windows.Forms.MenuItem("Качественный");
            var radio_2 = new System.Windows.Forms.MenuItem("Количественный");

            radio_1.RadioCheck = true;
            radio_2.RadioCheck = true;

            if (column.Qualitative)
            {
                radio_1.Checked = true;
            }
            else
            {
                radio_2.Checked = true;
            }

            EventHandler radioChangeMethod = new EventHandler((sender, e) => {
                
                if (sender.Equals(radio_1))
                {
                    radio_1.Checked = true;
                    radio_2.Checked = false;
                    column.Qualitative = true;
                }
                else
                {
                    radio_1.Checked = false;
                    radio_2.Checked = true;
                    column.Qualitative = false;
                }
                
            });
            EventHandler nameChangeMethod = new EventHandler((sender, e) => {
                ChangeColumnNameForm form = new ChangeColumnNameForm(column.HeaderText);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    column.Name = form.ColumnNameTextBox.Text;
                    column.HeaderText = form.ColumnNameTextBox.Text;
                }

            });
            EventHandler deleteColumnMethod = new EventHandler((sender, e) => {
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удаление признака", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    column.DataGridView.Columns.Remove(column);
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            });

            columnChangeName.Click += nameChangeMethod;
            columnDelete.Click += deleteColumnMethod;
            radio_1.Click += radioChangeMethod;
            radio_2.Click += radioChangeMethod;

            _contextMenu.MenuItems.Add(columnChangeName);
            _contextMenu.MenuItems.Add(columnChangeMark);
            _contextMenu.MenuItems.Add(columnDelete);
            columnChangeMark.MenuItems.Add(radio_1);
            columnChangeMark.MenuItems.Add(radio_2);

            _contextMenu.Show(DataCreationGrid, mouseLocation);

        }

        private void DataCreationGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


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
