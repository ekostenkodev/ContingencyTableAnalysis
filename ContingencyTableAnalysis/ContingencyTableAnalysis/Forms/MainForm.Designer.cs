namespace ContingencyTableAnalysis
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelQuickAnalysis = new System.Windows.Forms.Panel();
            this.ucQuickTabPanel = new ContingencyTableAnalysis.ucQuickTabPanel();
            this.PanelDataCreation = new System.Windows.Forms.Panel();
            this.ucDataCreation1 = new ContingencyTableAnalysis.ucDataCreation();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ucMenuBar1 = new ContingencyTableAnalysis.User_controls.ucMenuBar();
            this.PanelQuickAnalysis.SuspendLayout();
            this.PanelDataCreation.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelQuickAnalysis
            // 
            this.PanelQuickAnalysis.Controls.Add(this.ucQuickTabPanel);
            this.PanelQuickAnalysis.Location = new System.Drawing.Point(227, 102);
            this.PanelQuickAnalysis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelQuickAnalysis.Name = "PanelQuickAnalysis";
            this.PanelQuickAnalysis.Size = new System.Drawing.Size(1019, 740);
            this.PanelQuickAnalysis.TabIndex = 1;
            // 
            // ucQuickTabPanel
            // 
            this.ucQuickTabPanel.BackColor = System.Drawing.Color.White;
            this.ucQuickTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuickTabPanel.Location = new System.Drawing.Point(0, 0);
            this.ucQuickTabPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucQuickTabPanel.Name = "ucQuickTabPanel";
            this.ucQuickTabPanel.Size = new System.Drawing.Size(1019, 740);
            this.ucQuickTabPanel.TabIndex = 0;
            // 
            // PanelDataCreation
            // 
            this.PanelDataCreation.Controls.Add(this.ucDataCreation1);
            this.PanelDataCreation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDataCreation.Location = new System.Drawing.Point(220, 74);
            this.PanelDataCreation.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDataCreation.Name = "PanelDataCreation";
            this.PanelDataCreation.Size = new System.Drawing.Size(1025, 770);
            this.PanelDataCreation.TabIndex = 1;
            // 
            // ucDataCreation1
            // 
            this.ucDataCreation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDataCreation1.Location = new System.Drawing.Point(0, 0);
            this.ucDataCreation1.Margin = new System.Windows.Forms.Padding(5);
            this.ucDataCreation1.Name = "ucDataCreation1";
            this.ucDataCreation1.Size = new System.Drawing.Size(1025, 770);
            this.ucDataCreation1.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.Controls.Add(this.ucMenuBar1);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(20, 74);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 770);
            this.MenuPanel.TabIndex = 3;
            // 
            // ucMenuBar1
            // 
            this.ucMenuBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.ucMenuBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMenuBar1.Location = new System.Drawing.Point(0, 0);
            this.ucMenuBar1.Margin = new System.Windows.Forms.Padding(5);
            this.ucMenuBar1.Name = "ucMenuBar1";
            this.ucMenuBar1.Size = new System.Drawing.Size(200, 770);
            this.ucMenuBar1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 864);
            this.Controls.Add(this.PanelDataCreation);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.PanelQuickAnalysis);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Анализ таблиц сопряженности";
            this.TransparencyKey = System.Drawing.Color.CornflowerBlue;
            this.PanelQuickAnalysis.ResumeLayout(false);
            this.PanelDataCreation.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ucQuickTabPanel ucQuickTabPanel;
        private ucDataCreation ucDataCreation1;
        private User_controls.ucMenuBar ucMenuBar1;
        private System.Windows.Forms.Panel MenuPanel;
        public System.Windows.Forms.Panel PanelQuickAnalysis;
        public System.Windows.Forms.Panel PanelDataCreation;
    }
}

