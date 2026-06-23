using System.Reflection;

namespace DiGi.Unit
{
    public static partial class Create
    {
        /// <summary>
        /// Creates and initializes a new instance of the UnitManager by loading types from its assembly.
        /// </summary>
        /// <returns>A fully initialized <see cref="Classes.UnitManager"/> instance.</returns>
        public static Classes.UnitManager UnitManager()
        {
            Assembly assembly = Assembly.GetAssembly(typeof(Classes.UnitManager));

            Classes.UnitManager result = new();

            result.AddRange(assembly);

            return result;
        }
    }
}