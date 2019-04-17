using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContingencyTableAnalysis.Forms
{
    public partial class ChangeColumnNameForm : MetroFramework.Forms.MetroForm
    {
        public ChangeColumnNameForm(string columnName)
        {
            InitializeComponent();

            ColumnNameTextBox.Text = columnName;

        }

        private void cn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
