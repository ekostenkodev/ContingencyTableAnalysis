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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelQuickAnalysis = new System.Windows.Forms.Panel();
            this.tabControlQA = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis1 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.ucQuickAnalysis2 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.ucQuickAnalysis3 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.ucQuickAnalysis4 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.ucQuickAnalysis5 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.menuStrip1.SuspendLayout();
            this.PanelQuickAnalysis.SuspendLayout();
            this.tabControlQA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.анализToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.анализToolStripMenuItem.Text = "Анализ";
            // 
            // PanelQuickAnalysis
            // 
            this.PanelQuickAnalysis.Controls.Add(this.tabControlQA);
            this.PanelQuickAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelQuickAnalysis.Location = new System.Drawing.Point(15, 84);
            this.PanelQuickAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.PanelQuickAnalysis.Name = "PanelQuickAnalysis";
            this.PanelQuickAnalysis.Size = new System.Drawing.Size(1078, 362);
            this.PanelQuickAnalysis.TabIndex = 1;
            // 
            // tabControlQA
            // 
            this.tabControlQA.Controls.Add(this.tabPage1);
            this.tabControlQA.Controls.Add(this.tabPage2);
            this.tabControlQA.Controls.Add(this.tabPage3);
            this.tabControlQA.Controls.Add(this.tabPage4);
            this.tabControlQA.Controls.Add(this.tabPage5);
            this.tabControlQA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlQA.Location = new System.Drawing.Point(0, 0);
            this.tabControlQA.Name = "tabControlQA";
            this.tabControlQA.SelectedIndex = 4;
            this.tabControlQA.Size = new System.Drawing.Size(1078, 362);
            this.tabControlQA.TabIndex = 0;
            this.tabControlQA.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucQuickAnalysis1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(392, 132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucQuickAnalysis2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(392, 132);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ucQuickAnalysis3);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(392, 132);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ucQuickAnalysis4);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(392, 132);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ucQuickAnalysis5);
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1070, 320);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // ucQuickAnalysis1
            // 
            this.ucQuickAnalysis1.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis1.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis1.Name = "ucQuickAnalysis1";
            this.ucQuickAnalysis1.Size = new System.Drawing.Size(1405, 650);
            this.ucQuickAnalysis1.TabIndex = 0;
            this.ucQuickAnalysis1.UseSelectable = true;
            // 
            // ucQuickAnalysis2
            // 
            this.ucQuickAnalysis2.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis2.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis2.Name = "ucQuickAnalysis2";
            this.ucQuickAnalysis2.Size = new System.Drawing.Size(1405, 650);
            this.ucQuickAnalysis2.TabIndex = 0;
            this.ucQuickAnalysis2.UseSelectable = true;
            // 
            // ucQuickAnalysis3
            // 
            this.ucQuickAnalysis3.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis3.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis3.Name = "ucQuickAnalysis3";
            this.ucQuickAnalysis3.Size = new System.Drawing.Size(1405, 650);
            this.ucQuickAnalysis3.TabIndex = 0;
            this.ucQuickAnalysis3.UseSelectable = true;
            // 
            // ucQuickAnalysis4
            // 
            this.ucQuickAnalysis4.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis4.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis4.Name = "ucQuickAnalysis4";
            this.ucQuickAnalysis4.Size = new System.Drawing.Size(1405, 650);
            this.ucQuickAnalysis4.TabIndex = 0;
            this.ucQuickAnalysis4.UseSelectable = true;
            // 
            // ucQuickAnalysis5
            // 
            this.ucQuickAnalysis5.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis5.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis5.Name = "ucQuickAnalysis5";
            this.ucQuickAnalysis5.Size = new System.Drawing.Size(1405, 650);
            this.ucQuickAnalysis5.TabIndex = 0;
            this.ucQuickAnalysis5.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 462);
            this.Controls.Add(this.PanelQuickAnalysis);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Анализ таблиц сопряженности";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelQuickAnalysis.ResumeLayout(false);
            this.tabControlQA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.Panel PanelQuickAnalysis;
        private MetroFramework.Controls.MetroTabControl tabControlQA;
        private System.Windows.Forms.TabPage tabPage1;
        private ucQuickAnalysis ucQuickAnalysis1;
        private System.Windows.Forms.TabPage tabPage2;
        private ucQuickAnalysis ucQuickAnalysis2;
        private System.Windows.Forms.TabPage tabPage3;
        private ucQuickAnalysis ucQuickAnalysis3;
        private System.Windows.Forms.TabPage tabPage4;
        private ucQuickAnalysis ucQuickAnalysis4;
        private System.Windows.Forms.TabPage tabPage5;
        private ucQuickAnalysis ucQuickAnalysis5;
    }
}

