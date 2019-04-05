using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ContingencyTableAnalysis
{

    public class GridColumnWithMark : DataGridViewTextBoxColumn
    {
        public int? _border;
        public int? Border
        {
            get
            {
                if (_border.HasValue)
                    return _border;
                else
                    return getAverage();
            }
            set
            {
                if (Mark)
                {
                    return;
                }
                _border = value;
            }
        }

        public int? Min
        {
            get
            {
                if (Mark)
                    return null;

                return Items.Min(e => int.Parse(e.ToString()));

            }
        }
        public int? Max
        {

            get
            {
                if (Mark)
                    return null;

                return  Items.Max(e => int.Parse(e.ToString()));

            }
        }

        public List<object> Items = new List<object>();
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


                _mark = value;
            }
        }



        public void CellValueChanged(object value)
        {
            Items.Add(value);
            Items.RemoveAll(e => e == null);
            if (new HashSet<object>(Items).Count > int.Parse(Properties.Resources.Setting4)) // проверка на уникальность качественных признаков в списке(нужно по тз) 
                Mark = false;

        }

        private int getAverage() => (Min.Value + Max.Value) / 2;


        public string GetName(bool border) => border ? HeaderText + " (граница - " + Border + ")" : HeaderText;
        
        
    }
}
