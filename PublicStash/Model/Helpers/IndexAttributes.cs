using System;
using System.Collections.Generic;
using System.Reflection;

namespace PathOfExile.Model.Internal
{
    public static class AttributeHelper
    {
        private static IDictionary<Type, IDictionary<string, Type>> IndexCache { get; }

        static AttributeHelper() => IndexCache = new Dictionary<Type, IDictionary<string, Type>>();

        internal static IDictionary<string, Type> Index<T>() where T : ItemAttribute
        {
            if (IndexCache.TryGetValue(typeof(T), out var dict)) return dict;
            var typeDict = new Dictionary<string, Type>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {
                    var value = type.GetCustomAttribute<T>()?.Value;
                    if (!string.IsNullOrEmpty(value))
                    {
                        typeDict.Add(value, type);
                    }
                }
            }

            IndexCache.Add(typeof(T), typeDict);
            return typeDict;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    internal class ItemAttribute : Attribute
    {
        public string Value { get; }

        protected ItemAttribute(string value)
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

    internal class TwoHandWeaponAttribute : WeaponAttribute
    {
        protected TwoHandWeaponAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandSwordAttribute : TwoHandWeaponAttribute
    {
        public TwoHandSwordAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandAxeAttribute : TwoHandWeaponAttribute
    {
        public TwoHandAxeAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandMaceAttribute : TwoHandWeaponAttribute
    {
        public TwoHandMaceAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandBowAttribute : TwoHandWeaponAttribute
    {
        public TwoHandBowAttribute(string value) : base(value)
        {
        }
    }

    internal class TwoHandStaffAttribute : TwoHandWeaponAttribute
    {
        public TwoHandStaffAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region One Handed

    internal class OneHandWeaponAttribute : WeaponAttribute
    {
        protected OneHandWeaponAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandSwordAttribute : OneHandWeaponAttribute
    {
        public OneHandSwordAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandThrustingSwordAttribute : OneHandWeaponAttribute
    {
        public OneHandThrustingSwordAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandAxeAttribute : OneHandWeaponAttribute
    {
        public OneHandAxeAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandMaceAttribute : OneHandWeaponAttribute
    {
        public OneHandMaceAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandDaggerAttribute : OneHandWeaponAttribute
    {
        public OneHandDaggerAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandClawAttribute : OneHandWeaponAttribute
    {
        public OneHandClawAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandWandAttribute : OneHandWeaponAttribute
    {
        public OneHandWandAttribute(string value) : base(value)
        {
        }
    }

    internal class OneHandSceptreAttribute : OneHandWeaponAttribute
    {
        public OneHandSceptreAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #endregion

    #region Accessory

    internal class AccessoryAttribute : ItemAttribute
    {
        protected AccessoryAttribute(string value) : base(value)
        {
        }
    }

    #region Ring

    internal class RingAttribute : AccessoryAttribute
    {
        public RingAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Belt

    internal class BeltAttribute : AccessoryAttribute
    {
        public BeltAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Amulet

    internal class AmuletAttribute : AccessoryAttribute
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

    internal class ArmourBodyArmourAttribute : BodyArmourAttribute
    {
        public ArmourBodyArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class EvasionBodyArmourAttribute : BodyArmourAttribute
    {
        public EvasionBodyArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldBodyArmourAttribute : BodyArmourAttribute
    {
        public EnergyShieldBodyArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEvasionBodyArmourAttribute : BodyArmourAttribute
    {
        public ArmourEvasionBodyArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEnergyShieldBodyArmourAttribute : BodyArmourAttribute
    {
        public ArmourEnergyShieldBodyArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldEvasionBodyArmourAttribute : BodyArmourAttribute
    {
        public EnergyShieldEvasionBodyArmourAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEvasionEnergyShieldBodyArmourAttribute : BodyArmourAttribute
    {
        public ArmourEvasionEnergyShieldBodyArmourAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Boots

    internal class BootsAttribute : ArmourAttribute
    {
        protected BootsAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourBootsAttribute : BootsAttribute
    {
        public ArmourBootsAttribute(string value) : base(value)
        {
        }
    }

    internal class EvasionBootsAttribute : BootsAttribute
    {
        public EvasionBootsAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldBootsAttribute : BootsAttribute
    {
        public EnergyShieldBootsAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEvasionBootsAttribute : BootsAttribute
    {
        public ArmourEvasionBootsAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEnergyShieldBootsAttribute : BootsAttribute
    {
        public ArmourEnergyShieldBootsAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldEvasionBootsAttribute : BootsAttribute
    {
        public EnergyShieldEvasionBootsAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Gloves

    internal class GlovesAttribute : ArmourAttribute
    {
        protected GlovesAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourGlovesAttribute : GlovesAttribute
    {
        public ArmourGlovesAttribute(string value) : base(value)
        {
        }
    }

    internal class EvasionGlovesAttribute : GlovesAttribute
    {
        public EvasionGlovesAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldGlovesAttribute : GlovesAttribute
    {
        public EnergyShieldGlovesAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEvasionGlovesAttribute : GlovesAttribute
    {
        public ArmourEvasionGlovesAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEnergyShieldGlovesAttribute : GlovesAttribute
    {
        public ArmourEnergyShieldGlovesAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldEvasionGlovesAttribute : GlovesAttribute
    {
        public EnergyShieldEvasionGlovesAttribute(string value) : base(value)
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

    internal class ArmourHelmetAttribute : HelmetAttribute
    {
        public ArmourHelmetAttribute(string value) : base(value)
        {
        }
    }

    internal class EvasionHelmetAttribute : HelmetAttribute
    {
        public EvasionHelmetAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldHelmetAttribute : HelmetAttribute
    {
        public EnergyShieldHelmetAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEvasionHelmetAttribute : HelmetAttribute
    {
        public ArmourEvasionHelmetAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEnergyShieldHelmetAttribute : HelmetAttribute
    {
        public ArmourEnergyShieldHelmetAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldEvasionHelmetAttribute : HelmetAttribute
    {
        public EnergyShieldEvasionHelmetAttribute(string value) : base(value)
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

    internal class ArmourShieldAttribute : ShieldAttribute
    {
        public ArmourShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class EvasionShieldAttribute : ShieldAttribute
    {
        public EvasionShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldShieldAttribute : ShieldAttribute
    {
        public EnergyShieldShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEvasionShieldAttribute : ShieldAttribute
    {
        public ArmourEvasionShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class ArmourEnergyShieldShieldAttribute : ShieldAttribute
    {
        public ArmourEnergyShieldShieldAttribute(string value) : base(value)
        {
        }
    }

    internal class EnergyShieldEvasionShieldAttribute : ShieldAttribute
    {
        public EnergyShieldEvasionShieldAttribute(string value) : base(value)
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

    #region Jewel

    internal class JewelAttribute : ItemAttribute
    {
        public JewelAttribute(string value) : base(value)
        {
        }
    }

    internal class AbyssJewelAttribute : JewelAttribute
    {
        public AbyssJewelAttribute(string value) : base(value)
        {
        }
    }

    internal class ClusterJewelAttribute : JewelAttribute
    {
        public ClusterJewelAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Quiver

    internal class QuiverAttribute : ItemAttribute
    {
        public QuiverAttribute(string value) : base(value)
        {
        }
    }

    #endregion

    #region Map

    internal class MapAttribute : ItemAttribute
    {
        public MapAttribute(string value) : base(value)
        {
        }
    }

    internal class BlightMapAttribute : MapAttribute
    {
        public BlightMapAttribute(string value) : base(value)
        {
        }
    }

    internal class ScarabAttribute : MapAttribute
    {
        public ScarabAttribute(string value) : base(value)
        {
        }
    }    
    
    internal class BreachstoneAttribute : MapAttribute
    {
        public BreachstoneAttribute(string value) : base(value)
        {
        }
    }

    internal class LegionEmblemAttribute : MapAttribute
    {
        public LegionEmblemAttribute(string value) : base(value)
        {
        }
    }

    internal class InvitationAttribute : MapAttribute
    {
        public InvitationAttribute(string value) : base(value)
        {
        }
    }

    #endregion
}