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

                return Items.Max(e => int.Parse(e.ToString()));

            }
        }
        public List<object> Items { get
            {
                return ItemsWithNull.Where(e=>e!=null).ToList();
            } }
        public List<object> ItemsWithNull { get; } = new List<object>();
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

        private void fillItemListWithEmpty(int index)
        {
            while (index >= ItemsWithNull.Count)
            {
                ItemsWithNull.Add(null);
            }
        }

        public void CellValueChanged(int rowIndex,object value)
        {
            if(rowIndex>= ItemsWithNull.Count) 
                fillItemListWithEmpty(rowIndex);// заполнение списка пустыми значениями. Нужно для удобного удаления/вставки элементов в списке.

            ItemsWithNull[rowIndex] = value;
            
            if (new HashSet<object>(Items).Count > int.Parse(Properties.Resources.Setting4)) // проверка на уникальность качественных признаков в списке(нужно по тз) 
                Qualitative = false;

        }

        private int getAverage() => (Min.Value + Max.Value) / 2;


        public string GetName(bool border) => border ? HeaderText + " (граница - " + Border + ")" : HeaderText;
        
        
    }
}
