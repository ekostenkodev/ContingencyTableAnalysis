using System;
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


        public List<Panel> panels = new List<Panel>();

        public MainForm()
        {
            InitializeComponent();

            panels.Add(PanelDataCreation);
            panels.Add(PanelQuickAnalysis);

            panels.ForEach(item => item.Hide());




        }


    }

}
