using System;
using System.Collections.Generic;
using System.Text;

namespace BlueFlame.Classes
{
    public class SearchItem : IEquatable<SearchItem>
    {
        private string _keyword;

        public string Keyword
        {
            get { return _keyword; }
            set { _keyword = value; }
        }
        private SearchCriterion _criterion;

        public SearchCriterion SearchCriterion
        {
            get { return _criterion; }
            set { _criterion = value; }
        }

        public SearchItem(string keyword, SearchCriterion criterion)
        {
            _keyword = keyword;
            _criterion = criterion;
        }



        #region IEquatable<SearchItem> Member

        public bool Equals(SearchItem other)
        {
            return (_criterion == other.SearchCriterion && _keyword == other.Keyword);
        }

        #endregion
    }
}
