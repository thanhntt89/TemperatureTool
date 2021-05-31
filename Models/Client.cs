using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Reflection;

namespace TemperatureTool.Models
{
    [Serializable]
    public class Client : INotifyPropertyChanged
    {
        private string _saveDate = string.Empty;
        private bool _isChecked = false;
        private int _id;
        private string _name;
        private string _email;
        private string _postNo;
        private string _dob;
        private string _height;
        private string _weight;
        private string _secure_level;
        private string _sn;

        public bool IsChecked
        {
            get
            {
                return this._isChecked;
            }
            set
            {
                this._isChecked = value;
                NotifyPropertyChanged();
            }
        }

        [JsonProperty("id")]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                NotifyPropertyChanged();
            }
        }

        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                NotifyPropertyChanged();
            }
        }

        [JsonProperty("email")]
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
                NotifyPropertyChanged();
            }
        }

        [JsonProperty("postno")]
        public string PostNo
        {
            get
            {
                return this._postNo;
            }
            set
            {
                this._postNo = value;
                NotifyPropertyChanged();
            }
        }
        [JsonProperty("birth")]
        public string DoB
        {
            get
            {
                return this._dob;
            }
            set
            {
                this._dob = value;
                NotifyPropertyChanged();
            }
        }
        [JsonProperty("height")]
        public string Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
                NotifyPropertyChanged();
            }
        }
        [JsonProperty("weight")]
        public string Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
                NotifyPropertyChanged();
            }
        }
        [JsonProperty("secure_level")]
        public string SecureLevel
        {
            get
            {
                return this._secure_level;
            }
            set
            {
                this._secure_level = value;
                NotifyPropertyChanged();
            }
        }

        [JsonProperty("save_date")]
        public string SaveDate
        {
            get
            {
                return Convert.ToDateTime(this._saveDate).ToString("yyyy/MM/dd");
            }
            set
            {
                _saveDate = value;
                NotifyPropertyChanged();
            }
        }
        [JsonProperty("sn")]
        public string SN
        {
            get
            {
                return this._sn;
            }
            set
            {
                this._sn = value;
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
