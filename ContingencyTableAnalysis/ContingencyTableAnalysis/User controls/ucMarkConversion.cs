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
        GridColumnWithMark selectedColumn;
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
                ListAllMark.Items.Add(item.GetName(false));
            }

            SetLabels(analysisIndex);

        }
        /*
        public void UpdateAllListBox()
        {
            List<string> listAll = new List<string>();
            List<string> listR = new List<string>();
            List<string> listC = new List<string>();

            foreach (string item in ListAllMark.Items)
            {
                listAll.Add(item);
            }
            foreach (string item in ListRows.Items)
            {
                listR.Add(item);
            }
            foreach (string item in ListColumns.Items)
            {
                listC.Add(item);
            }

            ListAllMark.Items.Clear();
            ListRows.Items.Clear();
            ListColumns.Items.Clear();

            foreach (GridColumnWithMark item in _data.Columns)
            {
                if(listR.Contains(item.Name))
                    ListRows.Items.Add(item.GetName(false));
                else if(listC.Contains(item.Name))
                    ListColumns.Items.Add(item.GetName(false));
                else
                    ListAllMark.Items.Add(item.GetName(false));
            }
        }
        */

        private void SetLabels(int index)
        {
            LabelAll.Text = analysisLabels[index, 0];
            LabelR.Text = analysisLabels[index, 1];
            LabelC.Text = analysisLabels[index, 2];
        }
        public void EnableValuePanel()
        {
            PanelValue.Enabled = true;


            //поиск выбранного столбца
            //var list = new List<GridColumnWithMark>();
            //list.AddRange(_data.Columns.Cast<GridColumnWithMark>());
            //int columnIndex = list.Find(item => item.HeaderText.Equals(markName)).Index;



            if (!selectedColumn.Mark)
            {

                int min = selectedColumn.Items.Min(e=>int.Parse(e.ToString()));
                int max = selectedColumn.Items.Max(e=>int.Parse(e.ToString()));

                ValueTrackBar.Minimum = ValueTrackBar.Minimum = 0; // нужно, ибо возникает ошибка : Minimal value is greather than maximal one
                ValueTrackBar.Maximum = max;
                ValueTrackBar.Minimum = min;
                ValueTrackBar.Value = selectedColumn.Border;
                ValueTextBox.MinValue = min;
                ValueTextBox.MaxValue = max;
                ValueTextBox.Text = ValueTrackBar.Value.ToString();


                minValueLabel.Text = min.ToString();
                maxValueLabel.Text = max.ToString();
            }

            UpdateValueLabel();

        }

        private void List_mouseDown(object sender, MouseEventArgs e)
        {

            ListBox listBox = (ListBox)sender;

            if (listBox.Items.Count == 0)
                return;
            int index = listBox.IndexFromPoint(e.X, e.Y);

            if (index < 0)
                return;


            string markName = listBox.Items[index].ToString();
            selectedColumn = (GridColumnWithMark)_data.Columns[markName];

            DragDropEffects dde1 = DoDragDrop(selectedColumn.GetName(false),
                DragDropEffects.All);

            EnableValuePanel();


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


        public void UpdateValueLabel()
        {
            ValueLabel.Text = selectedColumn.GetName(true);
        }

        private void ValueTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            ValueTextBox.Text = ValueTrackBar.Value.ToString();
            selectedColumn.Border = ValueTrackBar.Value;
            UpdateValueLabel();
        }

        private void ValueTextBox_Validated(object sender, EventArgs e)
        {
            int value = Int32.Parse(ValueTextBox.Text);
            ValueTrackBar.Value = selectedColumn.Border = value; // todo ошибка на больше меньше
            UpdateValueLabel();

        }
    }
}
