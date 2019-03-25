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

            tbSetting1.MinValue = 0.01;
            tbSetting1.MaxValue = 99.99;

            tbSetting2.MinValue = 1;
            tbSetting2.MaxValue = 100;

            tbSetting3.MinValue = 1;
            tbSetting3.MaxValue = 100;

            tbSetting4.MinValue = 1;
            tbSetting4.MaxValue = 50;

            tbSetting1.Text = Properties.Settings.Default["Setting1"].ToString() + "%";
            tbSetting2.Text = Properties.Settings.Default["Setting2"].ToString();
            tbSetting3.Text = Properties.Settings.Default["Setting3"].ToString();
            tbSetting4.Text = Properties.Settings.Default["Setting4"].ToString();

        }

        

        private void tbSettingValidatingInt(object sender, CancelEventArgs e)
        {
            InputDataTextBox textBox = (InputDataTextBox)sender;

            if (String.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = textBox.LastState;
                return;
            }


            if (Int32.TryParse(textBox.Text, out int value))
            {
                int max = (int)textBox.MaxValue;
                int min = (int)textBox.MinValue;

                value = value >= max ? max : value <= min ? min : value;
                textBox.Text = value.ToString();

            }
            else
            {
                textBox.Text = textBox.LastState;
                MessageBox.Show("Введены недопустимые значения");
            }
        }
        private void tbSettingValidatingDouble(object sender, CancelEventArgs e)
        {
            InputDataTextBox textBox = (InputDataTextBox)sender;

            if (String.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = textBox.LastState;
                return;
            }


            if (textBox.Text[textBox.Text.Length - 1] == '%')
                textBox.Text = textBox.Text.ToString().Substring(0, textBox.Text.Length - 1);

            if (Double.TryParse(textBox.Text, out double value))
            {
                value = value >= textBox.MaxValue ? textBox.MaxValue : value <= textBox.MinValue ? textBox.MinValue : value;
                textBox.Text = value.ToString() + "%";
            }
            else
            {
                textBox.Text = textBox.LastState;
                MessageBox.Show("Введены недопустимые значения");
            }
        }

        private void BackButton_Click(object sender, EventArgs e) => this.Close();



        private void SaveButton_Click(object sender, EventArgs e)
        {


            Properties.Settings.Default["Setting1"] = tbSetting1.Text.Substring(0, tbSetting1.Text.Length-1);
            Properties.Settings.Default["Setting2"] = tbSetting2.Text;
            Properties.Settings.Default["Setting3"] = tbSetting3.Text;
            Properties.Settings.Default["Setting4"] = tbSetting4.Text;
            Properties.Settings.Default.Save();
            this.Close();

        }



    }
}
