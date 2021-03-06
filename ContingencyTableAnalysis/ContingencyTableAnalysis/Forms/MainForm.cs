﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContingencyTableAnalysis
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {

        //public DataGridView Data;
        public List<Panel> panels = new List<Panel>();

        public MainForm()
        {
            InitializeComponent();

            panels.Add(PanelDataCreation);
            panels.Add(PanelQuickAnalysis);
            panels.Add(PanelMark);
            panels.Add(PanelAnalysis);

            panels.ForEach(item => item.Hide());

           // Data = PanelDataCreation.Controls.OfType<ucDataCreation>().First().DataCreationGrid;

        }

        public void ShowPanel(Panel panel)
        {
            panels.ForEach(item => item.Hide());
            panel.Show();
            panel.BringToFront();
        }

    }

}
