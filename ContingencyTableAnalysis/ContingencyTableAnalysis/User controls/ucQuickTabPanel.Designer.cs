namespace ContingencyTableAnalysis
{
    partial class ucQuickTabPanel
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
            this.tabControlQA = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis1 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis2 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis3 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis4 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis5 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.tabControlQA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControlQA.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlQA.Name = "tabControlQA";
            this.tabControlQA.SelectedIndex = 0;
            this.tabControlQA.Size = new System.Drawing.Size(963, 709);
            this.tabControlQA.Style = MetroFramework.MetroColorStyle.Red;
            this.tabControlQA.TabIndex = 1;
            this.tabControlQA.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucQuickAnalysis1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(955, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Анализ связи";
            this.tabPage1.Enter += new System.EventHandler(this.tabPageEnter);
            // 
            // ucQuickAnalysis1
            // 
            this.ucQuickAnalysis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(35)))));
            this.ucQuickAnalysis1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuickAnalysis1.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis1.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis1.Name = "ucQuickAnalysis1";
            this.ucQuickAnalysis1.Size = new System.Drawing.Size(955, 667);
            this.ucQuickAnalysis1.TabIndex = 0;
            this.ucQuickAnalysis1.UseSelectable = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucQuickAnalysis2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(955, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализ различий";
            this.tabPage2.Enter += new System.EventHandler(this.tabPageEnter);
            // 
            // ucQuickAnalysis2
            // 
            this.ucQuickAnalysis2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(35)))));
            this.ucQuickAnalysis2.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis2.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis2.Name = "ucQuickAnalysis2";
            this.ucQuickAnalysis2.Size = new System.Drawing.Size(1873, 800);
            this.ucQuickAnalysis2.TabIndex = 0;
            this.ucQuickAnalysis2.UseSelectable = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ucQuickAnalysis3);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(955, 667);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Анализ факторов риска";
            this.tabPage3.Enter += new System.EventHandler(this.tabPageEnter);
            // 
            // ucQuickAnalysis3
            // 
            this.ucQuickAnalysis3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(35)))));
            this.ucQuickAnalysis3.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis3.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis3.Name = "ucQuickAnalysis3";
            this.ucQuickAnalysis3.Size = new System.Drawing.Size(1873, 800);
            this.ucQuickAnalysis3.TabIndex = 0;
            this.ucQuickAnalysis3.UseSelectable = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ucQuickAnalysis4);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(955, 667);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Анализ диагностических методов";
            this.tabPage4.Enter += new System.EventHandler(this.tabPageEnter);
            // 
            // ucQuickAnalysis4
            // 
            this.ucQuickAnalysis4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(35)))));
            this.ucQuickAnalysis4.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis4.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis4.Name = "ucQuickAnalysis4";
            this.ucQuickAnalysis4.Size = new System.Drawing.Size(1873, 800);
            this.ucQuickAnalysis4.TabIndex = 0;
            this.ucQuickAnalysis4.UseSelectable = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ucQuickAnalysis5);
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(955, 667);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Анализ методов лечения";
            this.tabPage5.Enter += new System.EventHandler(this.tabPageEnter);
            // 
            // ucQuickAnalysis5
            // 
            this.ucQuickAnalysis5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(35)))));
            this.ucQuickAnalysis5.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis5.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis5.Name = "ucQuickAnalysis5";
            this.ucQuickAnalysis5.Size = new System.Drawing.Size(1873, 800);
            this.ucQuickAnalysis5.TabIndex = 0;
            this.ucQuickAnalysis5.UseSelectable = true;
            // 
            // ucQuickTabPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlQA);
            this.Name = "ucQuickTabPanel";
            this.Size = new System.Drawing.Size(963, 709);
            this.tabControlQA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
