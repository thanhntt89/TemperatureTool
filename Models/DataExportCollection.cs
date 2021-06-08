using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TemperatureTool.Utilities;

namespace TemperatureTool.Models
{
    public class DataExportCollection : List<DataExport>
    {
        private List<DataExport> _exports;

        public DataExportCollection()
        {
            _exports = new List<DataExport>();
        }

        public List<DataExport> DataExports
        {
            get
            {
                SetIndex();
                return this._exports;
            }
            set { this._exports = value; }
        }

        public string[] ExportFileds
        {
            get; set;
        }

        public void SetIndex()
        {
            int index = 1;
            foreach (var x in _exports)
            {
                x.index = index;
                index++;
            }
        }

        public List<string> GetExportFieldsAll()
        {
            return typeof(DataExport).GetPropertyNames();
        }

        public List<string> GetHeadersText(string[] headerName)
        {
            List<string> exportHeader = new List<string>();

            foreach (var item in headerName)
            {
                exportHeader.Add(typeof(DataExport).GetPropertyDescription(item));
            }

            return exportHeader;
        }

        public List<DataExport> GetDataWithColumnName(string[] columnName)
        {
            SetIndex();
            //List<object> aa = new List<object>();
            var fields = $"{string.Join(",", columnName)}";
            //var fields = $"new ({string.Join(",", columnName)})";         
            return _exports.Select(CreateNewStatement(fields)).ToList();
        }

        public Func<DataExport, DataExport> CreateNewStatement(string fields)
        {
            // input parameter "o"
            var xParameter = Expression.Parameter(typeof(DataExport), "o");

            // new statement "new Data()"
            var xNew = Expression.New(typeof(DataExport));

            // create initializers
            var bindings = fields.Split(',').Select(o => o.Trim())
                .Select(o =>
                {

                    // property "Field1"
                    var mi = typeof(DataExport).GetProperty(o);

                    // original value "o.Field1"
                    var xOriginal = Expression.Property(xParameter, mi);

                    // set value "Field1 = o.Field1"
                    return Expression.Bind(mi, xOriginal);
                }
            );

            // initialization "new Data { Field1 = o.Field1, Field2 = o.Field2 }"
            var xInit = Expression.MemberInit(xNew, bindings);

            // expression "o => new Data { Field1 = o.Field1, Field2 = o.Field2 }"
            var lambda = Expression.Lambda<Func<DataExport, DataExport>>(xInit, xParameter);

            // compile to Func<Data, Data>
            return lambda.Compile();
        }

    }
}
