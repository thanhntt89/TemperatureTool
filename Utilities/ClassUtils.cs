using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace TemperatureTool.Utilities
{
    public static class ClassUtils
    {
        /// <summary>
        /// Get description of property
        /// Ex: var des = ClassUtils.GetPropertyDescription<Object>(propertyName);
        /// </summary>
        /// <typeparam name="T">Object class</typeparam>
        /// <param name="propertyName">Property name</param>
        /// <returns>Description</returns>
        public static string GetPropertyDescription<T>(string propertyName)
        {
            Attribute attribute = typeof(T).GetProperty(propertyName).GetCustomAttribute(typeof(DescriptionAttribute));
            if (attribute != null)
            {
                return ((DescriptionAttribute)attribute).Description;
            }

            return string.Empty;
        }

        /// <summary>
        /// Get description of property
        /// Ex: var des = typeof(objec).GetPropertyDescription(propertyName);
        /// </summary>
        /// <param name="type">Oject</param>
        /// <param name="propertyName">Property name</param>
        /// <returns>Description</returns>
        public static string GetPropertyDescription(this Type type, string propertyName)
        {
            Attribute attribute = type.GetProperty(propertyName).GetCustomAttribute(typeof(DescriptionAttribute));
            if (attribute != null)
            {
                return ((DescriptionAttribute)attribute).Description;
            }

            return string.Empty;
        }

        /// <summary>
        /// Get propertis of object
        /// Ex: var list = ClassUtils.GetPropertyNames<Object>();
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<string> GetPropertyNames<T>() => typeof(T)
        .GetProperties()
        .Select(prop => prop.Name)
        .ToList();


        /// <summary>
        /// Get property of object 
        /// Ex: var list = typeof(Object).GetPropertyNames();
        /// </summary>
        /// <param name="type">Object</param>
        /// <returns>List properties of object</returns>
        public static List<string> GetPropertyNames(this Type type) => type
           .GetProperties()
           .Select(prop => prop.Name)
           .ToList();

        public static PropertyAttributesCollection GetPropertiesAttributes(this Type type)
        {
            PropertyAttributesCollection attributesCollection = new PropertyAttributesCollection();

            List<string> pros = GetPropertyNames(type);
            foreach (string pro in pros)
            {
                attributesCollection.Add(new PropertyAttributes()
                {
                    Name = pro,
                    Description = GetPropertyDescription(type, pro),
                    IsVisible = true
                });
            }
            return attributesCollection;
        }

    }

    public class PropertyAttributesCollection
    {
        private List<PropertyAttributes> properties;

        public List<PropertyAttributes> PropertyAttributes
        {
            get { return properties; }
            set { properties = value; }
        }

        public PropertyAttributesCollection()
        {
            properties = new List<PropertyAttributes>();
        }

        public void Add(PropertyAttributes property)
        {
            if (GetPropertyAttributes(property.Name) != null)
                return;
            this.properties.Add(property);
        }

        public PropertyAttributes GetPropertyAttributes(string propertyName)
        {
            return this.properties.Where(r => r.Name.Equals(propertyName)).FirstOrDefault();
        }

        public void SetInVisibleHeader(string[] inVisibleHeaders)
        {
            this.properties.Where(r => inVisibleHeaders.Contains(r.Name)).Select(r => r.IsVisible = false).ToList();
        }

        public void ResetVisibleHeader()
        {
            this.properties.Select(r => r.IsVisible = true).ToList();
        }

        public List<PropertyAttributes> GetPropertyAttributes(string[] headerName)
        {
            return this.properties.Where(r => headerName.Contains(r.Name)).ToList();
        }
    }

    public class PropertyAttributes
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }
    }
}
