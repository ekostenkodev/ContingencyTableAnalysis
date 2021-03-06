﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContingencyTableAnalysis.Properties;

namespace ContingencyTableAnalysis
{
    public partial class ucMenuBar : UserControl
    {
        private const int TimerValue = 15; // скорость открытия/закрытия панелей 

        MainForm _mainForm;
        IDictionary<Panel, Button> allSliderPanels = new Dictionary<Panel, Button>(); // список панелей с кнопками
        List<Tuple<Panel, Button>> orderSliderPanels = new List<Tuple<Panel, Button>>(); // список нажатых кнопок

        public ucMenuBar(MetroFramework.Forms.MetroForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm as MainForm; 

            allSliderPanels.Add(FilePanel, mb_File);
            allSliderPanels.Add(AnalysisPanel, mb_Analysis);
            allSliderPanels.Add(AboutPanel, mb_About);

            // кнопки вызова панели с анализами
            // + передается индекс анализа
            mb_Analysis_1.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 0); };
            mb_Analysis_2.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 1); };
            mb_Analysis_3.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 2); };
            mb_Analysis_4.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 3); };
            mb_Analysis_5.Click += (sender, EventArgs) => { SetAnalysisPanel(sender, EventArgs, 4); };
        }

        public void SetAnalysisPanel(object sender, EventArgs e, int analysisIndex)
        {
            _mainForm.ShowPanel(_mainForm.PanelMark);
            _mainForm.PanelMark.Controls.OfType<ucMarkConversion>().First().SetMarkPanel(analysisIndex);
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            //нажатые кнопки раскрытия панелей добавляются в очередь, чтобы открываться в строгом порядке

            if (orderSliderPanels.Count == 1 ) // вторая нажатая кнопка не раскроется, пока из очереди не удалится первая
            {
                orderSliderPanels.Last().Item1.Height += TimerValue;
                orderSliderPanels.Last().Item2.Image = Resources.Collapse_Arrow_20px;

                if (orderSliderPanels.Last().Item1.Size == orderSliderPanels.Last().Item1.MaximumSize)
                {
                    SlideTimer.Stop();
                }
            }
            else
            {
                orderSliderPanels.First().Item1.Height -= TimerValue;
                orderSliderPanels.First().Item2.Image = Resources.Expand_Arrow_20px;
                if (orderSliderPanels.First().Item1.Size == orderSliderPanels.First().Item1.MinimumSize)
                {
                    orderSliderPanels.RemoveAll(item=>item.Item1.Equals(orderSliderPanels.First().Item1)); // убираем все вхождения, чтобы кнопка не открывалась снова
                    if (orderSliderPanels.Count == 0)
                    {
                        SlideTimer.Stop();
                    }
                }
                
            }
        }
        
        private void SlideMenuBtn_Click(object sender, EventArgs e)
        {
            var button = allSliderPanels.First(b => b.Value.Equals(sender));
            orderSliderPanels.Add(new Tuple<Panel, Button>(button.Key, button.Value));
            SlideTimer.Start();
        }

        

        private void mb_File_QuickAnalysis_Click(object sender, EventArgs e)
        {

            _mainForm.ShowPanel(_mainForm.PanelQuickAnalysis);

        }

        private void mb_File_CreateData_Click(object sender, EventArgs e)
        {

            if (CheckForSave(false) == DialogResult.Cancel)
                return;

            ucDataCreation ucData = _mainForm.PanelDataCreation.Controls.OfType<ucDataCreation>().First();

            ucData.CreateData();
            _mainForm.ShowPanel(_mainForm.PanelDataCreation);

        }

        public DialogResult CheckForSave(bool asNewFile)
        {
            ucDataCreation ucData = _mainForm.PanelDataCreation.Controls.OfType<ucDataCreation>().First();
            DialogResult dialogResult = DialogResult.No;

            if (ucData.DataSaved || ucData.DataCreationGrid.RowCount == 0) 
                return dialogResult;

            dialogResult = MessageBox.Show("Сохранить набор данных?", "Сохранение набора данных", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                ucData.SaveData(asNewFile);
            }

            return dialogResult;
        }

        private void mb_File_OpenData_Click(object sender, EventArgs e)
        {
            if (CheckForSave(true) == DialogResult.Cancel)
                return;

            _mainForm.PanelDataCreation.Controls.OfType<ucDataCreation>().First().OpenDataFile();
            _mainForm.ShowPanel(_mainForm.PanelDataCreation);

        }




        private void mb_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void mb_About_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
            //todo уточнить у заказчика
        }

        private void mb_About_Reference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
            //todo уточнить у заказчика
        }



        private void mb_File_CloseData_Click(object sender, EventArgs e)
        {
            if (CheckForSave(true) == DialogResult.Cancel)
                return;

            ucDataCreation ucData = _mainForm.PanelDataCreation.Controls.OfType<ucDataCreation>().First();

            ucData.ClearGridData();

        }

        private void mb_File_SaveData_Click(object sender, EventArgs e)
        {
            ucDataCreation ucData = _mainForm.PanelDataCreation.Controls.OfType<ucDataCreation>().First();
            ucData.SaveData(false);
        }

        private void mb_File_SaveDataAs_Click(object sender, EventArgs e)
        {
            ucDataCreation ucData = _mainForm.PanelDataCreation.Controls.OfType<ucDataCreation>().First();
            ucData.SaveData(true);
        }

        private void mb_File_Exit_Click(object sender, EventArgs e)
        {
            if (CheckForSave(true) == DialogResult.Cancel)
                return;

            ucDataCreation ucData = _mainForm.PanelDataCreation.Controls.OfType<ucDataCreation>().First();
        }
    }

    public class Tuple<T1, T2>
    {
        public T1 Item1 { get; private set; }
        public T2 Item2 { get; private set; }
        internal Tuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
