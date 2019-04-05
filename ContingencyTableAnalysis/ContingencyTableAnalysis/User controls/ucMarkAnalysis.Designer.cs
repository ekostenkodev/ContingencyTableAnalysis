namespace ContingencyTableAnalysis.User_controls
{
    partial class ucMarkAnalysis
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AnalysisLabel = new System.Windows.Forms.Label();
            this.ucQuickAnalysis1 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.MarkVariationComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackBtn.Location = new System.Drawing.Point(4, 4);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(130, 53);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Назад";
            this.BackBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Признаки:";
            // 
            // AnalysisLabel
            // 
            this.AnalysisLabel.AutoSize = true;
            this.AnalysisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalysisLabel.Location = new System.Drawing.Point(141, 18);
            this.AnalysisLabel.Name = "AnalysisLabel";
            this.AnalysisLabel.Size = new System.Drawing.Size(107, 25);
            this.AnalysisLabel.TabIndex = 10;
            this.AnalysisLabel.Text = "Признаки:";
            // 
            // ucQuickAnalysis1
            // 
            this.ucQuickAnalysis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(35)))));
            this.ucQuickAnalysis1.Location = new System.Drawing.Point(4, 100);
            this.ucQuickAnalysis1.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis1.Name = "ucQuickAnalysis1";
            this.ucQuickAnalysis1.Size = new System.Drawing.Size(927, 697);
            this.ucQuickAnalysis1.TabIndex = 8;
            this.ucQuickAnalysis1.UseSelectable = true;
            // 
            // MarkVariationComboBox
            // 
            this.MarkVariationComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MarkVariationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkVariationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkVariationComboBox.FormattingEnabled = true;
            this.MarkVariationComboBox.Location = new System.Drawing.Point(112, 64);
            this.MarkVariationComboBox.Name = "MarkVariationComboBox";
            this.MarkVariationComboBox.Size = new System.Drawing.Size(819, 31);
            this.MarkVariationComboBox.TabIndex = 11;
            this.MarkVariationComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MarkVariationComboBox_DrawItem);
            this.MarkVariationComboBox.SelectedIndexChanged += new System.EventHandler(this.MarkVariationComboBox_SelectedIndexChanged);
            // 
            // ucMarkAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MarkVariationComboBox);
            this.Controls.Add(this.AnalysisLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucQuickAnalysis1);
            this.Controls.Add(this.BackBtn);
            this.Name = "ucMarkAnalysis";
            this.Size = new System.Drawing.Size(977, 799);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private ucQuickAnalysis ucQuickAnalysis1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AnalysisLabel;
        private System.Windows.Forms.ComboBox MarkVariationComboBox;
    }
}
