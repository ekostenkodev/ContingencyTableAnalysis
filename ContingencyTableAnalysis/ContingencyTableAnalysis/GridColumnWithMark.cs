using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ContingencyTableAnalysis
{

    public class GridColumnWithMark : DataGridViewTextBoxColumn
    {
        private bool _mark = true;
        public bool Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value)
                    Border = null;
                else
                {
                    if (Items.Count == 0)
                        Border = 0;
                    else
                        Border = (Items.Min(e => int.Parse(e.ToString())) + Items.Max(e => int.Parse(e.ToString()))) / 2;

                }

                _mark = value;
            }
        }
        public int? Border;
        public List<object> Items = new List<object>();


        public void ValueChanged(object value)
        {

            Items.Add(value);
            if(!Mark)
                Border = (Items.Min(e => int.Parse(e.ToString())) + Items.Max(e => int.Parse(e.ToString()))) / 2;
                
        }
        public string GetName(bool border) => border ? HeaderText + " (граница - " + Border + ")" : HeaderText;
        
        
    }
}
