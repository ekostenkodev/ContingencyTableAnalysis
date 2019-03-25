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
            this.быстрыйАнализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНаборДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализСвязиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализРазличийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализФакторовРискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализДиагностическихМетодовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализМетодовЛеченияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelQuickAnalysis = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.PanelDataCreation = new System.Windows.Forms.Panel();
            this.ucQuickTabPanel = new ContingencyTableAnalysis.ucQuickTabPanel();
            this.ucDataCreation1 = new ContingencyTableAnalysis.ucDataCreation();
            this.menuStrip1.SuspendLayout();
            this.PanelQuickAnalysis.SuspendLayout();
            this.PanelDataCreation.SuspendLayout();
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
            this.menuStrip1.Location = new System.Drawing.Point(15, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
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
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // быстрыйАнализToolStripMenuItem
            // 
            this.быстрыйАнализToolStripMenuItem.Name = "быстрыйАнализToolStripMenuItem";
            this.быстрыйАнализToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.быстрыйАнализToolStripMenuItem.Text = "Быстрый анализ";
            this.быстрыйАнализToolStripMenuItem.Click += new System.EventHandler(this.быстрыйАнализToolStripMenuItem_Click);
            // 
            // создатьНаборДанныхToolStripMenuItem
            // 
            this.создатьНаборДанныхToolStripMenuItem.Name = "создатьНаборДанныхToolStripMenuItem";
            this.создатьНаборДанныхToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.создатьНаборДанныхToolStripMenuItem.Text = "Создать набор данных";
            this.создатьНаборДанныхToolStripMenuItem.Click += new System.EventHandler(this.создатьНаборДанныхToolStripMenuItem_Click);
            // 
            // открытьДанныеToolStripMenuItem
            // 
            this.открытьДанныеToolStripMenuItem.Name = "открытьДанныеToolStripMenuItem";
            this.открытьДанныеToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.открытьДанныеToolStripMenuItem.Text = "Открыть данные";
            this.открытьДанныеToolStripMenuItem.Click += new System.EventHandler(this.открытьДанныеToolStripMenuItem_Click);
            // 
            // сохранитьДанныеToolStripMenuItem
            // 
            this.сохранитьДанныеToolStripMenuItem.Name = "сохранитьДанныеToolStripMenuItem";
            this.сохранитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.сохранитьДанныеToolStripMenuItem.Text = "Сохранить данные";
            this.сохранитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДанныеToolStripMenuItem_Click);
            // 
            // сохранитьДанныеКакToolStripMenuItem
            // 
            this.сохранитьДанныеКакToolStripMenuItem.Name = "сохранитьДанныеКакToolStripMenuItem";
            this.сохранитьДанныеКакToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.сохранитьДанныеКакToolStripMenuItem.Text = "Сохранить данные как...";
            this.сохранитьДанныеКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДанныеКакToolStripMenuItem_Click);
            // 
            // закрытьДанныеToolStripMenuItem
            // 
            this.закрытьДанныеToolStripMenuItem.Name = "закрытьДанныеToolStripMenuItem";
            this.закрытьДанныеToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.закрытьДанныеToolStripMenuItem.Text = "Закрыть данные";
            this.закрытьДанныеToolStripMenuItem.Click += new System.EventHandler(this.закрытьДанныеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
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
            this.анализToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.анализToolStripMenuItem.Text = "Анализ";
            // 
            // анализСвязиToolStripMenuItem
            // 
            this.анализСвязиToolStripMenuItem.Name = "анализСвязиToolStripMenuItem";
            this.анализСвязиToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.анализСвязиToolStripMenuItem.Text = "Анализ связи";
            this.анализСвязиToolStripMenuItem.Click += new System.EventHandler(this.анализСвязиToolStripMenuItem_Click);
            // 
            // анализРазличийToolStripMenuItem
            // 
            this.анализРазличийToolStripMenuItem.Name = "анализРазличийToolStripMenuItem";
            this.анализРазличийToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.анализРазличийToolStripMenuItem.Text = "Анализ различий";
            this.анализРазличийToolStripMenuItem.Click += new System.EventHandler(this.анализРазличийToolStripMenuItem_Click);
            // 
            // анализФакторовРискаToolStripMenuItem
            // 
            this.анализФакторовРискаToolStripMenuItem.Name = "анализФакторовРискаToolStripMenuItem";
            this.анализФакторовРискаToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.анализФакторовРискаToolStripMenuItem.Text = "Анализ факторов риска";
            this.анализФакторовРискаToolStripMenuItem.Click += new System.EventHandler(this.анализФакторовРискаToolStripMenuItem_Click);
            // 
            // анализДиагностическихМетодовToolStripMenuItem
            // 
            this.анализДиагностическихМетодовToolStripMenuItem.Name = "анализДиагностическихМетодовToolStripMenuItem";
            this.анализДиагностическихМетодовToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.анализДиагностическихМетодовToolStripMenuItem.Text = "Анализ диагностических методов";
            this.анализДиагностическихМетодовToolStripMenuItem.Click += new System.EventHandler(this.анализДиагностическихМетодовToolStripMenuItem_Click);
            // 
            // анализМетодовЛеченияToolStripMenuItem
            // 
            this.анализМетодовЛеченияToolStripMenuItem.Name = "анализМетодовЛеченияToolStripMenuItem";
            this.анализМетодовЛеченияToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.анализМетодовЛеченияToolStripMenuItem.Text = "Анализ методов лечения";
            this.анализМетодовЛеченияToolStripMenuItem.Click += new System.EventHandler(this.анализМетодовЛеченияToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // PanelQuickAnalysis
            // 
            this.PanelQuickAnalysis.Controls.Add(this.ucQuickTabPanel);
            this.PanelQuickAnalysis.Location = new System.Drawing.Point(170, 83);
            this.PanelQuickAnalysis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelQuickAnalysis.Name = "PanelQuickAnalysis";
            this.PanelQuickAnalysis.Size = new System.Drawing.Size(764, 545);
            this.PanelQuickAnalysis.TabIndex = 1;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.DarkGray;
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(15, 84);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(150, 540);
            this.MenuPanel.TabIndex = 3;
            // 
            // PanelDataCreation
            // 
            this.PanelDataCreation.Controls.Add(this.ucDataCreation1);
            this.PanelDataCreation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDataCreation.Location = new System.Drawing.Point(165, 84);
            this.PanelDataCreation.Name = "PanelDataCreation";
            this.PanelDataCreation.Size = new System.Drawing.Size(769, 540);
            this.PanelDataCreation.TabIndex = 1;
            // 
            // ucQuickTabPanel
            // 
            this.ucQuickTabPanel.BackColor = System.Drawing.Color.White;
            this.ucQuickTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuickTabPanel.Location = new System.Drawing.Point(0, 0);
            this.ucQuickTabPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucQuickTabPanel.Name = "ucQuickTabPanel";
            this.ucQuickTabPanel.Size = new System.Drawing.Size(764, 545);
            this.ucQuickTabPanel.TabIndex = 0;
            // 
            // ucDataCreation1
            // 
            this.ucDataCreation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDataCreation1.Location = new System.Drawing.Point(0, 0);
            this.ucDataCreation1.Name = "ucDataCreation1";
            this.ucDataCreation1.Size = new System.Drawing.Size(769, 540);
            this.ucDataCreation1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 640);
            this.Controls.Add(this.PanelDataCreation);
            this.Controls.Add(this.MenuPanel);
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
            this.PanelDataCreation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализToolStripMenuItem;
        private System.Windows.Forms.Panel PanelQuickAnalysis;
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
        private ucQuickTabPanel ucQuickTabPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel PanelDataCreation;
        private ucDataCreation ucDataCreation1;
    }
}

