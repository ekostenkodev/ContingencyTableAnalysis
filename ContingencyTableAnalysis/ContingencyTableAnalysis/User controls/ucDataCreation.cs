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

namespace ContingencyTableAnalysis
{
    public partial class ucDataCreation : UserControl
    {

        public ucDataCreation()
        {
            InitializeComponent();

            // todo убрать
            GridColumnWithMark column1 = new GridColumnWithMark() { HeaderText = "Признак " + (DataCreationGrid.ColumnCount + 1), Name = "Признак " + (DataCreationGrid.ColumnCount + 1), Mark = false };
            DataCreationGrid.Columns.Add(column1);
            GridColumnWithMark column2 = new GridColumnWithMark() { HeaderText = "Признак " + (DataCreationGrid.ColumnCount + 1), Name = "Признак " + (DataCreationGrid.ColumnCount + 1), Mark = false };
            DataCreationGrid.Columns.Add(column2);
            DataCreationGrid.Rows.Add();
            DataCreationGrid.Rows.Add();
            column1.DataGridView.Rows[0].Cells[column1.Index].Value = 5;
            column1.DataGridView.Rows[1].Cells[column1.Index].Value = 25;
            column2.DataGridView.Rows[0].Cells[column2.Index].Value = 30;
            column2.DataGridView.Rows[1].Cells[column2.Index].Value = 60;

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
                Point mouseLocation = metroGrid.PointToClient(Cursor.Position); // relative position
                ShowContextMenuColumn((GridColumnWithMark)metroGrid.Columns[e.ColumnIndex], mouseLocation);
                
            }
        }

        public void ShowContextMenuColumn(GridColumnWithMark column, Point mouseLocation)
        {
            //todo при возможности переписать, много ненужных переменных
            ContextMenu _contextMenu = new ContextMenu();

            MenuItem columnChangeName = new MenuItem("Переименовать признак");
            MenuItem columnChangeMark = new MenuItem("Вид признака");
            MenuItem columnDelete = new MenuItem("Удалить признак");
            MenuItem radio_1 = new MenuItem("Качественный");
            MenuItem radio_2 = new MenuItem("Количественный");

            radio_1.RadioCheck = true;
            radio_2.RadioCheck = true;

            if (column.Mark)
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
                    column.Mark = true;
                }
                else
                {
                    radio_1.Checked = false;
                    radio_2.Checked = true;
                    column.Mark = false;
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
            if (metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                return;

            GridColumnWithMark column = (GridColumnWithMark)metroGrid.Columns[e.ColumnIndex];

            if (!metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().All(char.IsDigit) && !column.Mark) 
            {
                MessageBox.Show("Нельзя вводить строковые значения в количественные признаки");
                metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            }
            ((GridColumnWithMark)metroGrid.Columns[e.ColumnIndex]).CellValueChanged(metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }
    }




}
