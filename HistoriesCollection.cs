using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace TemperatureTool
{
    public class HistoriesCollection
    {
        private PropertyDescriptor property;
        private PropertyInfo pi;
        private Type typ;
        private bool fSortDescending;
        private StringComparison stringComparisonToUse = StringComparison.Ordinal;

        private List<History> histories;

        public HistoriesCollection()
        {
            histories = new List<History>();
        }

        public List<History> Histories
        {
            get { return this.histories; }
            set { this.histories = value; }
        }

        public SearchFieldCollection GetSearchFieldCollection(string Id)
        {
            var exist = histories.Where(r => r.Id.Equals(Id)).FirstOrDefault();
            return exist == null ? null : exist.FieldCollection;
        }

        public void Add(SearchFieldCollection fieldCollection)
        {
            if (fieldCollection.Count == 0)
                return;

            if (histories.Count >= 20)
            {
                DeleteLastHistories();
            }

            histories.Add(new History()
            {
                Id = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                FieldCollection = fieldCollection
            });
        }

        private void DeleteLastHistories()
        {
            Sort("Id", SortOrder.Descending);
            histories.RemoveAt(histories.Count - 1);
        }

        public void Delete(string Id)
        {                
            var exist = histories.Where(r => r.Id.Equals(Id)).FirstOrDefault();
            if (exist != null)
                histories.Remove(exist);
        }

        public void Sort(string fieldName, SortOrder sortOrder)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(History));
            property = props[fieldName];
            pi = typeof(History).GetProperty(fieldName);
            if (pi == null)
            {
                throw new Exception("Property name " + fieldName +
                  " not found while trying to compare objects of type " + typeof(History).Name);
            }

            typ = pi.PropertyType;

            fSortDescending = true;
            if (sortOrder == SortOrder.Ascending)
                fSortDescending = false;

            histories.Sort(delegate (History x, History y)
            {
                if (typ == typeof(DateTime))
                    return CompareDates(x, y);

                return StringCompare(x, y);
            });
        }

        private int CompareDates(History x, History y)
        {
            DateTime oX = (DateTime)property.GetValue(x);
            DateTime oY = (DateTime)property.GetValue(y);
            int nComp = oX.CompareTo(oY);
            return (!fSortDescending) ? nComp : -nComp;
        }

        private int StringCompare(History x, History y)
        {
            int nComp = string.Compare((string)property.GetValue(x), (string)property.GetValue(y), stringComparisonToUse);
            return (!fSortDescending ? nComp : -nComp);
        }
    }

    [Serializable]
    public class History
    {
        public string Id { get; set; }
        public SearchFieldCollection FieldCollection;

        public string Contents
        {
            get
            {
                StringBuilder contents = new StringBuilder();
                foreach (SearchField field in FieldCollection.SearchFields)
                {
                    contents.Append(string.Format("{0} [{1}] = '{2}' ", field.IsAnd ? "AND" : "OR", field.FieldName, field.Value));
                }

                return contents.ToString();
            }
        }
    }

    public class SearchFieldCollection
    {
        private List<SearchField> _searchFields;
        public SearchFieldCollection()
        {
            _searchFields = new List<SearchField>();
        }

        public int Count
        {
            get
            {
                return _searchFields.Count;
            }
        }

        public void Add(SearchField searchField)
        {
            _searchFields.Add(searchField);
        }

        public List<SearchField> SearchFields
        {
            get
            {
                return _searchFields;
            }
            set
            {
                _searchFields = value;
            }
        }

        public SearchField GetField(string filedName)
        {
            var exist = _searchFields.Where(r => r.FieldName.Equals(filedName)).FirstOrDefault();
            if (exist != null)
                return exist;
            return new SearchField();
        }
    }

    [Serializable]
    public class SearchField
    {
        public string FieldName { get; set; }
        public string Value { get; set; }
        public bool IsAnd { get; set; }
    }
}
