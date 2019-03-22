using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContingencyTableAnalysis
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {


        QAStrings[] QAStrings = new QAStrings[5];
        string[][] analysisLabels;
        public List<string>[] parameters;


        public MainForm()
        {
            InitializeComponent();
            analysisLabels = DBHelper.GetAnalysisLabels();
            parameters = DBHelper.GetAnalysisParameters();

            for (int i = 0; i < QAStrings.Length; i++)
            {
                QAStrings[i].Labels = analysisLabels[i];
                QAStrings[i].Parameters = parameters[i];

            }
            
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
            ((TabPage)sender).Controls.OfType<ucQuickAnalysis>().First().SetValues(QAStrings[index]);
            
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
