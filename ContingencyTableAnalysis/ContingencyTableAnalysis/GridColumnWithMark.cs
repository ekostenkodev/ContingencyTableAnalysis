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
                if (Qualitative)
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
                if (Qualitative)
                    return null;

                return Items.Min(e => int.Parse(e.ToString()));

            }
        }
        public int? Max
        {

            get
            {
                if (Qualitative)
                    return null;

                return  Items.Max(e => int.Parse(e.ToString()));

            }
        }

        public List<object> Items
        {
            get {
                return getItems(); // todo колхоз, исправить заглушку
            }


        }
        private List<object> getItems()
        {
            List<object> list = new List<object>();

            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                if (DataGridView.Rows[i].Cells[Index].Value == null)
                    continue;
                list.Add(DataGridView.Rows[i].Cells[Index].Value);
            }

            return list;

        }
        private bool _qualitative = true;
        public bool Qualitative // качественный признак
        {
            get
            {
                return _qualitative;
            }
            set
            {
                if (value)
                    Border = null;


                _qualitative = value;
            }
        }



        public void CellValueChanged(int rowIndex,object value)
        {
            /*
            if (rowIndex < Items.Count)
            {
                Items.RemoveAt(rowIndex);
                Console.WriteLine("Remove"+rowIndex);
            }
            Console.WriteLine("Add"+rowIndex);
            Items.Insert(rowIndex, value);
            Console.WriteLine("+");
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("+");
            */

            if (new HashSet<object>(Items).Count > int.Parse(Properties.Resources.Setting4)) // проверка на уникальность качественных признаков в списке(нужно по тз) 
                Qualitative = false;

        }

        private int getAverage() => (Min.Value + Max.Value) / 2;


        public string GetName(bool border) => border ? HeaderText + " (граница - " + Border + ")" : HeaderText;
        
        
    }
}
