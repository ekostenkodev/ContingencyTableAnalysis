namespace ContingencyTableAnalysis
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.BackButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.tbSetting4 = new ContingencyTableAnalysis.InputDataTextBox();
            this.tbSetting3 = new ContingencyTableAnalysis.InputDataTextBox();
            this.tbSetting2 = new ContingencyTableAnalysis.InputDataTextBox();
            this.tbSetting1 = new ContingencyTableAnalysis.InputDataTextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SaveButton.Location = new System.Drawing.Point(31, 610);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(267, 49);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BackButton.Location = new System.Drawing.Point(311, 610);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(267, 49);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Отмена";
            this.BackButton.UseSelectable = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "- доверительная вероятность доверительного интервала(от 0,01% до 99,99%).";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(171, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 107);
            this.label2.TabIndex = 4;
            this.label2.Text = "- значение в одной из ячеек, при котором используется критерий Хи-квадрат с попра" +
    "вкой Йейтса(от 1 до 100).";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(171, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 80);
            this.label3.TabIndex = 6;
            this.label3.Text = "- значение в одной из ячеек, при котором используется точный критерий Фишера(от 1" +
    " до 100).";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(171, 471);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 106);
            this.label4.TabIndex = 8;
            this.label4.Text = "- количество уникальных значений столбца, при превышении которого признак считает" +
    "ся количественным(от 1 до 50).";
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1.Location = new System.Drawing.Point(31, 204);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(547, 2);
            this.line1.TabIndex = 10;
            // 
            // line2
            // 
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line2.Location = new System.Drawing.Point(31, 337);
            this.line2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(547, 2);
            this.line2.TabIndex = 11;
            // 
            // line3
            // 
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line3.Location = new System.Drawing.Point(31, 449);
            this.line3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(547, 2);
            this.line3.TabIndex = 12;
            // 
            // tbSetting4
            // 
            this.tbSetting4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetting4.Location = new System.Drawing.Point(31, 468);
            this.tbSetting4.Margin = new System.Windows.Forms.Padding(4);
            this.tbSetting4.MaxValue = null;
            this.tbSetting4.MinValue = null;
            this.tbSetting4.Name = "tbSetting4";
            this.tbSetting4.Size = new System.Drawing.Size(103, 30);
            this.tbSetting4.TabIndex = 9;
            this.tbSetting4.Text = "10";
            this.tbSetting4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSetting4.Value = 10D;
            this.tbSetting4.Validating += new System.ComponentModel.CancelEventHandler(this.tbSettingValidatingInt);
            // 
            // tbSetting3
            // 
            this.tbSetting3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetting3.Location = new System.Drawing.Point(31, 357);
            this.tbSetting3.Margin = new System.Windows.Forms.Padding(4);
            this.tbSetting3.MaxValue = null;
            this.tbSetting3.MinValue = null;
            this.tbSetting3.Name = "tbSetting3";
            this.tbSetting3.Size = new System.Drawing.Size(103, 30);
            this.tbSetting3.TabIndex = 7;
            this.tbSetting3.Text = "5";
            this.tbSetting3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSetting3.Value = 5D;
            this.tbSetting3.Validating += new System.ComponentModel.CancelEventHandler(this.tbSettingValidatingInt);
            // 
            // tbSetting2
            // 
            this.tbSetting2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetting2.Location = new System.Drawing.Point(31, 219);
            this.tbSetting2.Margin = new System.Windows.Forms.Padding(4);
            this.tbSetting2.MaxValue = null;
            this.tbSetting2.MinValue = null;
            this.tbSetting2.Name = "tbSetting2";
            this.tbSetting2.Size = new System.Drawing.Size(103, 30);
            this.tbSetting2.TabIndex = 5;
            this.tbSetting2.Text = "10";
            this.tbSetting2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSetting2.Value = 10D;
            this.tbSetting2.Validating += new System.ComponentModel.CancelEventHandler(this.tbSettingValidatingInt);
            // 
            // tbSetting1
            // 
            this.tbSetting1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetting1.Location = new System.Drawing.Point(31, 116);
            this.tbSetting1.Margin = new System.Windows.Forms.Padding(4);
            this.tbSetting1.MaxValue = null;
            this.tbSetting1.MinValue = null;
            this.tbSetting1.Name = "tbSetting1";
            this.tbSetting1.Size = new System.Drawing.Size(103, 30);
            this.tbSetting1.TabIndex = 2;
            this.tbSetting1.Text = "95";
            this.tbSetting1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSetting1.Value = 95D;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 683);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.tbSetting4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSetting3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSetting2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSetting1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroButton BackButton;
        private InputDataTextBox tbSetting1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private InputDataTextBox tbSetting2;
        private System.Windows.Forms.Label label3;
        private InputDataTextBox tbSetting3;
        private System.Windows.Forms.Label label4;
        private InputDataTextBox tbSetting4;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line3;
    }
}