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

        }


        private void dc_addColumn_Click(object sender, EventArgs e)
        {
            GridColumnWithMark column = new GridColumnWithMark() { HeaderText = "Признак " + (DataCreationGrid.ColumnCount + 1) };
            DataCreationGrid.Columns.Add(column);
        }

        private void DataCreationGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.ColumnIndex < 0) // нужно, ибо при нажатии на левую колонку GridView вызывается этот метод, где e.ColumnIndex == -1
                    return;
                
                MetroFramework.Controls.MetroGrid metroGrid = (MetroFramework.Controls.MetroGrid)sender;
                ShowContextMenuColumn((GridColumnWithMark)metroGrid.Columns[e.ColumnIndex], e.Location);
                
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

            _contextMenu.Show(column.DataGridView, mouseLocation);

        }

    }

    public class GridColumnWithMark : DataGridViewTextBoxColumn
    {
        public bool Mark = true;
    }



}
