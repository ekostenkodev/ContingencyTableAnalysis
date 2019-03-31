namespace ContingencyTableAnalysis.Forms
{
    partial class ChangeColumnNameForm
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
            this.cn_Save = new System.Windows.Forms.Button();
            this.ColumnNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cn_Save
            // 
            this.cn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.cn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cn_Save.FlatAppearance.BorderSize = 0;
            this.cn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cn_Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cn_Save.Location = new System.Drawing.Point(90, 122);
            this.cn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.cn_Save.Name = "cn_Save";
            this.cn_Save.Size = new System.Drawing.Size(180, 29);
            this.cn_Save.TabIndex = 5;
            this.cn_Save.Text = "Сохранить";
            this.cn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cn_Save.UseVisualStyleBackColor = false;
            this.cn_Save.Click += new System.EventHandler(this.cn_Save_Click);
            // 
            // ColumnNameTextBox
            // 
            this.ColumnNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnNameTextBox.Location = new System.Drawing.Point(23, 79);
            this.ColumnNameTextBox.Name = "ColumnNameTextBox";
            this.ColumnNameTextBox.Size = new System.Drawing.Size(314, 30);
            this.ColumnNameTextBox.TabIndex = 7;
            // 
            // ChangeColumnNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 164);
            this.Controls.Add(this.ColumnNameTextBox);
            this.Controls.Add(this.cn_Save);
            this.Name = "ChangeColumnNameForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Изменить признак";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cn_Save;
        public System.Windows.Forms.TextBox ColumnNameTextBox;
    }
}