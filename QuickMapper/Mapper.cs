using System;
using System.Reflection;

namespace QuickMapper
{
    public static class Mapper
    {
        public static T Map<T>(this object model)
        {
            T poco = Activator.CreateInstance<T>();
            foreach (PropertyInfo pi in model.GetType().GetProperties())
            {
                if (poco.GetType().GetProperty(pi.Name) != null)
                {
                    poco.GetType().GetProperty(pi.Name).SetValue(poco, pi.GetValue(model));
                }
            }
            return poco;
        }
    }
}
