using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContingencyTableAnalysis
{
    public partial class ucMarkConversion : UserControl
    {
        GridColumnWithMark selectedColumn;
        private MainForm _mainForm;
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


        public ucMarkConversion(MetroFramework.Forms.MetroForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm as MainForm;

        }

        private void StartCalcBtn_Click(object sender, EventArgs e)
        {
            _mainForm.ShowPanel(_mainForm.PanelAnalysis);
            _mainForm.PanelAnalysis.Controls.OfType<ucMarkAnalysis>().First().SetAnalysisPanel(analysisIndex,ListRows.Items.Cast<string>().ToList(), ListColumns.Items.Cast<string>().ToList());
        }

        public void SetMarkPanel(int analysisIndex)
        {
            ListAllMark.Items.Clear();
            ListRows.Items.Clear();
            ListColumns.Items.Clear();

            this.analysisIndex = analysisIndex;

            _data = _mainForm.PanelDataCreation.Controls.OfType<ucDataCreation>().First().DataCreationGrid;
            foreach (GridColumnWithMark item in _data.Columns)
            {
                ListAllMark.Items.Add(item.GetName(false));
            }

            SetLabels(analysisIndex);

            AnalysisLabel.Text = DBHelper.GetAnalysisName(analysisIndex+1);

        }


        private void SetLabels(int index)
        {
            LabelAll.Text = analysisLabels[index, 0];
            LabelR.Text = analysisLabels[index, 1];
            LabelC.Text = analysisLabels[index, 2];
        }
        public void EnableValuePanel(GridColumnWithMark selectedColumn)
        {
            this.selectedColumn = selectedColumn;

            if (!selectedColumn.Qualitative)
            {
                PanelScroll.Enabled = true;

                int min = selectedColumn.Min.Value;
                int max = selectedColumn.Max.Value;

                ValueTrackBar.Minimum = ValueTrackBar.Minimum = 0; // нужно, ибо возникает ошибка : Minimal value is greather than maximal one
                ValueTrackBar.Maximum = max;
                ValueTrackBar.Minimum = min;
                ValueTrackBar.Value = selectedColumn.Border.Value;

                ValueTextBox.MinValue = min;
                ValueTextBox.MaxValue = max;
                ValueTextBox.Text = ValueTrackBar.Value.ToString();

                minValueLabel.Text = min.ToString();
                maxValueLabel.Text = max.ToString();
            }
            else
            {
                PanelScroll.Enabled = false;
                ValueTextBox.Text = "0";
                minValueLabel.Text = "-";
                maxValueLabel.Text = "-";
                ValueTrackBar.Value = ValueTrackBar.Minimum;
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

            // todo PanelValue change color
            /*
            int R = 209, G = 17, B = 65;
            int d = 10;
            int interval_R = R / d,
                interval_G = G / d,
                interval_B = B / d;

    */

            string markName = listBox.Items[index].ToString();
            GridColumnWithMark selectedColumn = (GridColumnWithMark)_data.Columns[markName];

            DragDropEffects dde1 = DoDragDrop(selectedColumn.GetName(false),
                DragDropEffects.All);

            EnableValuePanel(selectedColumn);
            


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
            ValueLabel.Text = selectedColumn.GetName(!selectedColumn.Qualitative);
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
            ValueTrackBar.Value = value;
            selectedColumn.Border = value; 
            UpdateValueLabel();

        }


    }
}
