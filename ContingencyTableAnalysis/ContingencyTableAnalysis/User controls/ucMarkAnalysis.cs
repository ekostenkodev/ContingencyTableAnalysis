using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContingencyTableAnalysis
{
    public partial class ucMarkAnalysis : UserControl
    {
        private int _analysisIndex;
        private MainForm _mainForm;
        List<GridColumnWithMark> _dataColumns;

        public ucMarkAnalysis(MetroFramework.Forms.MetroForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm as MainForm;

        }
        public void SetAnalysisPanel(int analysisIndex, List<string> rowNames, List<string> columnNames)
        {
            _dataColumns = new List<GridColumnWithMark>(_mainForm.PanelDataCreation.Controls
                                                            .OfType<ucDataCreation>()
                                                            .First()
                                                            .DataCreationGrid.Columns.Cast<GridColumnWithMark>());
            
            _analysisIndex = analysisIndex;
            var rows = getGridColumnsByName(rowNames);
            var columns = getGridColumnsByName(columnNames);
            MarkVariationComboBox.ValueMember = "MarkInfo";
            MarkVariationComboBox.DataSource = getVariationStrings(rows, columns);

            AnalysisLabel.Text = DBHelper.GetAnalysisName(_analysisIndex+1);

        }

        private List<MarkInfoTuple> getVariationStrings(List<GridColumnWithMark> rows, List<GridColumnWithMark> columns)
        {
            var markVariations = new List<MarkInfoTuple>();
            foreach (var row in rows)
            {
                foreach (var rowValue in getUniqueVariations(row.Name))
                {
                    foreach (var column in columns)
                    {
                        foreach (var columnValue in getUniqueVariations(column.Name))
                        {
                            markVariations.Add(new MarkInfoTuple(new GridColumnWithMark[] { row, column }, new string[] { rowValue.ToString(), columnValue.ToString() }));
                        }

                    }

                }

            }

            return markVariations;
        }

        private List<GridColumnWithMark> getGridColumnsByName(List<string> markNames)
        {
            List<GridColumnWithMark> variationList = new List<GridColumnWithMark>();

            foreach (var markName in markNames)
            {
                variationList.Add(_dataColumns.Find(e => e.Name.Equals(markName)));
            }

            return variationList;
        }

        private List<object> getUniqueVariations(string columnName)
        {
            GridColumnWithMark column = _dataColumns.Find(e=>e.Name.Equals(columnName));

            List<object> variationList = new List<object>();

            if (column.Qualitative)
            {
                var query = column.Items
                            .GroupBy(s => s.ToString())
                            .Select(g => new { Name = g.Key});

                foreach (var item in query)
                    variationList.Add(item.Name);

            }
            else
            {
                variationList.Add(column.Border);
            }

            return variationList;
        }

        private void MarkVariationComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Color.FromArgb(209, 17, 65)   

            if (e.Index < 0)
                return;

            ComboBox combo = sender as ComboBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(209, 17, 65)),
                                         e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(combo.BackColor),
                                         e.Bounds);

            e.Graphics.DrawString(((MarkInfoTuple)combo.Items[e.Index]).Name, e.Font,
                                  new SolidBrush(combo.ForeColor),
                                  new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();

        }

        private void MarkVariationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkInfoTuple tuple = ((ComboBox)sender).SelectedItem as MarkInfoTuple;
            ucQuickAnalysis analysisPanel = _mainForm.PanelAnalysis.Controls.OfType<ucMarkAnalysis>().First().Controls.OfType<ucQuickAnalysis>().First();
            analysisPanel.SetAnalysisStrings(getAnalysisStrings(_analysisIndex, tuple));
            analysisPanel.SetTextBoxes(GetMarkValues(tuple));




        }
        public int[,] GetMarkValues(MarkInfoTuple tuple)
        {
            int[,] values = new int[2,2];

            List<object> tupleList_1 = tuple.Columns[0].Items.Select(item => item).ToList();
            List<object> tupleList_2 = tuple.Columns[1].Items.Select(item => item).ToList();

            int minLength = tupleList_1.Count < tupleList_2.Count ? tupleList_1.Count : tupleList_2.Count;
            int row=-1, column=-1;
            for (int i = 0; i < minLength; i++)
            {
                if(tuple.Columns[0].Qualitative)
                {
                    if (tupleList_1[i].Equals(tuple.Values[0]))
                        row = 0;
                    else
                        row = 1;
                }
                else
                {
                    if(int.Parse(tupleList_1[i].ToString())<int.Parse(tuple.Values[0].ToString()))
                        row = 0;
                    else
                        row = 1;
                }


                if (tuple.Columns[1].Qualitative)
                {
                    if (tupleList_2[i].Equals(tuple.Values[1]))
                        column = 0;
                    else
                        column = 1;
                }
                else
                {

                    if (int.Parse(tupleList_2[i].ToString()) < int.Parse(tuple.Values[1]))
                        column = 0;
                    else
                        column = 1;
                }
                values[row, column]++;


            }

            return values;

        }

        private AnalysisStrings getAnalysisStrings(int analysisIndex, MarkInfoTuple tuple)
        {
            var parameters = DBHelper.GetAnalysisParameters(analysisIndex+1);

            string[] labels = new string[6];

            labels[0] = tuple.Columns[0].Name;
            if (tuple.Columns[0].Qualitative)
            {

                if(tuple.Columns[0].Items.Distinct().Count() > 2)
                    labels[1] = "Другие варианты";
                else
                    labels[1] = tuple.Columns[0].Items.Select(e=>e.ToString()).First(e=>!e.Equals(tuple.Values[0]));

                labels[2] = tuple.Values[0];


            }
            else
            {
                labels[1] = ">=" + tuple.Columns[0].Border;
                labels[2] = "<" + tuple.Columns[0].Border;
            }



            labels[3] = tuple.Columns[1].Name;
            if (tuple.Columns[1].Qualitative)
            {
                labels[4] = tuple.Values[1];

                if (tuple.Columns[1].Items.Distinct().Count() > 2 || tuple.Columns[1].Items.Distinct().Count() == 1)
                    labels[5] = "Другие варианты";
                else
                    labels[5] = tuple.Columns[1].Items.Select(e => e.ToString()).First(e => !e.Equals(tuple.Values[1]));

            }
            else
            {
                labels[4] = "<" + tuple.Columns[1].Border;
                labels[5] = ">=" + tuple.Columns[1].Border;
            }
            return new AnalysisStrings() { Labels = labels, Parameters = parameters[analysisIndex] };
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            _mainForm.ShowPanel(_mainForm.PanelMark);
            _mainForm.PanelMark.Controls.OfType<ucMarkConversion>().First().SetMarkPanel(_analysisIndex);
        }
    }



    public class MarkInfoTuple
    {
        public GridColumnWithMark[] Columns = new GridColumnWithMark[2];
        public string[] Values = new string[2];

        public string Name
        {
            get
            {
                string mark1 = "";
                string mark2 = "";
                if(!Columns[0].Qualitative)
                    mark1 = "граница - ";
                if (!Columns[1].Qualitative)
                    mark2 = "граница - ";

                return String.Format("{0} ({1}) - {2} ({3})", Columns[0].Name, mark1+ Values[0], Columns[1].Name, mark2+ Values[1]);
            }
            set
            {

            }
        }

        public MarkInfoTuple(GridColumnWithMark[] columns, string[] values)
        {
            this.Columns = columns;
            this.Values = values;

        }
    }
}
