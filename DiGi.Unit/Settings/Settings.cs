using DiGi.Unit.Classes;

namespace DiGi.Unit
{
    public static partial class Settings
    {
        /// <summary>
        /// Gets the global unit manager instance.
        /// </summary>
        public static UnitManager UnitManager { get; } = Create.UnitManager();
    }
}