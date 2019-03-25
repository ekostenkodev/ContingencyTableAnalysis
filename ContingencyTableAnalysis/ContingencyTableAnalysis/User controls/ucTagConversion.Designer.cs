namespace ContingencyTableAnalysis.User_controls
{
    partial class ucTagConversion
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
            this.StartCalcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartCalcBtn
            // 
            this.StartCalcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartCalcBtn.Location = new System.Drawing.Point(274, 449);
            this.StartCalcBtn.Name = "StartCalcBtn";
            this.StartCalcBtn.Size = new System.Drawing.Size(182, 47);
            this.StartCalcBtn.TabIndex = 0;
            this.StartCalcBtn.Text = "Расчитать";
            this.StartCalcBtn.UseVisualStyleBackColor = true;
            this.StartCalcBtn.Click += new System.EventHandler(this.StartCalcBtn_Click);
            // 
            // ucTagConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartCalcBtn);
            this.Name = "ucTagConversion";
            this.Size = new System.Drawing.Size(694, 523);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartCalcBtn;
    }
}
