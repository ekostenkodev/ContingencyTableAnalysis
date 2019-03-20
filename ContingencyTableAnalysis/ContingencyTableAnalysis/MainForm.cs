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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        QAStrings[] QAValues = {
            new QAStrings { Labels = StaticQAStrings.ConnectionAnalysisLabels , Parameters = StaticQAStrings.ConnectionAnalysisParameters},
            new QAStrings { Labels = StaticQAStrings.DifferencesAnalysisLabels , Parameters = StaticQAStrings.DifferencesAnalysisParameters},
            new QAStrings { Labels = StaticQAStrings.RiskAnalysisLabels , Parameters = StaticQAStrings.RiskAnalysisParameters},
            new QAStrings { Labels = StaticQAStrings.DiagnosAnalysisLabels , Parameters = StaticQAStrings.DiagnosAnalysisParameters},
            new QAStrings { Labels = StaticQAStrings.HealAnalysisLabels , Parameters = StaticQAStrings.HealAnalysisParameters}

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ((MetroFramework.Forms.MetroForm)this).Style++;
        }
    }

}
