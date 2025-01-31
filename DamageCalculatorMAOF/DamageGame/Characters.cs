namespace DamageCalculatorMAOF.DamageGame;

//Low HP: 80 - 160 Medium HP: 160 - 240 High HP: 240 - 320
//Low AP: 40 - 60 Medium AP: 80 - 100 High AP: 120 - 160

//Low WW: 4 - 7 Medium WW: 8 - 12 High WW: 13 - 16
//Low CW: 24 - 36 Medium CW: 37 - 48 High CW: 49 - 72

public class Characters
{
    public static float hp;
    public static float armour;
    public static float characterWeight;
    public static float strength;
    public static float agility;
    public static float moveSpeed = (5f * agility) / characterWeight;
    public static float characterForce;
    public static float weaponWeight;
    public static PhysicalDamageTypes weaponType;
    public static string weaponName;

    public Characters(float hp, float armour, float characterWeight, float strength, float agility, float weaponWeight, PhysicalDamageTypes weaponType, string weaponName)
    {
        hp = Characters.hp;
        armour = Characters.armour;
        characterWeight = Characters.characterWeight;
        strength = Characters.strength;
        agility = Characters.agility;
        weaponWeight = Characters.weaponWeight;
        weaponType = Characters.weaponType;
        weaponName = Characters.weaponName;
    }
}

public class Gulemark
{
    public static float hp = 320f;
    public static float armour = 40f;
    public static float characterWeight = 60f;
    public static float strength = 18f;
    public static float agility = 2f;
    public static float moveSpeed = (5f * agility) / characterWeight;
    public static float characterForce = characterWeight * strength;
    public static float weaponWeight = 15f;
    public static PhysicalDamageTypes physType = PhysicalDamageTypes.Blunt;
    public static string weaponName = "The Tenderiser";
}

public class Raikin
{
    public static float hp = 80;
    public static float armour = 30f;
    public static float characterWeight = 30f;
    public static float higherAgility = 12f;
    public static float LowerAgility = 6f;
    public static float moveSpeed = (5f * higherAgility) / characterWeight;
    public static float lowerStrength = 12f;
    public static float higherStrength = 18f;
    public static float characterForce = characterWeight * higherStrength;
    public static float weaponWeight = 13f;
    public static PhysicalDamageTypes spoonLight = PhysicalDamageTypes.Slash;
    public static PhysicalDamageTypes spoonHeavy = PhysicalDamageTypes.Chop;
}