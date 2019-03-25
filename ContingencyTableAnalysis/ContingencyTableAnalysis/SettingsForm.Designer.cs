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
            this.tbSetting1 = new ContingencyTableAnalysis.InputDataTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSetting2 = new ContingencyTableAnalysis.InputDataTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSetting3 = new ContingencyTableAnalysis.InputDataTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSetting4 = new ContingencyTableAnalysis.InputDataTextBox();
            this.line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SaveButton.Location = new System.Drawing.Point(23, 452);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(200, 40);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BackButton.Location = new System.Drawing.Point(233, 452);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(200, 40);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Отмена";
            this.BackButton.UseSelectable = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "- доверительная вероятность доверительного интервала.";
            // 
            // tbSetting1
            // 
            this.tbSetting1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetting1.Location = new System.Drawing.Point(23, 94);
            this.tbSetting1.Name = "tbSetting1";
            this.tbSetting1.Size = new System.Drawing.Size(78, 26);
            this.tbSetting1.TabIndex = 2;
            this.tbSetting1.Text = "100.00%";
            this.tbSetting1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSetting1.Validating += new System.ComponentModel.CancelEventHandler(this.inputDataTextBox1_Validating);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(128, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 65);
            this.label2.TabIndex = 4;
            this.label2.Text = "- значение в одной из ячеек, при котором используется критерий Хи-квадрат с попра" +
    "вкой Йейтса.";
            // 
            // tbSetting2
            // 
            this.tbSetting2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetting2.Location = new System.Drawing.Point(23, 164);
            this.tbSetting2.Name = "tbSetting2";
            this.tbSetting2.Size = new System.Drawing.Size(78, 26);
            this.tbSetting2.TabIndex = 5;
            this.tbSetting2.Text = "100";
            this.tbSetting2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(128, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 65);
            this.label3.TabIndex = 6;
            this.label3.Text = "- значение в одной из ячеек, при котором используется точный критерий Фишера.";
            // 
            // tbSetting3
            // 
            this.tbSetting3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetting3.Location = new System.Drawing.Point(23, 258);
            this.tbSetting3.Name = "tbSetting3";
            this.tbSetting3.Size = new System.Drawing.Size(78, 26);
            this.tbSetting3.TabIndex = 7;
            this.tbSetting3.Text = "100";
            this.tbSetting3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(128, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 65);
            this.label4.TabIndex = 8;
            this.label4.Text = "- количество уникальных значений столбца, при превышении которого признак считает" +
    "ся количественным.";
            // 
            // tbSetting4
            // 
            this.tbSetting4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetting4.Location = new System.Drawing.Point(23, 336);
            this.tbSetting4.Name = "tbSetting4";
            this.tbSetting4.Size = new System.Drawing.Size(78, 26);
            this.tbSetting4.TabIndex = 9;
            this.tbSetting4.Text = "100";
            this.tbSetting4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1.Location = new System.Drawing.Point(23, 152);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(410, 2);
            this.line1.TabIndex = 10;
            // 
            // line2
            // 
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line2.Location = new System.Drawing.Point(23, 239);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(410, 2);
            this.line2.TabIndex = 11;
            // 
            // line3
            // 
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line3.Location = new System.Drawing.Point(23, 317);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(410, 2);
            this.line3.TabIndex = 12;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 515);
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
            this.Name = "SettingsForm";
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