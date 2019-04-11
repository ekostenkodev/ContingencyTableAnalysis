namespace ContingencyTableAnalysis
{
    partial class ucDataCreation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dc_addColumn = new System.Windows.Forms.Button();
            this.DataCreationGrid = new MetroFramework.Controls.MetroGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataCreationGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dc_addColumn
            // 
            this.dc_addColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.dc_addColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.dc_addColumn.FlatAppearance.BorderSize = 0;
            this.dc_addColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dc_addColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dc_addColumn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dc_addColumn.Location = new System.Drawing.Point(0, 0);
            this.dc_addColumn.Margin = new System.Windows.Forms.Padding(4);
            this.dc_addColumn.Name = "dc_addColumn";
            this.dc_addColumn.Size = new System.Drawing.Size(188, 44);
            this.dc_addColumn.TabIndex = 5;
            this.dc_addColumn.Text = "Добавить признак";
            this.dc_addColumn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dc_addColumn.UseVisualStyleBackColor = false;
            this.dc_addColumn.Click += new System.EventHandler(this.dc_addColumn_Click);
            // 
            // DataCreationGrid
            // 
            this.DataCreationGrid.AllowUserToResizeRows = false;
            this.DataCreationGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataCreationGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataCreationGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataCreationGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataCreationGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DataCreationGrid.ColumnHeadersHeight = 40;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataCreationGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.DataCreationGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataCreationGrid.EnableHeadersVisualStyles = false;
            this.DataCreationGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataCreationGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataCreationGrid.Location = new System.Drawing.Point(0, 44);
            this.DataCreationGrid.Name = "DataCreationGrid";
            this.DataCreationGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataCreationGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DataCreationGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataCreationGrid.RowTemplate.Height = 24;
            this.DataCreationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataCreationGrid.Size = new System.Drawing.Size(1020, 700);
            this.DataCreationGrid.Style = MetroFramework.MetroColorStyle.Red;
            this.DataCreationGrid.TabIndex = 6;
            this.DataCreationGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataCreationGrid_CellMouseClick);
            this.DataCreationGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataCreationGrid_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dc_addColumn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 44);
            this.panel1.TabIndex = 7;
            // 
            // ucDataCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataCreationGrid);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDataCreation";
            this.Size = new System.Drawing.Size(1020, 747);
            ((System.ComponentModel.ISupportInitialize)(this.DataCreationGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dc_addColumn;
        public MetroFramework.Controls.MetroGrid DataCreationGrid;
        private System.Windows.Forms.Panel panel1;
    }
}
