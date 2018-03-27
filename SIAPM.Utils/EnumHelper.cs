using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SIAPM.Utils
{
    public static class EnumHelper
    {

        // This extension method is broken out so you can use a similar pattern with 
        // other MetaData elements in the future. This is your base method for each.
        public static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            T attribute = value.GetType()
                            .GetMember(value.ToString())
                            .Where(m => m.MemberType == MemberTypes.Field)
                            .FirstOrDefault()
                            ?.GetCustomAttribute<T>(false);

            if (attribute == null)
            {
                return default(T);
            }
            return attribute;
        }

        public static string ToName(this Enum value)
        {
            var attribute = value.GetAttribute<DisplayAttribute>();
            var key = attribute == null ? value.ToString() : attribute.Name;

            //ResourceManager resourceManager = new ResourceManager(attribute.ResourceType);
            // var name = resourceManager.GetString(key);

            return key;
        }


        public static T ToEnum<T>(this string str)
        {
            return (T)Enum.Parse(typeof(T), str, true);
        }
    }
}
