using DiGi.Unit.Classes;

namespace DiGi.Unit
{
    public static partial class Settings
    {
        public static UnitManager UnitManager { get; } = Create.UnitManager();
    }
}