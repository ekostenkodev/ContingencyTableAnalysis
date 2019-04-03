using System;
using System.Windows.Forms;

namespace ContingencyTableAnalysis
{
    public class InputDataTextBox : TextBox
    {
        public string LastState;
        public double Value { get; set; }
        public double? MaxValue { get; set; }
        public double? MinValue { get; set; }

        public InputDataTextBox()
        {
            TextChanged += TextChangedCustom;
            Leave += TextLeave;
            Click += TextClearClick;
        }

        public void TextLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "0";
            }
        }

        private void TextClearClick(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Equals("0"))
            {
                textBox.Text = string.Empty;
            }
        }

        private void TextChangedCustom(object sender, EventArgs e)
        {
            if (Double.TryParse(this.Text, out double value))
            {

                if (MaxValue.HasValue && value > MaxValue)
                {
                    MessageBox.Show("Значение слишком велико");
                    Value = MaxValue.Value;
                }
                else if (MinValue.HasValue && value < MinValue)
                {
                    MessageBox.Show("Значение слишком мало");
                    Value = MinValue.Value;
                }
                else
                {
                    Value = value;
                }
                Text = Value.ToString();
                LastState = Value.ToString();

            }
            else
            {
                if (String.IsNullOrEmpty(this.Text))
                {
                    Value = 0;
                    LastState = "";
                    return;
                }

                int cursor = this.SelectionStart - 1;
                this.Text = this.LastState;
                this.SelectionStart = cursor;

            }
        }


    }
}
