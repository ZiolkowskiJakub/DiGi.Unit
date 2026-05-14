using System;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.Unit.Classes
{
    public class UnitManager
    {
        private readonly Dictionary<Enum, Unit> units = [];

        public UnitManager()
        {
        }

        public Unit? Add(Enum? @enum)
        {
            if (@enum is null)
            {
                return null;
            }

            if (units.TryGetValue(@enum, out Unit result) && result is not null)
            {
                return result;
            }

            Unit unit = new(@enum);
            if (!unit.IsValid())
            {
                return null;
            }

            units[@enum] = unit;
            return unit;
        }

        public List<Unit>? AddRange(Type? type)
        {
            if (type is null)
            {
                return null;
            }

            List<Unit> result = [];
            foreach (Enum value in Enum.GetValues(type))
            {
                if (Add(value) is Unit unit)
                {
                    result.Add(unit);
                }
            }
            return result;
        }

        public List<Unit>? AddRange(Assembly? assembly)
        {
            if(assembly is null)
            {
                return null;
            }

            Type[] types = assembly.GetTypes();

            List<Unit> result = [];

            foreach (Type type in types)
            {
                if (!type.IsEnum)
                {
                    continue;
                }

                if (type.GetCustomAttribute<CategoryAttribute>() is null)
                {
                    continue;
                }

                List<Unit>? units = AddRange(type);
                if (units is not null)
                {
                    result.AddRange(units);
                }
            }

            return result;
        }

        public double From(Enum? @enum, double value, bool update = true)
        {
            Unit? unit = GetUnit(@enum, update);
            if (unit is null)
            {
                return double.NaN;
            }

            return unit.From(value);
        }

        public CategoryAttribute? GetCategoryAttribute(Enum? @enum, bool update = true)
        {
            Unit? unit = GetUnit(@enum, update);
            if (unit is null)
            {
                return null;
            }

            return unit.CategoryAttribute;
        }

        public Unit? GetUnit(Enum? @enum, bool update = true)
        {
            if (@enum is null)
            {
                return null;
            }

            if (units.TryGetValue(@enum, out Unit result))
            {
                return result;
            }

            if(!update)
            {
                return null;
            }

            return Add(@enum);
        }
        
        public UnitAttribute? GetUnitAttribute(Enum? @enum, bool update = true)
        {
            Unit? unit = GetUnit(@enum, update);
            if (unit is null)
            {
                return null;
            }

            return unit.UnitAttribute;
        }
        
        public double To(Enum? @enum, double value, bool update = true)
        {
            Unit? unit = GetUnit(@enum, update);
            if (unit is null)
            {
                return double.NaN;
            }

            return unit.To(value);
        }
    }
}