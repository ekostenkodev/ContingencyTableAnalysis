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
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        

        private void inputDataTextBox1_Validating(object sender, CancelEventArgs e)
        {
            InputDataTextBox textBox = (InputDataTextBox)sender;

            if (textBox.Text[textBox.Text.Length - 1] == '%')
                textBox.Text = textBox.Text.ToString().Substring(0, textBox.Text.Length - 1);

            if (Double.TryParse(textBox.Text, out double value))
            {
                value = value > textBox.MaxValue ? textBox.MaxValue : value < textBox.MinValue ? textBox.MinValue : value;
                textBox.Text = value.ToString() + "%";
            }
            else
            {
                textBox.Text = textBox.LastState;
                MessageBox.Show("Введены недопустимые значения");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
