using ContingencyTableAnalysis.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace ContingencyTableAnalysis
{

    public class GridColumnWithMark : DataGridViewTextBoxColumn
    {
        public int? _border;
        public int? Border
        {
            get
            {
                if (_border.HasValue)
                    return _border;
                else
                    return getAverage();
            }
            set
            {
                if (Qualitative)
                {
                    return;
                }
                _border = value;
            }
        }

        public int? Min
        {
            get
            {
                if (Qualitative)
                    return null;

                return Items.Min(e => int.Parse(e.ToString()));

            }
        }
        public int? Max
        {

            get
            {
                if (Qualitative)
                    return null;

                return Items.Max(e => int.Parse(e.ToString()));

            }
        }
        public List<object> Items { get
            {
                return ItemsWithNull.Where(e=>e!=null).ToList();
            } }
        public List<object> ItemsWithNull { get; } = new List<object>();
        private bool _qualitative = true;
        public bool Qualitative // качественный признак
        {
            get
            {
                return _qualitative;
            }
            set
            {
                if (value)
                    Border = null;


                _qualitative = value;
            }
        }

        private void fillItemListWithEmpty(int index)
        {
            while (index >= ItemsWithNull.Count)
            {
                ItemsWithNull.Add(null);
            }
        }
        ContextMenu _contextMenu;

        public GridColumnWithMark()
        {
            SetContextMenu();
        }

        public void SetContextMenu()
        {
            _contextMenu = new ContextMenu();
            var columnChangeName = new System.Windows.Forms.MenuItem("Переименовать признак");
            var columnChangeMark = new System.Windows.Forms.MenuItem("Вид признака");
            var columnDelete = new System.Windows.Forms.MenuItem("Удалить признак");
            var radio_1 = new System.Windows.Forms.MenuItem("Качественный");
            var radio_2 = new System.Windows.Forms.MenuItem("Количественный");

            radio_1.RadioCheck = true;
            radio_2.RadioCheck = true;

            if (Qualitative)
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
                    Qualitative = true;
                }
                else
                {
                    radio_1.Checked = false;
                    radio_2.Checked = true;
                    Qualitative = false;
                }

            });
            EventHandler nameChangeMethod = new EventHandler((sender, e) => {
                ChangeColumnNameForm form = new ChangeColumnNameForm(HeaderText);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Name = form.ColumnNameTextBox.Text;
                    HeaderText = form.ColumnNameTextBox.Text;
                }

            });
            EventHandler deleteColumnMethod = new EventHandler((sender, e) => {
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удаление признака", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataGridView.Columns.Remove(this);
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
        }

        public void ShowContextMenu(MetroFramework.Controls.MetroGrid gridView, Point mouseLocation)
        {
            _contextMenu.Show(gridView, mouseLocation);
        }

        public void CellValueChanged(int rowIndex,object value)
        {
            if (value.Equals(""))
                return;

            if(rowIndex>= ItemsWithNull.Count) 
                fillItemListWithEmpty(rowIndex);// заполнение списка пустыми значениями. Нужно для удобного удаления/вставки элементов в списке.

            ItemsWithNull[rowIndex] = value;
            
            if (new HashSet<object>(Items).Count > int.Parse(Properties.Resources.Setting4)) // проверка на уникальность качественных признаков в списке(нужно по тз) 
                Qualitative = false;

        }

        private int getAverage() => (Min.Value + Max.Value) / 2;


        public string GetName(bool border) => border ? HeaderText + " (граница - " + Border + ")" : HeaderText;
        
        
    }
}
