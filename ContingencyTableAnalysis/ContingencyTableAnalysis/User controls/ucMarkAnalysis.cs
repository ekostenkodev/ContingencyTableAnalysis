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
    public partial class ucMarkAnalysis : UserControl
    {
        private int _analysisIndex;
        private MainForm _mainForm;
        List<GridColumnWithMark> _dataColumns;

        List<Tuple<string, string>> analysisVariation;


        public ucMarkAnalysis(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

        }
        public void SetAnalysisPanel(int analysisIndex,List<string> rowNames, List<string> columnNames)
        {
            _dataColumns = new List<GridColumnWithMark>(_mainForm.PanelDataCreation.Controls
                                                            .OfType<ucDataCreation>()
                                                            .First()
                                                            .DataCreationGrid.Columns.Cast<GridColumnWithMark>());

            var rows = GetMarkVariations(rowNames);
            var columns = GetMarkVariations(columnNames);

            MarkVariationComboBox.DataSource = getVariationStrings(rows, columns);
            MarkVariationComboBox.DisplayMember = "Name";
            // todo sho MarkVariationComboBox.ValueMember = "MarkInfo";

        }

        private List<MarkInfoTuple> getVariationStrings(List<MarkInfo> rows, List<MarkInfo> columns)
        {
            var markVariations = new List<MarkInfoTuple>();
            foreach (var row in rows)
            {
                foreach (var rowValue in row.Values)
                {
                    foreach (var column in columns)
                    {
                        foreach (var columnValue in column.Values)
                        {
                            markVariations.Add(new MarkInfoTuple(new MarkInfo[] { row,column}, new string []{rowValue.Key,columnValue.Key }));
                        }
                    }
                }
            }

            return markVariations;
        }

        public List<MarkInfo> GetMarkVariations(List<string> markNames)
        {
            List<MarkInfo> variationList = new List<MarkInfo>();

            foreach (var markName in markNames)
            {
                variationList.Add(new MarkInfo(markName, getUniqueVar(markName)));
            }

            return variationList;
        }

        private Dictionary<string,int> getUniqueVar(string columnName)
        {
            GridColumnWithMark column = _dataColumns.Find(e=>e.Name.Equals(columnName));

            Dictionary<string, int> variationList = new Dictionary<string, int>();

            if (column.Mark)
            {
                var query = column.Items
                            .GroupBy(s => s.ToString())
                            .Select(g => new { Name = g.Key, Count = g.Count() });

                foreach (var item in query)
                    variationList.Add(item.Name, item.Count);

            }
            else
            {
                int count1 = column
                    .Items
                    .Select(e => int.Parse(e.ToString()))
                    .Where(e => e < column.Border)
                    .Sum(e=>e);
                int count2 = column
                    .Items
                    .Select(e => int.Parse(e.ToString()))
                    .Where(e => e >= column.Border)
                    .Sum(e => e);

                variationList.Add("<" + column.Border, count1);
                variationList.Add(">=" + column.Border, count2);
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

            e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font,
                                  new SolidBrush(combo.ForeColor),
                                  new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();

        }

        private void MarkVariationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // todo
            
        }
    }

    public class MarkInfo
    {
        public string Name;
        public Dictionary<string, int> Values;

        public MarkInfo(string name, Dictionary<string, int> values)
        {
            Name = name;
            Values = values;
        }

        public Tuple<int,int> GetValueDifference(string value)
        {
            return new Tuple<int, int>(Values[value], Values.Select(e => e.Value).Sum() - Values[value]);
            
        }
    }

    public class MarkInfoTuple
    {
        public MarkInfo[] MarkInfo = new MarkInfo[2];
        string[] values = new string[2];


        public string Name
        {
            get
            {
                Console.WriteLine("Hello:");
                return "1";
                //return String.Format("{0} ({1}) - {2} ({3})", MarkInfo[0].Name, values[0], MarkInfo[1].Name, values[0]);
            }
            set
            {

            }
        }

        public MarkInfoTuple(MarkInfo[] markInfo, string[] values)
        {
            this.MarkInfo = markInfo;
            this.values = values;
        }
    }
}
