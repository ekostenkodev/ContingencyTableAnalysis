﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContingencyTableAnalysis
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {


        List<Panel> panels = new List<Panel>();

        public MainForm()
        {
            InitializeComponent();

            panels.Add(PanelDataCreation);
            panels.Add(PanelQuickAnalysis);

            panels.ForEach(item => item.Hide());





        }

        private void быстрыйАнализToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels.ForEach(item => item.Hide());

            PanelQuickAnalysis.Show();
            PanelQuickAnalysis.BringToFront();

        }

        private void создатьНаборДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels.ForEach(item => item.Hide());

            PanelDataCreation.Show();
            PanelDataCreation.BringToFront();
            //todo
        }

        private void открытьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы xls|*.xls|Файлы xlsx|*.xlsx|Файлы csv|*.csv|Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(OPF.FileName);
            }
            //todo
        }

        private void сохранитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void сохранитьДанныеКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void закрытьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void анализСвязиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void анализРазличийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void анализФакторовРискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void анализДиагностическихМетодовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void анализМетодовЛеченияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //todo

        }
    }

}
