using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TemperatureTool.Models
{
    public class ClientCollection
    {
        private List<Client> _clients;
        private PropertyDescriptor property;
        private PropertyInfo pi;
        private Type typ;
        private bool fSortDescending;
        private StringComparison stringComparisonToUse = StringComparison.Ordinal;

        public ClientCollection()
        {
            _clients = new List<Client>();
        }

        public int Count => this._clients.Count;

        public List<string> GetSelectedUsers => _clients.Where(r => r.IsChecked).Select(r => r.Id.ToString()).ToList();


        public int CountSeletedUsers => GetSelectedUsers.Count;

        public void Clear()
        {
            if (_clients != null)
                _clients.Clear();
        }

        public void AddRanges(List<Client> clients)
        {
            // Check not exist data            
            var newItem = clients.Where(r => !_clients.Any(t => t.Name == r.Name)).ToList();
            if (newItem.Count > 0)
                _clients.AddRange(newItem);
        }

        public IList<Client> Clients
        {
            get
            {
                return this._clients;
            }
            set
            {
                this._clients = value.ToList<Client>();
            }
        }

        public void SetCheckStatus(bool checkStatus)
        {
            _clients.Select(r => r.IsChecked = checkStatus).ToList();
        }

        public void Sort(string fieldName, SortOrder sortOrder)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(Client));
            property = props[fieldName];
            pi = typeof(Client).GetProperty(fieldName);
            if (pi == null)
            {
                throw new Exception("Property name " + fieldName +
                  " not found while trying to compare objects of type " + typeof(Client).Name);
            }

            typ = pi.PropertyType;

            fSortDescending = true;
            if (sortOrder == SortOrder.Ascending)
                fSortDescending = false;

            _clients.Sort(delegate (Client x, Client y)
             {
                 if (typ == typeof(int))
                 {
                     if (fSortDescending)
                         return CompareIntDesc(x, y);
                     return CompareInt(x, y);
                 }
                 if (typ == typeof(DateTime))
                     return CompareDates(x, y);

                 return StringCompare(x, y);
             });
        }

        private int StringCompare(Client x, Client y)
        {
            int nComp = string.Compare((string)property.GetValue(x), (string)property.GetValue(y), stringComparisonToUse);
            return (!fSortDescending ? nComp : -nComp);
        }

        private int CompareInt(Client x, Client y)
        {
            int oX = (int)property.GetValue(x);
            int oY = (int)property.GetValue(y);
            return (oX < oY) ? -1 : ((oX == oY) ? 0 : 1);
        }

        private int CompareIntDesc(Client x, Client y)
        {
            int oX = (int)property.GetValue(x);
            int oY = (int)property.GetValue(y);
            return (oX < oY) ? 1 : ((oX == oY) ? 0 : -1);
        }

        private int CompareDates(Client x, Client y)
        {
            DateTime oX = (DateTime)property.GetValue(x);
            DateTime oY = (DateTime)property.GetValue(y);
            int nComp = oX.CompareTo(oY);
            return (!fSortDescending) ? nComp : -nComp;
        }
    }

}
