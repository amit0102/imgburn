using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BlueFlame.Classes
{
    public class ListViewColumnStatus
    {
        public ListViewColumnStatus()
        {
            _column = 0;
            _order = SortOrder.Ascending;
        }

        private int _column;
        public int Column
        {
            get { return _column; }
            set { _column = value; }
        }

        private SortOrder _order;
        public SortOrder SortOrder
        {
            get { return _order; }
            set { _order = value; }
        }

        /// <summary>
        /// Returns a sort order for a selected list view column, switching between ascending and descending.
        /// </summary>
        /// <param name="column">The column index of the clicked column </param>
        /// <returns>The sort order of the column</returns>
        public SortOrder Reorder(int column)
        {
            if (_column == column)
            {
                _order = (_order == SortOrder.Descending) ? SortOrder.Ascending : SortOrder.Descending ;
                return _order;
            }
            else
            {
                _column = column;
                _order = SortOrder.Descending;
                return _order;
            }
        }
    }
}
