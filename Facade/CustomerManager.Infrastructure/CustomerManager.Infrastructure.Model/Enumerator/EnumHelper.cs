using System;
using System.ComponentModel;
using System.Reflection;

namespace CustomerManager.Infrastructure.Model.Enumerator
{
    /// <summary>
    /// Contains helper methods for enum
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Get value of enum description attribute 
        /// </summary>
        /// <param name="enum">Enum item</param>
        /// <returns>Value of description attribute</returns>
        public static string GetDescription(this Enum @enum)
        {
            string description = string.Empty;
            FieldInfo[] fields = @enum.GetType().GetFields();

            foreach (FieldInfo field in fields)
            {
                var descriptionAttribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (descriptionAttribute != null && field.Name.Equals(@enum.ToString(), StringComparison.InvariantCultureIgnoreCase))
                {
                    description = descriptionAttribute.Description;
                    break;
                }
            }

            return description;
        }
    }
}
