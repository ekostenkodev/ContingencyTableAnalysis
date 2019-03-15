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
    public partial class ucQuickAnalysis : UserControl
    {
        public ucQuickAnalysis()
        {
            InitializeComponent();
        }

        public void SetValues(QAValues values)
        {
            label1.Text = values.Labels[0];
            label2.Text = values.Labels[1];
            label3.Text = values.Labels[2];
            label4.Text = values.Labels[3];
            label5.Text = values.Labels[4];
            label6.Text = values.Labels[5];

            ((ListBox)ParametersCheckBox).DataSource = values.Parameters;

        }


    }
    

}
