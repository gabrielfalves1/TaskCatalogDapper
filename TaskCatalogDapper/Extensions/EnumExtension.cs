using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TaskCatalogDapper.Extensions
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum value)
        {
            var member = value.GetType().GetMember(value.ToString());
            if (member.Length > 0)
            {
                var attr = member[0].GetCustomAttribute<DisplayAttribute>();
                return attr?.Name ?? value.ToString();
            }

            return value.ToString();
        }
    }
}
