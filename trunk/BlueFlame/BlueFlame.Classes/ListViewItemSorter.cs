using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

using System.Windows.Forms;

namespace BlueFlame.Classes
{
    public class ListViewItemSorter : IComparer
    {
        int _column;
        SortOrder _order;

        public ListViewItemSorter(int colum, SortOrder order)
        {
            _column = colum;
            _order = order;
        }

        public int Compare(object x, object y)
        {
            if ((x is ListViewItem) && (y is ListViewItem))
            {
                int result = string.Compare(
                    (x as ListViewItem).SubItems[_column].Text,
                    (y as ListViewItem).SubItems[_column].Text);
                
                return (_order == SortOrder.Ascending) ? result : (- result) ;
            }
            else return 0;
        }
    }
}
