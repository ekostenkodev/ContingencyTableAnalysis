﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContingencyTableAnalysis
{
    public partial class ucQuickAnalysis : MetroFramework.Controls.MetroUserControl
    {
        private Label[] labelRows;
        private Label[] labelColumns;
        private InputDataTextBox[,] textBoxes = new InputDataTextBox[2,2];

        event TextBoxUpdate textBoxUpdate = delegate { };


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

        private void changeRows(int index) => labelRows[index].Text =((int) (textBoxes[index, 0].Value + textBoxes[index, 1].Value)).ToString();
        private void changeColumns(int index) => labelColumns[index].Text = ((int)(textBoxes[0, index].Value + textBoxes[1, index].Value)).ToString();

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
                sum += (int)item.Value;
            }
            labelABCD.Text = sum.ToString();

        }

        public void SetTextBoxes(int[,] values, bool enabled)
        {
            textBoxes[0, 0].Text = values[0, 0].ToString();
            textBoxes[0, 1].Text = values[0, 1].ToString();
            textBoxes[1, 0].Text = values[1, 0].ToString();
            textBoxes[1, 1].Text = values[1, 1].ToString();

            textBoxes[0, 0].Enabled = enabled;
            textBoxes[0, 1].Enabled = enabled;
            textBoxes[1, 0].Enabled = enabled;
            textBoxes[1, 1].Enabled = enabled;

        }

        public void SetAnalysisStrings(AnalysisStrings values)
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

        public void AddTextBoxSubscriber(TextBoxUpdate update)
        {
            textBoxUpdate += update;
        }

        private void TextBoxChanged(object sender, EventArgs e)
        {
            InputDataTextBox textBox = (InputDataTextBox)sender;
           
            for (int row = 0; row < textBoxes.GetLength(0); row++)
            {
                for (int column = 0; column < textBoxes.GetLength(1); column++)
                {
                    if (textBox.Equals(textBoxes[row, column]))
                    {
                        UpdateLabels(row, column);
                        //
                        int[,] textBoxValues = new int[2, 2];
                        textBoxValues[0, 0] = (int)textBoxes[0, 0].Value;
                        textBoxValues[0, 1] = (int)textBoxes[0, 1].Value;
                        textBoxValues[1, 0] = (int)textBoxes[1, 0].Value;
                        textBoxValues[1, 1] = (int)textBoxes[1, 1].Value;

                        /* в linq :
                            
                            int[,] textBoxValues = textBoxes.Cast<InputDataTextBox>()
                            .Select((x, i) => new { x?.Value, i })
                            .Aggregate(
                              new int[textBoxes.GetLength(0), textBoxes.GetLength(1)],
                              (accum, item) =>
                              {
                                  accum[item.i / textBoxes.GetLength(1), item.i % textBoxes.GetLength(1)] = (int)item.Value.GetValueOrDefault();
                                  return accum;
                              });*/
                        //
                        textBoxUpdate.Invoke(textBoxValues);
                    }
                }
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
            
            var calculations = Calculations.GetResults(checkedParameters, userArguments);
            foreach (var item in calculations)
            {
                string result = "";
                foreach (var results in item.Value)
                {
                    result += results.ToString() + " ";
                }
            }

            ResultForm resultForm = new ResultForm(calculations);
            resultForm.ShowDialog();

        }
    }

    


}
