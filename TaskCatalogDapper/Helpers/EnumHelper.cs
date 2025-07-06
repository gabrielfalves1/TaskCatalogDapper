using Microsoft.AspNetCore.Mvc.Rendering;
using TaskCatalogDapper.Extensions;

namespace TaskCatalogDapper.Helpers
{
    public static class EnumHelper
    {
        public static List<SelectListItem> ToSelectList<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .Select(e => new SelectListItem
                {
                    Value = e.ToString(),
                    Text = ((Enum)(object)e).GetDisplayName()
                })
                .ToList();
        }
    }
}
