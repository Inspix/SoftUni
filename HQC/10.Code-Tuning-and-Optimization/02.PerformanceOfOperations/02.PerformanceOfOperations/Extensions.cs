using System;
using System.ComponentModel;
using System.Reflection;

namespace _02.PerformanceOfOperations
{
    public static class Extensions
    {
        public static string GetEnumDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo info = type.GetField(name);
                if (info != null)
                {
                    DescriptionAttribute attribute = Attribute.GetCustomAttribute(info,typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attribute != null)
                    {
                        return attribute.Description;
                    }
                }
            }
            return String.Empty;
        }
    }
}
