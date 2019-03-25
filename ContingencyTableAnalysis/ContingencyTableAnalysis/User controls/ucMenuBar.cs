using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContingencyTableAnalysis.Properties;

namespace ContingencyTableAnalysis.User_controls
{
    public partial class ucMenuBar : UserControl
    {
        private bool isCollapsed;


        IDictionary<Panel, Button> panels = new Dictionary<Panel, Button>();

        Tuple<Panel, Button> activePanel;

        public ucMenuBar()
        {
            InitializeComponent();

            panels.Add(FilePanel, mb_File);
            panels.Add(AnalysisPanel, mb_Analysis);
            panels.Add(AboutPanel, mb_About);

        }




        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                activePanel.Item1.Height += 10;
                activePanel.Item2.Image = Resources.Collapse_Arrow_20px;
                if (activePanel.Item1.Size == activePanel.Item1.MaximumSize)
                {
                    SlideTimer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                foreach (var item in panels)
                {
                    item.Key.Height -= 10;
                    item.Value.Image = Resources.Expand_Arrow_20px;
                }

                if (panels.All(panel=> panel.Key.Size == panel.Key.MinimumSize))
                {
                    SlideTimer.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void SlideMenuBtn_Click(object sender, EventArgs e)
        {
            var button = panels.First(b => b.Value.Equals(sender));
            activePanel = new Tuple<Panel, Button>(button.Key, button.Value);
            SlideTimer.Start();
        }
    }
}
