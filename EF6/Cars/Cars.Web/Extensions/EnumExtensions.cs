using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cars.Web
{
    public static class EnumExtensions
    {
        public static IEnumerable<SelectListItem> GetItemsAsSelectListItems(this Type type
            , int? selectedItem)
        {
            if (!typeof(Enum).IsAssignableFrom(type))
            {
                throw new ArgumentException("You must pass in an enum type.");
            }

            string[] names = Enum.GetNames(type);
            IEnumerable<int> values = Enum.GetValues(type).Cast<int>();

            return names.Zip(values, (n, v) =>
                new SelectListItem() {Text = n, Value = v.ToString(), Selected = v == selectedItem });
        }
    }
}