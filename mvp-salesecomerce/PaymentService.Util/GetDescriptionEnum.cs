using System;
using System.ComponentModel;

namespace PaymentService.Util
{
    public static class GetDescriptionEnum
    {
        public static T GetDescriptionType<T>(this Enum valorEnum) where T : System.Attribute
        {
            var type = valorEnum.GetType();
            var memInfo = type.GetMember(valorEnum.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }

        public static string Description(this Enum valorEnum) => 
            valorEnum.GetDescriptionType<DescriptionAttribute>().Description;

        public static string RequestValueEnum<T>(this string description) where T : Enum {
            string result = string.Empty;
          
            foreach (int item in Enum.GetValues(typeof(T))) {
                foreach (var _name in Enum.GetNames(typeof(T))) {
                    if (_name.Equals(description)) {
                        result =  item.ToString();
                        break;
                    }
                }

               
            }

            return result;
        }


    }
}
