﻿namespace ContingencyTableAnalysis
{
    partial class ResultForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.ResultList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExitResultBtn = new System.Windows.Forms.Button();
            this.SaveResultBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultList
            // 
            this.ResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ResultList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ResultList.Location = new System.Drawing.Point(23, 63);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(454, 319);
            this.ResultList.TabIndex = 0;
            this.ResultList.UseCompatibleStateImageBehavior = false;
            this.ResultList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Параметр";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 150;
            // 
            // ExitResultBtn
            // 
            this.ExitResultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitResultBtn.Location = new System.Drawing.Point(347, 388);
            this.ExitResultBtn.Name = "ExitResultBtn";
            this.ExitResultBtn.Size = new System.Drawing.Size(130, 46);
            this.ExitResultBtn.TabIndex = 1;
            this.ExitResultBtn.Text = "Выйти";
            this.ExitResultBtn.UseVisualStyleBackColor = true;
            // 
            // SaveResultBtn
            // 
            this.SaveResultBtn.Image = global::ContingencyTableAnalysis.Properties.Resources.save_icon;
            this.SaveResultBtn.Location = new System.Drawing.Point(296, 388);
            this.SaveResultBtn.Name = "SaveResultBtn";
            this.SaveResultBtn.Size = new System.Drawing.Size(45, 46);
            this.SaveResultBtn.TabIndex = 2;
            this.SaveResultBtn.UseVisualStyleBackColor = true;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 448);
            this.Controls.Add(this.SaveResultBtn);
            this.Controls.Add(this.ExitResultBtn);
            this.Controls.Add(this.ResultList);
            this.Name = "ResultForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Результаты";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ResultList;
        private System.Windows.Forms.Button ExitResultBtn;
        private System.Windows.Forms.Button SaveResultBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}