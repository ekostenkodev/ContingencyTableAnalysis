using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ContingencyTableAnalysis
{

    public class GridColumnWithMark : DataGridViewTextBoxColumn
    {
        public bool Mark = true;
        public int Border;
        public List<object> Items = new List<object>();

        public void ValueChanged(object value)
        {

            Items.Add(value);

            Border = (Items.Min(e => int.Parse(e.ToString())) + Items.Max(e => int.Parse(e.ToString()))) / 2;
                
        }
        public string GetName(bool border) => border ? HeaderText + " (граница - " + Border + ")" : HeaderText;
        
        
    }
}
