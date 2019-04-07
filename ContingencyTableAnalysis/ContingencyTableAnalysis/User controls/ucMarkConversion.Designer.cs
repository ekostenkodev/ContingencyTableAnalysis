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
            this.PanelListAll = new System.Windows.Forms.Panel();
            this.LabelAll = new System.Windows.Forms.Label();
            this.LabelC = new System.Windows.Forms.Label();
            this.PanelRowColumnList = new System.Windows.Forms.Panel();
            this.PanelColumns = new System.Windows.Forms.Panel();
            this.PanelRows = new System.Windows.Forms.Panel();
            this.ValueTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.PanelScroll = new System.Windows.Forms.Panel();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.PanelValueTextBox = new System.Windows.Forms.Panel();
            this.ValueTextBox = new ContingencyTableAnalysis.InputDataTextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.AnalysisLabel = new System.Windows.Forms.Label();
            this.AnalysisNamePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelValue = new System.Windows.Forms.Panel();
            this.PanelListAll.SuspendLayout();
            this.PanelRowColumnList.SuspendLayout();
            this.PanelColumns.SuspendLayout();
            this.PanelRows.SuspendLayout();
            this.PanelScroll.SuspendLayout();
            this.PanelValueTextBox.SuspendLayout();
            this.AnalysisNamePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListRows
            // 
            this.ListRows.AllowDrop = true;
            this.ListRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListRows.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListRows.FormattingEnabled = true;
            this.ListRows.ItemHeight = 25;
            this.ListRows.Location = new System.Drawing.Point(0, 50);
            this.ListRows.Name = "ListRows";
            this.ListRows.Size = new System.Drawing.Size(300, 190);
            this.ListRows.TabIndex = 3;
            this.ListRows.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.List_drawItem);
            this.ListRows.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_dragDrop);
            this.ListRows.DragOver += new System.Windows.Forms.DragEventHandler(this.List_dragOver);
            this.ListRows.MouseDown += new System.Windows.Forms.MouseEventHandler(this.List_mouseDown);
            // 
            // ListColumns
            // 
            this.ListColumns.AllowDrop = true;
            this.ListColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListColumns.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListColumns.FormattingEnabled = true;
            this.ListColumns.ItemHeight = 25;
            this.ListColumns.Location = new System.Drawing.Point(0, 50);
            this.ListColumns.Name = "ListColumns";
            this.ListColumns.Size = new System.Drawing.Size(300, 190);
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
            this.StartCalcBtn.Location = new System.Drawing.Point(15, 683);
            this.StartCalcBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartCalcBtn.Name = "StartCalcBtn";
            this.StartCalcBtn.Size = new System.Drawing.Size(202, 53);
            this.StartCalcBtn.TabIndex = 5;
            this.StartCalcBtn.Text = "Далее";
            this.StartCalcBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.StartCalcBtn.UseVisualStyleBackColor = false;
            this.StartCalcBtn.Click += new System.EventHandler(this.StartCalcBtn_Click);
            // 
            // ListAllMark
            // 
            this.ListAllMark.AllowDrop = true;
            this.ListAllMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListAllMark.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListAllMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListAllMark.FormattingEnabled = true;
            this.ListAllMark.ItemHeight = 25;
            this.ListAllMark.Location = new System.Drawing.Point(0, 50);
            this.ListAllMark.Name = "ListAllMark";
            this.ListAllMark.Size = new System.Drawing.Size(300, 440);
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
            this.LabelR.Size = new System.Drawing.Size(300, 50);
            this.LabelR.TabIndex = 6;
            this.LabelR.Text = "Строки";
            this.LabelR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelListAll
            // 
            this.PanelListAll.Controls.Add(this.ListAllMark);
            this.PanelListAll.Controls.Add(this.LabelAll);
            this.PanelListAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelListAll.Location = new System.Drawing.Point(0, 0);
            this.PanelListAll.Name = "PanelListAll";
            this.PanelListAll.Size = new System.Drawing.Size(300, 490);
            this.PanelListAll.TabIndex = 7;
            // 
            // LabelAll
            // 
            this.LabelAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAll.Location = new System.Drawing.Point(0, 0);
            this.LabelAll.Name = "LabelAll";
            this.LabelAll.Size = new System.Drawing.Size(300, 50);
            this.LabelAll.TabIndex = 8;
            this.LabelAll.Text = "Перечень признаков (столбцов) набора данных\r\n";
            this.LabelAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelC
            // 
            this.LabelC.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelC.Location = new System.Drawing.Point(0, 0);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(300, 50);
            this.LabelC.TabIndex = 8;
            this.LabelC.Text = "Столбцы";
            this.LabelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRowColumnList
            // 
            this.PanelRowColumnList.Controls.Add(this.PanelColumns);
            this.PanelRowColumnList.Controls.Add(this.PanelRows);
            this.PanelRowColumnList.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRowColumnList.Location = new System.Drawing.Point(320, 0);
            this.PanelRowColumnList.Name = "PanelRowColumnList";
            this.PanelRowColumnList.Size = new System.Drawing.Size(300, 490);
            this.PanelRowColumnList.TabIndex = 9;
            // 
            // PanelColumns
            // 
            this.PanelColumns.Controls.Add(this.ListColumns);
            this.PanelColumns.Controls.Add(this.LabelC);
            this.PanelColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelColumns.Location = new System.Drawing.Point(0, 240);
            this.PanelColumns.Name = "PanelColumns";
            this.PanelColumns.Size = new System.Drawing.Size(300, 240);
            this.PanelColumns.TabIndex = 11;
            // 
            // PanelRows
            // 
            this.PanelRows.Controls.Add(this.ListRows);
            this.PanelRows.Controls.Add(this.LabelR);
            this.PanelRows.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRows.Location = new System.Drawing.Point(0, 0);
            this.PanelRows.Name = "PanelRows";
            this.PanelRows.Size = new System.Drawing.Size(300, 240);
            this.PanelRows.TabIndex = 10;
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
            // PanelScroll
            // 
            this.PanelScroll.Controls.Add(this.maxValueLabel);
            this.PanelScroll.Controls.Add(this.ValueTrackBar);
            this.PanelScroll.Controls.Add(this.minValueLabel);
            this.PanelScroll.Controls.Add(this.PanelValueTextBox);
            this.PanelScroll.Enabled = false;
            this.PanelScroll.Location = new System.Drawing.Point(10, 39);
            this.PanelScroll.Name = "PanelScroll";
            this.PanelScroll.Size = new System.Drawing.Size(824, 49);
            this.PanelScroll.TabIndex = 11;
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
            this.ValueLabel.Location = new System.Drawing.Point(5, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(197, 25);
            this.ValueLabel.TabIndex = 12;
            this.ValueLabel.Text = "*Признак не выбран";
            // 
            // AnalysisLabel
            // 
            this.AnalysisLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnalysisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalysisLabel.Location = new System.Drawing.Point(0, 0);
            this.AnalysisLabel.Name = "AnalysisLabel";
            this.AnalysisLabel.Size = new System.Drawing.Size(837, 47);
            this.AnalysisLabel.TabIndex = 13;
            this.AnalysisLabel.Text = "Анализ";
            this.AnalysisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnalysisNamePanel
            // 
            this.AnalysisNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(183)))), ((int)(((byte)(200)))));
            this.AnalysisNamePanel.Controls.Add(this.AnalysisLabel);
            this.AnalysisNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnalysisNamePanel.Location = new System.Drawing.Point(0, 0);
            this.AnalysisNamePanel.Name = "AnalysisNamePanel";
            this.AnalysisNamePanel.Size = new System.Drawing.Size(837, 47);
            this.AnalysisNamePanel.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelListAll);
            this.panel1.Controls.Add(this.PanelRowColumnList);
            this.panel1.Location = new System.Drawing.Point(5, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 490);
            this.panel1.TabIndex = 15;
            // 
            // PanelValue
            // 
            this.PanelValue.BackColor = System.Drawing.Color.White;
            this.PanelValue.Controls.Add(this.ValueLabel);
            this.PanelValue.Controls.Add(this.PanelScroll);
            this.PanelValue.Location = new System.Drawing.Point(5, 566);
            this.PanelValue.Name = "PanelValue";
            this.PanelValue.Size = new System.Drawing.Size(829, 100);
            this.PanelValue.TabIndex = 16;
            // 
            // ucMarkConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelValue);
            this.Controls.Add(this.StartCalcBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnalysisNamePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMarkConversion";
            this.Size = new System.Drawing.Size(837, 804);
            this.PanelListAll.ResumeLayout(false);
            this.PanelRowColumnList.ResumeLayout(false);
            this.PanelColumns.ResumeLayout(false);
            this.PanelRows.ResumeLayout(false);
            this.PanelScroll.ResumeLayout(false);
            this.PanelValueTextBox.ResumeLayout(false);
            this.PanelValueTextBox.PerformLayout();
            this.AnalysisNamePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelValue.ResumeLayout(false);
            this.PanelValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ListRows;
        private System.Windows.Forms.ListBox ListColumns;
        private System.Windows.Forms.Button StartCalcBtn;
        private System.Windows.Forms.ListBox ListAllMark;
        private System.Windows.Forms.Label LabelR;
        private System.Windows.Forms.Panel PanelListAll;
        private System.Windows.Forms.Label LabelC;
        private System.Windows.Forms.Label LabelAll;
        private System.Windows.Forms.Panel PanelRowColumnList;
        private MetroFramework.Controls.MetroTrackBar ValueTrackBar;
        private System.Windows.Forms.Panel PanelScroll;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.Label minValueLabel;
        private System.Windows.Forms.Panel PanelValueTextBox;
        private InputDataTextBox ValueTextBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label AnalysisLabel;
        private System.Windows.Forms.Panel AnalysisNamePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelColumns;
        private System.Windows.Forms.Panel PanelRows;
        private System.Windows.Forms.Panel PanelValue;
    }
}
