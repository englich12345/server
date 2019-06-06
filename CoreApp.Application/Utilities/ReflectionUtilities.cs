using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CoreApp.Application.Utilities
{
    public class ReflectionUtilities
    {

        public static List<PropertyInfo> GetAllPropertiesOfType(Type type)
        {
            return type.GetProperties().ToList();
        }

        public static List<string> GetAllPropertyNamesOfType(Type type)
        {
            var properties = type.GetProperties();
            return properties.Select(p => p.Name).ToList();
        }
    }
}
