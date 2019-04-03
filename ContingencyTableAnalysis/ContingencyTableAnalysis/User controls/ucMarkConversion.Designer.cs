namespace ContingencyTableAnalysis.User_controls
{
    partial class ucMarkConversion
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
            this.ListRows = new System.Windows.Forms.ListBox();
            this.ListColumns = new System.Windows.Forms.ListBox();
            this.StartCalcBtn = new System.Windows.Forms.Button();
            this.ListAllMark = new System.Windows.Forms.ListBox();
            this.LabelR = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelAll = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ValueTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.PanelValue = new System.Windows.Forms.Panel();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelValue.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListRows
            // 
            this.ListRows.AllowDrop = true;
            this.ListRows.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListRows.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListRows.FormattingEnabled = true;
            this.ListRows.ItemHeight = 25;
            this.ListRows.Location = new System.Drawing.Point(0, 30);
            this.ListRows.Name = "ListRows";
            this.ListRows.Size = new System.Drawing.Size(391, 154);
            this.ListRows.TabIndex = 3;
            this.ListRows.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.List_drawItem);
            this.ListRows.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_dragDrop);
            this.ListRows.DragOver += new System.Windows.Forms.DragEventHandler(this.List_dragOver);
            this.ListRows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.List_mouseDown);
            // 
            // ListColumns
            // 
            this.ListColumns.AllowDrop = true;
            this.ListColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListColumns.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListColumns.FormattingEnabled = true;
            this.ListColumns.ItemHeight = 25;
            this.ListColumns.Location = new System.Drawing.Point(0, 219);
            this.ListColumns.Name = "ListColumns";
            this.ListColumns.Size = new System.Drawing.Size(391, 154);
            this.ListColumns.TabIndex = 4;
            this.ListColumns.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.List_drawItem);
            this.ListColumns.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_dragDrop);
            this.ListColumns.DragOver += new System.Windows.Forms.DragEventHandler(this.List_dragOver);
            this.ListColumns.MouseDown += new System.Windows.Forms.MouseEventHandler(this.List_mouseDown);
            // 
            // StartCalcBtn
            // 
            this.StartCalcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.StartCalcBtn.FlatAppearance.BorderSize = 0;
            this.StartCalcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartCalcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartCalcBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartCalcBtn.Location = new System.Drawing.Point(354, 560);
            this.StartCalcBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartCalcBtn.Name = "StartCalcBtn";
            this.StartCalcBtn.Size = new System.Drawing.Size(200, 53);
            this.StartCalcBtn.TabIndex = 5;
            this.StartCalcBtn.Text = "Далее";
            this.StartCalcBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.StartCalcBtn.UseVisualStyleBackColor = false;
            this.StartCalcBtn.Click += new System.EventHandler(this.StartCalcBtn_Click);
            // 
            // ListAllMark
            // 
            this.ListAllMark.AllowDrop = true;
            this.ListAllMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListAllMark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ListAllMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListAllMark.FormattingEnabled = true;
            this.ListAllMark.ItemHeight = 25;
            this.ListAllMark.Location = new System.Drawing.Point(0, 54);
            this.ListAllMark.Name = "ListAllMark";
            this.ListAllMark.Size = new System.Drawing.Size(384, 329);
            this.ListAllMark.TabIndex = 1;
            this.ListAllMark.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListAllMark_MouseClick);
            this.ListAllMark.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.List_drawItem);
            this.ListAllMark.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_dragDrop);
            this.ListAllMark.DragOver += new System.Windows.Forms.DragEventHandler(this.List_dragOver);
            this.ListAllMark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.List_mouseDown);
            // 
            // LabelR
            // 
            this.LabelR.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelR.Location = new System.Drawing.Point(0, 0);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(391, 25);
            this.LabelR.TabIndex = 6;
            this.LabelR.Text = "label1";
            this.LabelR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListColumns);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ListRows);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelR);
            this.panel1.Location = new System.Drawing.Point(393, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 403);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 5);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelC
            // 
            this.LabelC.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelC.Location = new System.Drawing.Point(0, 189);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(391, 25);
            this.LabelC.TabIndex = 8;
            this.LabelC.Text = "label2";
            this.LabelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 5);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 5);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAll
            // 
            this.LabelAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAll.Location = new System.Drawing.Point(0, 0);
            this.LabelAll.Name = "LabelAll";
            this.LabelAll.Size = new System.Drawing.Size(384, 54);
            this.LabelAll.TabIndex = 8;
            this.LabelAll.Text = "Перечень признаков (столбцов) набора данных\r\n";
            this.LabelAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ListAllMark);
            this.panel2.Controls.Add(this.LabelAll);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 386);
            this.panel2.TabIndex = 9;
            // 
            // ValueTrackBar
            // 
            this.ValueTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.ValueTrackBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ValueTrackBar.Location = new System.Drawing.Point(202, 0);
            this.ValueTrackBar.Name = "ValueTrackBar";
            this.ValueTrackBar.Size = new System.Drawing.Size(331, 49);
            this.ValueTrackBar.TabIndex = 10;
            this.ValueTrackBar.Text = "metroTrackBar1";
            this.ValueTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ValueTrackBar_Scroll);
            // 
            // PanelValue
            // 
            this.PanelValue.Controls.Add(this.maxValueLabel);
            this.PanelValue.Controls.Add(this.ValueTrackBar);
            this.PanelValue.Controls.Add(this.minValueLabel);
            this.PanelValue.Controls.Add(this.panel4);
            this.PanelValue.Enabled = false;
            this.PanelValue.Location = new System.Drawing.Point(81, 441);
            this.PanelValue.Name = "PanelValue";
            this.PanelValue.Size = new System.Drawing.Size(703, 49);
            this.PanelValue.TabIndex = 11;
            // 
            // minValueLabel
            // 
            this.minValueLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.minValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minValueLabel.Location = new System.Drawing.Point(107, 0);
            this.minValueLabel.Name = "minValueLabel";
            this.minValueLabel.Size = new System.Drawing.Size(95, 49);
            this.minValueLabel.TabIndex = 13;
            this.minValueLabel.Text = "label4";
            this.minValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.maxValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxValueLabel.Location = new System.Drawing.Point(533, 0);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(95, 49);
            this.maxValueLabel.TabIndex = 14;
            this.maxValueLabel.Text = "label4";
            this.maxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueTextBox.Location = new System.Drawing.Point(0, 10);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(107, 30);
            this.ValueTextBox.TabIndex = 15;
            this.ValueTextBox.Text = "25";
            this.ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValueTextBox.TextChanged += new System.EventHandler(this.ValueTextBox_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ValueTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel4.Size = new System.Drawing.Size(107, 49);
            this.panel4.TabIndex = 16;
            // 
            // ucMarkConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelValue);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartCalcBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMarkConversion";
            this.Size = new System.Drawing.Size(925, 644);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelValue.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ListRows;
        private System.Windows.Forms.ListBox ListColumns;
        private System.Windows.Forms.Button StartCalcBtn;
        private System.Windows.Forms.ListBox ListAllMark;
        private System.Windows.Forms.Label LabelR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelC;
        private System.Windows.Forms.Label LabelAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTrackBar ValueTrackBar;
        private System.Windows.Forms.Panel PanelValue;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.Label minValueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Panel panel4;
    }
}
