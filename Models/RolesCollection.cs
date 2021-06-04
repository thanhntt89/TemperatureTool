using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace TemperatureTool.Models
{
    public class RolesCollection
    {
        private List<Role> _roles;
        public RolesCollection()
        {
            _roles = new List<Role>();
        }

        public void Add(Role role)
        {
            var exist = _roles.Where(r => r.RoleId == role.RoleId).FirstOrDefault();
            if (exist != null)
            {
                exist.IsVisible = role.IsVisible;
                return;
            }
            _roles.Add(role);
        }

        public List<Role> GetRoles(bool isVisible)
        {
            var exist = _roles.Where(r => r.IsVisible == isVisible).OrderBy(r => r.RoleId).ToList();
            return exist;
        }

        public List<Role> Roles
        {
            get { return _roles; }
            set { _roles = value; }
        }

        public Role GetRole(int roleId)
        {
            var exist = _roles.Where(r => r.RoleId == roleId).FirstOrDefault();
            return exist;
        }

        public Role GetRole(string roleName)
        {
            if (_roles == null)
                return null;
            var exist = _roles.Where(r => r.RoleName.Equals(roleName)).FirstOrDefault();
            return exist;
        }

        public void UpdateRoleByRoleName(string roleName, string value, bool isAnd)
        {
            var exist = _roles.Where(r => r.RoleName.Equals(roleName)).FirstOrDefault();
            if (exist != null)
            {
                exist.Value = value;
                exist.IsAnd = isAnd;
            }
        }

        public bool IsVisible(string roleName)
        {
            if (_roles == null)
                return false;

            var exist = _roles.Where(r => r.RoleName.Equals(roleName)).FirstOrDefault();
            if (exist != null)
                return exist.IsVisible;
            return false;
        }

        public string GetRoleString()
        {
            return string.Join(", ", _roles.Select(c => c.RoleName).ToArray<string>());
        }
    }

    [Serializable]
    public class Role : INotifyPropertyChanged
    {
        private int _roleId;
        private string _roleName;
        private string _value;
        private bool _isAnd;
        private bool _isVisible;

        public int RoleId
        {
            get
            {
                return _roleId;
            }
            set
            {
                _roleId = value;
                NotifyPropertyChanged();
            }
        }
        public string RoleName
        {
            get
            {
                return _roleName;
            }
            set
            {
                _roleName = value;
                NotifyPropertyChanged();
            }
        }
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                NotifyPropertyChanged();
            }
        }
        public bool IsAnd
        {
            get
            {
                return _isAnd;
            }
            set
            {
                _isAnd = value;
                NotifyPropertyChanged();
            }
        }
        public bool IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                _isVisible = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
