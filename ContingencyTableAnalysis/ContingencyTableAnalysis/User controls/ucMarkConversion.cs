using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContingencyTableAnalysis.User_controls
{
    public partial class ucMarkConversion : UserControl
    {
        string[,] labels = 
        {
            {"Перечень признаков (столбцов) набора данных", "Перечень строк ", "Перечень столбцов"},
            {"Перечень признаков (столбцов) набора данных", "Перечень строк ", "Перечень столбцов"},
            {"Перечень признаков (столбцов) набора данных", "Перечень факторов", "Перечень исходов"},
            {"Перечень признаков (столбцов) набора данных", "Перечень результатов методов диагностики", "Перечень фактического наличия исходов"},
            {"Перечень признаков (столбцов) набора данных", "Перечень исходов лечения", "Перечень методов лечения"},
        };

        private int index;
        public ucMarkConversion()
        {
            InitializeComponent();
        }

        private void StartCalcBtn_Click(object sender, EventArgs e)
        {

        }
        public void SetMarkPanel(int index, MainForm mainForm)
        {
            this.index = index;
            SetLabels(index);
            List<string> marks = new List<string>();
            ListAllMark.Items.Clear();
            ListRows.Items.Clear();
            ListColumns.Items.Clear();
            foreach (GridColumnWithMark item in mainForm.Data.Columns)
            {
                ListAllMark.Items.Add(item.HeaderText);
            }
        }
        private void SetLabels(int index)
        {
            LabelAll.Text = labels[index, 0];
            LabelR.Text = labels[index, 1];
            LabelC.Text = labels[index, 2];
        }

        private void List_mouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (listBox.Items.Count == 0)
                return;
            int index = listBox.IndexFromPoint(e.X, e.Y);

            if (index < 0)
                return;

            string s = listBox.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s,
                DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
            {
                listBox.Items.RemoveAt(listBox.IndexFromPoint(e.X, e.Y));
            }
        }

        private void List_dragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string)e.Data.GetData(
                    DataFormats.StringFormat);

                ((ListBox)sender).Items.Add(str);
            }
        }

        private void List_dragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }



        private void List_drawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(209, 17, 65));//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();


        }


    }
}
