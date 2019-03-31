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
        MainForm _mainForm { get { return (MainForm)this.Parent.Parent; } }
        Tuple<Panel, Button> activePanel;

        public ucMenuBar()
        {
            InitializeComponent();

            panels.Add(FilePanel, mb_File);
            panels.Add(AnalysisPanel, mb_Analysis);
            panels.Add(AboutPanel, mb_About);

            mb_Analysis_1.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 0); };
            mb_Analysis_2.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 1); };
            mb_Analysis_3.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 2); };
            mb_Analysis_4.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 3); };
            mb_Analysis_5.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 4); };
        }

        public void SetAnalysisPanel(object sender, EventArgs e, int index)
        {
            ShowPanel(_mainForm.PanelAnalysis);
            _mainForm.PanelAnalysis.Controls.OfType<ucMarkConversion>().First().SetMarkPanel(index,_mainForm);
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            // todo сделать открытие панели, когда другая панель уже открыта
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

        private void ShowPanel(Panel panel)
        {
            _mainForm.panels.ForEach(item => item.Hide());
            panel.Show();
            panel.BringToFront();
        }

        private void mb_File_QuickAnalysis_Click(object sender, EventArgs e)
        {            

            ShowPanel(_mainForm.PanelQuickAnalysis);

        }

        private void mb_File_CreateData_Click(object sender, EventArgs e)
        {

            ShowPanel(_mainForm.PanelDataCreation);
        }



        private void mb_File_OpenData_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы xls|*.xls|Файлы xlsx|*.xlsx|Файлы csv|*.csv|Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(OPF.FileName);
            }
        }

        private void mb_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void mb_About_Info_Click(object sender, EventArgs e)
        {
            NotReady();
            //todo
        }
        private void NotReady()
        {
            MessageBox.Show("В разработке");

        }

        private void mb_About_Reference_Click(object sender, EventArgs e)
        {
            NotReady();
            //todo
        }

        

        private void mb_File_CloseData_Click(object sender, EventArgs e)
        {
            NotReady();
            //todo
        }

        private void mb_File_SaveData_Click(object sender, EventArgs e)
        {
            NotReady();
            //todo
        }

        private void mb_File_SaveDataAs_Click(object sender, EventArgs e)
        {
            NotReady();
            //todo
        }

        private void mb_File_Exit_Click(object sender, EventArgs e)
        {
            NotReady();
            //todo
        }
    }
}
