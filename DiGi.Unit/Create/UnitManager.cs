using System;
using System.Reflection;

namespace DiGi.Unit
{
    public static partial class Create
    {
        public static Classes.UnitManager UnitManager()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(Classes.UnitManager));

            Classes.UnitManager result = new();

            result.AddRange(assembly);

            return result;
        }
    }
}