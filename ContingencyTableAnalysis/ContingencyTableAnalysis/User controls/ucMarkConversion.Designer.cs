namespace ContingencyTableAnalysis
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
            this.PanelRowColumnList = new System.Windows.Forms.Panel();
            this.space3 = new System.Windows.Forms.Label();
            this.LabelC = new System.Windows.Forms.Label();
            this.space2 = new System.Windows.Forms.Label();
            this.space1 = new System.Windows.Forms.Label();
            this.LabelAll = new System.Windows.Forms.Label();
            this.PanelListAll = new System.Windows.Forms.Panel();
            this.ValueTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.PanelValue = new System.Windows.Forms.Panel();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.PanelValueTextBox = new System.Windows.Forms.Panel();
            this.ValueTextBox = new ContingencyTableAnalysis.InputDataTextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.PanelRowColumnList.SuspendLayout();
            this.PanelListAll.SuspendLayout();
            this.PanelValue.SuspendLayout();
            this.PanelValueTextBox.SuspendLayout();
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
            this.LabelR.Text = "Строки";
            this.LabelR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRowColumnList
            // 
            this.PanelRowColumnList.Controls.Add(this.ListColumns);
            this.PanelRowColumnList.Controls.Add(this.space3);
            this.PanelRowColumnList.Controls.Add(this.LabelC);
            this.PanelRowColumnList.Controls.Add(this.space2);
            this.PanelRowColumnList.Controls.Add(this.ListRows);
            this.PanelRowColumnList.Controls.Add(this.space1);
            this.PanelRowColumnList.Controls.Add(this.LabelR);
            this.PanelRowColumnList.Location = new System.Drawing.Point(393, 3);
            this.PanelRowColumnList.Name = "PanelRowColumnList";
            this.PanelRowColumnList.Size = new System.Drawing.Size(391, 403);
            this.PanelRowColumnList.TabIndex = 7;
            // 
            // space3
            // 
            this.space3.Dock = System.Windows.Forms.DockStyle.Top;
            this.space3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.space3.Location = new System.Drawing.Point(0, 214);
            this.space3.Name = "space3";
            this.space3.Size = new System.Drawing.Size(391, 5);
            this.space3.TabIndex = 9;
            this.space3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelC
            // 
            this.LabelC.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelC.Location = new System.Drawing.Point(0, 189);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(391, 25);
            this.LabelC.TabIndex = 8;
            this.LabelC.Text = "Столбцы";
            this.LabelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space2
            // 
            this.space2.Dock = System.Windows.Forms.DockStyle.Top;
            this.space2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.space2.Location = new System.Drawing.Point(0, 184);
            this.space2.Name = "space2";
            this.space2.Size = new System.Drawing.Size(391, 5);
            this.space2.TabIndex = 10;
            this.space2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space1
            // 
            this.space1.Dock = System.Windows.Forms.DockStyle.Top;
            this.space1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.space1.Location = new System.Drawing.Point(0, 25);
            this.space1.Name = "space1";
            this.space1.Size = new System.Drawing.Size(391, 5);
            this.space1.TabIndex = 11;
            this.space1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // PanelListAll
            // 
            this.PanelListAll.Controls.Add(this.ListAllMark);
            this.PanelListAll.Controls.Add(this.LabelAll);
            this.PanelListAll.Location = new System.Drawing.Point(3, 3);
            this.PanelListAll.Name = "PanelListAll";
            this.PanelListAll.Size = new System.Drawing.Size(384, 386);
            this.PanelListAll.TabIndex = 9;
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
            this.PanelValue.Controls.Add(this.PanelValueTextBox);
            this.PanelValue.Enabled = false;
            this.PanelValue.Location = new System.Drawing.Point(3, 446);
            this.PanelValue.Name = "PanelValue";
            this.PanelValue.Size = new System.Drawing.Size(870, 49);
            this.PanelValue.TabIndex = 11;
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.maxValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxValueLabel.Location = new System.Drawing.Point(533, 0);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(95, 49);
            this.maxValueLabel.TabIndex = 14;
            this.maxValueLabel.Text = "max";
            this.maxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minValueLabel
            // 
            this.minValueLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.minValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minValueLabel.Location = new System.Drawing.Point(107, 0);
            this.minValueLabel.Name = "minValueLabel";
            this.minValueLabel.Size = new System.Drawing.Size(95, 49);
            this.minValueLabel.TabIndex = 13;
            this.minValueLabel.Text = "min";
            this.minValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelValueTextBox
            // 
            this.PanelValueTextBox.Controls.Add(this.ValueTextBox);
            this.PanelValueTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelValueTextBox.Location = new System.Drawing.Point(0, 0);
            this.PanelValueTextBox.Name = "PanelValueTextBox";
            this.PanelValueTextBox.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.PanelValueTextBox.Size = new System.Drawing.Size(107, 49);
            this.PanelValueTextBox.TabIndex = 16;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueTextBox.IntValidate = true;
            this.ValueTextBox.Location = new System.Drawing.Point(0, 10);
            this.ValueTextBox.MaxValue = null;
            this.ValueTextBox.MinValue = null;
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(107, 30);
            this.ValueTextBox.TabIndex = 15;
            this.ValueTextBox.Text = "25";
            this.ValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValueTextBox.Value = 25D;
            this.ValueTextBox.Validated += new System.EventHandler(this.ValueTextBox_Validated);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueLabel.Location = new System.Drawing.Point(-2, 418);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(197, 25);
            this.ValueLabel.TabIndex = 12;
            this.ValueLabel.Text = "*Признак не выбран";
            // 
            // ucMarkConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.PanelValue);
            this.Controls.Add(this.PanelListAll);
            this.Controls.Add(this.PanelRowColumnList);
            this.Controls.Add(this.StartCalcBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMarkConversion";
            this.Size = new System.Drawing.Size(925, 644);
            this.PanelRowColumnList.ResumeLayout(false);
            this.PanelListAll.ResumeLayout(false);
            this.PanelValue.ResumeLayout(false);
            this.PanelValueTextBox.ResumeLayout(false);
            this.PanelValueTextBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListRows;
        private System.Windows.Forms.ListBox ListColumns;
        private System.Windows.Forms.Button StartCalcBtn;
        private System.Windows.Forms.ListBox ListAllMark;
        private System.Windows.Forms.Label LabelR;
        private System.Windows.Forms.Panel PanelRowColumnList;
        private System.Windows.Forms.Label LabelC;
        private System.Windows.Forms.Label LabelAll;
        private System.Windows.Forms.Label space3;
        private System.Windows.Forms.Label space2;
        private System.Windows.Forms.Label space1;
        private System.Windows.Forms.Panel PanelListAll;
        private MetroFramework.Controls.MetroTrackBar ValueTrackBar;
        private System.Windows.Forms.Panel PanelValue;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.Label minValueLabel;
        private System.Windows.Forms.Panel PanelValueTextBox;
        private InputDataTextBox ValueTextBox;
        private System.Windows.Forms.Label ValueLabel;
    }
}
