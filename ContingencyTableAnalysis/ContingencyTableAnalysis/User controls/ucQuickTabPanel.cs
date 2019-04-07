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
    public partial class ucQuickTabPanel : UserControl
    {
        /// <summary>
        /// TabControl содержащий 5 панелей с быстрым анализом
        /// </summary>

        AnalysisStrings[] AnalysisStrings;

        public ucQuickTabPanel()
        {

            InitializeComponent();

            AnalysisStrings = getAnalysisStrings();

            tabControlQA.SelectTab(1); //todo если начинать с 0, то лейблы не обновляются -> надо исправить
            
        }

        private AnalysisStrings[] getAnalysisStrings()
        {
            AnalysisStrings[] aStrings = new AnalysisStrings[5];
            var analysisLabels = DBHelper.GetAnalysisLabels();
            var parameters = DBHelper.GetAnalysisParameters();

            for (int i = 0; i < aStrings.Length; i++)
            {
                aStrings[i].Labels = analysisLabels[i];
                aStrings[i].Parameters = parameters[i];
            }
            return aStrings;
        }

        

        private void tabPageEnter(object sender, EventArgs e)
        {
            ///установка строковых значений для панели быстрого анализа на tabPage 
            
            int index = tabControlQA.SelectedIndex;
            TabPage page = (TabPage)sender;
            page.Controls.OfType<ucQuickAnalysis>().First().SetAnalysisStrings(AnalysisStrings[index]); 
        }


    }
}
