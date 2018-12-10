using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PathOfExile.Model.Internal
{
    public static class AttributeHelper
    {
        internal static IDictionary<String, Type> Index<T>() where T : ItemAttribute
        {
            var typeDict = new Dictionary<String, Type>();
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

    internal class TwoHandedWeaponAttribute : WeaponAttribute
    {
        protected TwoHandedWeaponAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedSwordAttribute : TwoHandedWeaponAttribute
    {
        public TwoHandedSwordAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedAxeAttribute : TwoHandedWeaponAttribute
    {
        public TwoHandedAxeAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedMaceAttribute : TwoHandedWeaponAttribute
    {
        public TwoHandedMaceAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedBowAttribute : TwoHandedWeaponAttribute
    {
        public TwoHandedBowAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandedStaffAttribute : TwoHandedWeaponAttribute
    {
        public TwoHandedStaffAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region One Handed

    internal class OneHandedWeaponAttribute : WeaponAttribute
    {
        protected OneHandedWeaponAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedSwordAttribute : OneHandedWeaponAttribute
    {
        public OneHandedSwordAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedThrustingSwordAttribute : OneHandedWeaponAttribute
    {
        public OneHandedThrustingSwordAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedAxeAttribute : OneHandedWeaponAttribute
    {
        public OneHandedAxeAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedMaceAttribute : OneHandedWeaponAttribute
    {
        public OneHandedMaceAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedDaggerAttribute : OneHandedWeaponAttribute
    {
        public OneHandedDaggerAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedClawAttribute : OneHandedWeaponAttribute
    {
        public OneHandedClawAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedWandAttribute : OneHandedWeaponAttribute
    {
        public OneHandedWandAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandedSceptreAttribute : OneHandedWeaponAttribute
    {
        public OneHandedSceptreAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #endregion

    #region Ring

    internal class RingAttribute : ItemAttribute
    {
        public RingAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Amulet

    internal class AmuletAttribute : ItemAttribute
    {
        public AmuletAttribute(string value) : base(value)
        {
        }
    }

    internal class TalismanAttribute : AmuletAttribute
    {
        public TalismanAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Gem

    internal class GemAttribute : ItemAttribute
    {
        protected GemAttribute(string value) : base(value)
        {
        }
    }

    internal class ActiveGemAttribute : GemAttribute
    {
        public ActiveGemAttribute(string value) : base(value)
        {
        }
    }

    internal class SupportGemAttribute : GemAttribute
    {
        public SupportGemAttribute(string value) : base(value)
        {
        }
    }

    internal class VaalGemAttribute : GemAttribute
    {
        public VaalGemAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Armour

    internal class ArmourAttribute : ItemAttribute
    {
        protected ArmourAttribute(string value) : base(value)
        {
        }
    }

    #region BodyArmour

    internal class BodyArmourAttribute : ArmourAttribute
    {
        protected BodyArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class BodyArmourArmourAttribute : BodyArmourAttribute
    {
        public BodyArmourArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class BodyArmourEvasionAttribute : BodyArmourAttribute
    {
        public BodyArmourEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class BodyArmourEnergyShieldAttribute : BodyArmourAttribute
    {
        public BodyArmourEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class BodyArmourArmourEvasionAttribute : BodyArmourAttribute
    {
        public BodyArmourArmourEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class BodyArmourArmourEnergyShieldAttribute : BodyArmourAttribute
    {
        public BodyArmourArmourEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class BodyArmourEnergyShieldEvasionAttribute : BodyArmourAttribute
    {
        public BodyArmourEnergyShieldEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class BodyArmourArmourEvasionEnergyShieldAttribute : BodyArmourAttribute
    {
        public BodyArmourArmourEvasionEnergyShieldAttribute(string value) : base(value)
        {
        }
    }


    #endregion

    #region Boot

    internal class BootAttribute : ArmourAttribute
    {
        protected BootAttribute(string value) : base(value)
        {
        }
    }

    internal class BootArmourAttribute : BootAttribute
    {
        public BootArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class BootEvasionAttribute : BootAttribute
    {
        public BootEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class BootEnergyShieldAttribute : BootAttribute
    {
        public BootEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class BootArmourEvasionAttribute : BootAttribute
    {
        public BootArmourEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class BootArmourEnergyShieldAttribute : BootAttribute
    {
        public BootArmourEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class BootEnergyShieldEvasionAttribute : BootAttribute
    {
        public BootEnergyShieldEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class BootArmourEvasionEnergyShieldAttribute : BootAttribute
    {
        public BootArmourEvasionEnergyShieldAttribute(string value) : base(value)
        {
        }
    }


    #endregion

    #region Glove

    internal class GloveAttribute : ArmourAttribute
    {
        protected GloveAttribute(string value) : base(value)
        {
        }
    }

    internal class GloveArmourAttribute : GloveAttribute
    {
        public GloveArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class GloveEvasionAttribute : GloveAttribute
    {
        public GloveEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class GloveEnergyShieldAttribute : GloveAttribute
    {
        public GloveEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class GloveArmourEvasionAttribute : GloveAttribute
    {
        public GloveArmourEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class GloveArmourEnergyShieldAttribute : GloveAttribute
    {
        public GloveArmourEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class GloveEnergyShieldEvasionAttribute : GloveAttribute
    {
        public GloveEnergyShieldEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class GloveArmourEvasionEnergyShieldAttribute : GloveAttribute
    {
        public GloveArmourEvasionEnergyShieldAttribute(string value) : base(value)
        {
        }
    }


    #endregion

    #region Helmet

    internal class HelmetAttribute : ArmourAttribute
    {
        protected HelmetAttribute(string value) : base(value)
        {
        }
    }

    internal class HelmetArmourAttribute : HelmetAttribute
    {
        public HelmetArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class HelmetEvasionAttribute : HelmetAttribute
    {
        public HelmetEvasionAttribute(string value) : base(value)
        {
        }
    }
    
    internal class HelmetEnergyShieldAttribute : HelmetAttribute
    {
        public HelmetEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class HelmetArmourEvasionAttribute : HelmetAttribute
    {
        public HelmetArmourEvasionAttribute(string value) : base(value)
        {
        }
    }
    
    internal class HelmetArmourEnergyShieldAttribute : HelmetAttribute
    {
        public HelmetArmourEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class HelmetEnergyShieldEvasionAttribute : HelmetAttribute
    {
        public HelmetEnergyShieldEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class HelmetArmourEvasionEnergyShieldAttribute : HelmetAttribute
    {
        public HelmetArmourEvasionEnergyShieldAttribute(string value) : base(value)
        {
        }
    }


    #endregion

    #region Shield

    internal class ShieldAttribute : ArmourAttribute
    {
        protected ShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class ShieldArmourAttribute : ShieldAttribute
    {
        public ShieldArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class ShieldEvasionAttribute : ShieldAttribute
    {
        public ShieldEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class ShieldEnergyShieldAttribute : ShieldAttribute
    {
        public ShieldEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class ShieldArmourEvasionAttribute : ShieldAttribute
    {
        public ShieldArmourEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class ShieldArmourEnergyShieldAttribute : ShieldAttribute
    {
        public ShieldArmourEnergyShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class ShieldEnergyShieldEvasionAttribute : ShieldAttribute
    {
        public ShieldEnergyShieldEvasionAttribute(string value) : base(value)
        {
        }
    }

    internal class ShieldArmourEvasionEnergyShieldAttribute : ShieldAttribute
    {
        public ShieldArmourEvasionEnergyShieldAttribute(string value) : base(value)
        {
        }
    }


    #endregion

    #endregion
}