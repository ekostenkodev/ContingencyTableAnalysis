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

        QAStrings[] QAStrings = new QAStrings[5];

        public ucQuickTabPanel()
        {
            InitializeComponent();

            var analysisLabels = DBHelper.GetAnalysisLabels();
            var parameters = DBHelper.GetAnalysisParameters();

            for (int i = 0; i < QAStrings.Length; i++)
            {
                QAStrings[i].Labels = analysisLabels[i];
                QAStrings[i].Parameters = parameters[i];
            }

            tabControlQA.SelectTab(1);//todo может, лучше начинать с 0
            
        }

        private void tabPageEnter(object sender, EventArgs e)
        {
            int index = tabControlQA.SelectedIndex;
            ((TabPage)sender).Controls.OfType<ucQuickAnalysis>().First().SetStrings(QAStrings[index]);
        }


    }
}
