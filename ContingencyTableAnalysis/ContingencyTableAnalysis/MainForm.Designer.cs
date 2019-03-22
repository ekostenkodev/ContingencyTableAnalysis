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
            this.ucQuickAnalysis1 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis2 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis3 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis4 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ucQuickAnalysis5 = new ContingencyTableAnalysis.ucQuickAnalysis();
            this.быстрыйАнализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНаборДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализСвязиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализРазличийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализФакторовРискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализДиагностическихМетодовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализМетодовЛеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.анализToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 74);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1498, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.быстрыйАнализToolStripMenuItem,
            this.создатьНаборДанныхToolStripMenuItem,
            this.открытьДанныеToolStripMenuItem,
            this.сохранитьДанныеToolStripMenuItem,
            this.сохранитьДанныеКакToolStripMenuItem,
            this.закрытьДанныеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // анализToolStripMenuItem
            // 
            this.анализToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.анализСвязиToolStripMenuItem,
            this.анализРазличийToolStripMenuItem,
            this.анализФакторовРискаToolStripMenuItem,
            this.анализДиагностическихМетодовToolStripMenuItem,
            this.анализМетодовЛеченияToolStripMenuItem});
            this.анализToolStripMenuItem.Name = "анализToolStripMenuItem";
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.анализToolStripMenuItem.Text = "Анализ";
            // 
            // PanelQuickAnalysis
            // 
            this.PanelQuickAnalysis.Controls.Add(this.tabControlQA);
            this.PanelQuickAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelQuickAnalysis.Location = new System.Drawing.Point(20, 102);
            this.PanelQuickAnalysis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelQuickAnalysis.Name = "PanelQuickAnalysis";
            this.PanelQuickAnalysis.Size = new System.Drawing.Size(1498, 563);
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
            this.tabControlQA.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlQA.Name = "tabControlQA";
            this.tabControlQA.SelectedIndex = 0;
            this.tabControlQA.Size = new System.Drawing.Size(1498, 563);
            this.tabControlQA.Style = MetroFramework.MetroColorStyle.Red;
            this.tabControlQA.TabIndex = 0;
            this.tabControlQA.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucQuickAnalysis1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1490, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Анализ связи";
            this.tabPage1.Enter += new System.EventHandler(this.tabPageEnter);
            // 
            // ucQuickAnalysis1
            // 
            this.ucQuickAnalysis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(68)))), ((int)(((byte)(35)))));
            this.ucQuickAnalysis1.Location = new System.Drawing.Point(0, 0);
            this.ucQuickAnalysis1.Margin = new System.Windows.Forms.Padding(0);
            this.ucQuickAnalysis1.Name = "ucQuickAnalysis1";
            this.ucQuickAnalysis1.Size = new System.Drawing.Size(1873, 800);
            this.ucQuickAnalysis1.TabIndex = 0;
            this.ucQuickAnalysis1.UseSelectable = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucQuickAnalysis2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1490, 521);
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
            this.tabPage3.Size = new System.Drawing.Size(1490, 521);
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
            this.tabPage4.Size = new System.Drawing.Size(1490, 521);
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
            this.tabPage5.Size = new System.Drawing.Size(1490, 521);
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
            // быстрыйАнализToolStripMenuItem
            // 
            this.быстрыйАнализToolStripMenuItem.Name = "быстрыйАнализToolStripMenuItem";
            this.быстрыйАнализToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.быстрыйАнализToolStripMenuItem.Text = "Быстрый анализ";
            // 
            // создатьНаборДанныхToolStripMenuItem
            // 
            this.создатьНаборДанныхToolStripMenuItem.Name = "создатьНаборДанныхToolStripMenuItem";
            this.создатьНаборДанныхToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.создатьНаборДанныхToolStripMenuItem.Text = "Создать набор данных";
            // 
            // открытьДанныеToolStripMenuItem
            // 
            this.открытьДанныеToolStripMenuItem.Name = "открытьДанныеToolStripMenuItem";
            this.открытьДанныеToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.открытьДанныеToolStripMenuItem.Text = "Открыть данные";
            // 
            // сохранитьДанныеToolStripMenuItem
            // 
            this.сохранитьДанныеToolStripMenuItem.Name = "сохранитьДанныеToolStripMenuItem";
            this.сохранитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.сохранитьДанныеToolStripMenuItem.Text = "Сохранить данные";
            // 
            // сохранитьДанныеКакToolStripMenuItem
            // 
            this.сохранитьДанныеКакToolStripMenuItem.Name = "сохранитьДанныеКакToolStripMenuItem";
            this.сохранитьДанныеКакToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.сохранитьДанныеКакToolStripMenuItem.Text = "Сохранить данные как...";
            // 
            // закрытьДанныеToolStripMenuItem
            // 
            this.закрытьДанныеToolStripMenuItem.Name = "закрытьДанныеToolStripMenuItem";
            this.закрытьДанныеToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.закрытьДанныеToolStripMenuItem.Text = "Закрыть данные";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // анализСвязиToolStripMenuItem
            // 
            this.анализСвязиToolStripMenuItem.Name = "анализСвязиToolStripMenuItem";
            this.анализСвязиToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.анализСвязиToolStripMenuItem.Text = "Анализ связи";
            // 
            // анализРазличийToolStripMenuItem
            // 
            this.анализРазличийToolStripMenuItem.Name = "анализРазличийToolStripMenuItem";
            this.анализРазличийToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.анализРазличийToolStripMenuItem.Text = "Анализ различий";
            // 
            // анализФакторовРискаToolStripMenuItem
            // 
            this.анализФакторовРискаToolStripMenuItem.Name = "анализФакторовРискаToolStripMenuItem";
            this.анализФакторовРискаToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.анализФакторовРискаToolStripMenuItem.Text = "Анализ факторов риска";
            // 
            // анализДиагностическихМетодовToolStripMenuItem
            // 
            this.анализДиагностическихМетодовToolStripMenuItem.Name = "анализДиагностическихМетодовToolStripMenuItem";
            this.анализДиагностическихМетодовToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.анализДиагностическихМетодовToolStripMenuItem.Text = "Анализ диагностических методов";
            // 
            // анализМетодовЛеченияToolStripMenuItem
            // 
            this.анализМетодовЛеченияToolStripMenuItem.Name = "анализМетодовЛеченияToolStripMenuItem";
            this.анализМетодовЛеченияToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.анализМетодовЛеченияToolStripMenuItem.Text = "Анализ методов лечения";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 685);
            this.Controls.Add(this.PanelQuickAnalysis);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
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
        private System.Windows.Forms.ToolStripMenuItem быстрыйАнализToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНаборДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализСвязиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализРазличийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализФакторовРискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализДиагностическихМетодовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализМетодовЛеченияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
    }
}

