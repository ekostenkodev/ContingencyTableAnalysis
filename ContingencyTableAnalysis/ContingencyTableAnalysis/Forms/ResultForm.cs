using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContingencyTableAnalysis
{
    public partial class ResultForm : MetroFramework.Forms.MetroForm
    {
        public ResultForm(IDictionary<string, List<double>> results)
        {
            InitializeComponent();
            SaveResultBtn.Image = (Image)(new Bitmap(Properties.Resources.save_icon, new Size(16, 16)));
            FillResultList(results);           
        }
        public void FillResultList(IDictionary<string, List<double>> results)
        {            
            foreach (var item in results)
            {
                ListViewItem lvitem = new ListViewItem(item.Key);
                
                lvitem.SubItems.Add(String.Join(",  ", item.Value));
                ResultList.Items.Add(lvitem); //item.Value.ToString()
            }
        }

        private void ExitResultBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
