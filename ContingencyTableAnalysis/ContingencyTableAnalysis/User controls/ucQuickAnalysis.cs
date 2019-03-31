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
    public partial class ucQuickAnalysis : MetroFramework.Controls.MetroUserControl
    {
        private Label[] labelRows;
        private Label[] labelColumns;
        private TextBox[,] textBoxes = new TextBox[2,2];

        

        public ucQuickAnalysis()
        {
            InitializeComponent();
            labelRows = new[] { labelAB, labelCD };
            labelColumns = new[] { labelAC, labelBD };

            textBoxes[0, 0] = tbA;
            textBoxes[0, 1] = tbB;
            textBoxes[1, 0] = tbC;
            textBoxes[1, 1] = tbD;
            
            
        }

        private void changeRows(int index) => labelRows[index].Text = (Int32.Parse(textBoxes[index, 0].Text) + Int32.Parse(textBoxes[index, 1].Text)).ToString();
        private void changeColumns(int index) => labelColumns[index].Text = (Int32.Parse(textBoxes[0, index].Text) + Int32.Parse(textBoxes[1, index].Text)).ToString();

        public void UpdateLabels(int row, int column)
        {
            changeColumns(column);
            changeRows(row);
            changeSum();
        }
        private void changeSum()
        {
            int sum = 0;
            foreach (var item in textBoxes)
            {
                sum += int.Parse(item.Text);
            }
            labelABCD.Text = sum.ToString();

        }

        public void SetQAStrings(QAStrings values)
        {

            label1.Text = values.Labels[0];
            label2.Text = values.Labels[1];
            label3.Text = values.Labels[2];
            label4.Text = values.Labels[3];
            label5.Text = values.Labels[4];
            label6.Text = values.Labels[5];


            ParametersCheckBox.Items.Clear();


            foreach (var item in values.Parameters)
            {
                ParametersCheckBox.Items.Add(item);
            }

        }

        

        private void TextBoxChanged(object sender, EventArgs e)
        {
            InputDataTextBox textBox = (InputDataTextBox)sender;
            if (Int32.TryParse(textBox.Text,out int value))
            {
                for (int row = 0; row < textBoxes.GetLength(0); row++)
                {
                    for (int column = 0; column < textBoxes.GetLength(1); column++)
                    {
                        if (textBox.Equals(textBoxes[row, column]))
                        {
                            UpdateLabels(row, column);
                        }
                    }
                }
                
                textBox.LastState = textBox.Text;
            }
            else
            {
                if (String.IsNullOrEmpty(textBox.Text))
                    return;

                int cursor = textBox.SelectionStart-1;
                textBox.Text = textBox.LastState;
                textBox.SelectionStart = cursor;
                
            }
        }

        private void tbClearClick(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = string.Empty;
            }
        }

        private void tbLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "0";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<string> checkedParameters = new List<string>();
            foreach (ListViewItem item in ParametersCheckBox.CheckedItems) 
            {
                checkedParameters.Add(item.Text);
            }

            double[] userArguments = new[] { tbA, tbB, tbC, tbD }
                                .Select(tb => Double.Parse(tb.Text))
                                .ToArray();
            
            var calculations = Calculations.GetCalculations(checkedParameters, userArguments);
            foreach (var item in calculations)
            {
                string result = "";
                foreach (var results in item.Value)
                {
                    result += results.ToString() + " ";
                }
                Console.WriteLine(item.Key + " = " + result);
            }

            ResultForm resultForm = new ResultForm(calculations);
            resultForm.ShowDialog();

        }
    }

    public class InputDataTextBox : TextBox
    {
        public string LastState;
        public double MaxValue;
        public double MinValue;

    }


}
