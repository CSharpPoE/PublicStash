using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PathOfExile.Model.Internal
{
    public static class AttributeHelper
    {
        internal static IDictionary<String, Type> CreateTypeDictionary<T>(IDictionary<String, Type> typeDict)
            where T : ItemAttribute
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies().AsParallel())
            {
                foreach (var type in assembly.GetTypes().AsParallel())
                {
                    var value = type.GetCustomAttribute<T>()?.Value;
                    if (!String.IsNullOrEmpty(value))
                    {
                        typeDict.Add(value, type);
                    }
                }
            }

            return typeDict;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    internal class ItemAttribute : Attribute
    {
        public String Value { get; }

        protected ItemAttribute(String value)
        {
            Value = value;
        }
    }

    #region Currency

    internal class CurrencyAttribute : ItemAttribute
    {
        public CurrencyAttribute(string value) : base(value)
        {
        }
    }

    internal class BlessingAttribute : CurrencyAttribute
    {
        public BlessingAttribute(string value) : base(value)
        {
        }
    }

    internal class SplinterAttribute : CurrencyAttribute
    {
        public SplinterAttribute(string value) : base(value)
        {
        }
    }

    internal class EssenceAttribute : CurrencyAttribute
    {
        public EssenceAttribute(string value) : base(value)
        {
        }
    }

    internal class FossilAttribute : CurrencyAttribute
    {
        public FossilAttribute(string value) : base(value)
        {
        }
    }

    internal class ResonatorAttribute : CurrencyAttribute
    {
        public ResonatorAttribute(string value) : base(value)
        {
        }
    }

    internal class ProphecyAttribute : CurrencyAttribute
    {
        public ProphecyAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Divination Card

    internal class CardAttribute : ItemAttribute
    {
        public CardAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Weapon

    internal class WeaponAttribute : ItemAttribute
    {
        protected WeaponAttribute(string value) : base(value)
        {
        }
    }

    #region Two Handed

    internal class TwoHandedAttribute : WeaponAttribute
    {
        protected TwoHandedAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedSwordAttribute : TwoHandedAttribute
    {
        public TwoHandedSwordAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedAxeAttribute : TwoHandedAttribute
    {
        public TwoHandedAxeAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedMaceAttribute : TwoHandedAttribute
    {
        public TwoHandedMaceAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedBowAttribute : TwoHandedAttribute
    {
        public TwoHandedBowAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedStaffAttribute : TwoHandedAttribute
    {
        public TwoHandedStaffAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region One Handed



    internal class OneHandedAttribute : WeaponAttribute
    {
        protected OneHandedAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedSwordAttribute : OneHandedAttribute
    {
        public OneHandedSwordAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedThrustingSwordAttribute : OneHandedAttribute
    {
        public OneHandedThrustingSwordAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedAxeAttribute : OneHandedAttribute
    {
        public OneHandedAxeAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedMaceAttribute : OneHandedAttribute
    {
        public OneHandedMaceAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedDaggerAttribute : OneHandedAttribute
    {
        public OneHandedDaggerAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedClawAttribute : OneHandedAttribute
    {
        public OneHandedClawAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedWandAttribute : OneHandedAttribute
    {
        public OneHandedWandAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedSceptreAttribute : OneHandedAttribute
    {
        public OneHandedSceptreAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #endregion
}