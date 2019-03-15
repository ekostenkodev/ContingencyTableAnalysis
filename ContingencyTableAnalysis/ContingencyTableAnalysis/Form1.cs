using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContingencyTableAnalysis
{
    public partial class MainForm : Form
    {
        QAValues[] QAValues = {
            new QAValues { Labels = StaticValues.ConnectionAnalysisLabels , Parameters = StaticValues.ConnectionAnalysisParameters},
            new QAValues { Labels = StaticValues.DifferencesAnalysisLabels , Parameters = StaticValues.DifferencesAnalysisParameters},
            new QAValues { Labels = StaticValues.RiskAnalysisLabels , Parameters = StaticValues.RiskAnalysisLabels},
            new QAValues { Labels = StaticValues.DiagnosAnalysisLabels , Parameters = StaticValues.DiagnosAnalysisParameters},
            new QAValues { Labels = StaticValues.HealAnalysisLabels , Parameters = StaticValues.HealAnalysisParameters}

        };
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void быстрыйАнализToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void tabPageEnter(object sender, EventArgs e)
        {
            int index = tabControlQA.SelectedIndex;
            ((TabPage)sender).Controls.OfType<ucQuickAnalysis>().First().SetValues(QAValues[index]);
        }
        
    }
    public class QA
    {

    }
}
