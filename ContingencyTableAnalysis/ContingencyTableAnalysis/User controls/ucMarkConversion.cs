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
        private string[,] analysisLabels = 
        {
            {"Перечень признаков (столбцов) набора данных", "Перечень строк ", "Перечень столбцов"},
            {"Перечень признаков (столбцов) набора данных", "Перечень строк ", "Перечень столбцов"},
            {"Перечень признаков (столбцов) набора данных", "Перечень факторов", "Перечень исходов"},
            {"Перечень признаков (столбцов) набора данных", "Перечень результатов методов диагностики", "Перечень фактического наличия исходов"},
            {"Перечень признаков (столбцов) набора данных", "Перечень исходов лечения", "Перечень методов лечения"},
        };
        private MetroFramework.Controls.MetroGrid _data;
        private int analysisIndex;
        public ucMarkConversion()
        {
            InitializeComponent();
        }

        private void StartCalcBtn_Click(object sender, EventArgs e)
        {

        }
        public void SetMarkPanel(int analysisIndex, MainForm mainForm)
        {
            ListAllMark.Items.Clear();
            ListRows.Items.Clear();
            ListColumns.Items.Clear();

            this.analysisIndex = analysisIndex;

            _data = mainForm.PanelDataCreation.Controls.OfType<ucDataCreation>().First().DataCreationGrid;
            foreach (GridColumnWithMark item in _data.Columns)
            {
                ListAllMark.Items.Add(item.HeaderText);
            }

            SetLabels(analysisIndex);

        }

        private void SetLabels(int index)
        {
            LabelAll.Text = analysisLabels[index, 0];
            LabelR.Text = analysisLabels[index, 1];
            LabelC.Text = analysisLabels[index, 2];
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
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(209, 17, 65));

            e.DrawBackground();
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();


        }


        private void ListAllMark_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");

        }

        private void ListAllMark_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (listBox.Items.Count == 0)
                return;
            int index = listBox.IndexFromPoint(e.X, e.Y);

            if (index < 0)
                return;

            //поиск выбранного столбца
            //var list = new List<GridColumnWithMark>();
            //list.AddRange(_data.Columns.Cast<GridColumnWithMark>());
            //int columnIndex = list.Find(item => item.HeaderText.Equals(listBox.Items[index])).Index;
            int columnIndex = _data.Columns[listBox.Items[index].ToString()].Index;
            if (!((GridColumnWithMark)_data.Columns[columnIndex]).Mark)
            {
                List<int> columnValues = new List<int>();

                for (int i = 0; i < _data.Rows.Count; i++)
                {
                    columnValues.Add(Int32.Parse((string)_data.Rows[i].Cells[columnIndex].Value));
                }

                int min = columnValues.Min();
                int max = columnValues.Max();
                int average = (max + min) / 2;
                ValueTrackBar.Minimum = min;
                ValueTrackBar.Maximum = max;
                ValueTrackBar.Value = average;


                minValueLabel.Text = min.ToString();
                maxValueLabel.Text = max.ToString();
            }

        }

        private void ValueTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            ValueTextBox.Text = ((TrackBar)sender).Value.ToString();
        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
