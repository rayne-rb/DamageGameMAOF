namespace DamageCalculatorMAOF.DamageGame;

//Low HP: 80 - 160 Medium HP: 160 - 240 High HP: 240 - 320
//Low AP: 40 - 60 Medium AP: 80 - 100 High AP: 120 - 160

//Low WW: 4 - 7 Medium WW: 8 - 12 High WW: 13 - 16

public class Gulemark
{
    public float hp = 320f;
    public float armour = 40f;
    public float strength = 18f;
    public float agility = 2f;
    public float weaponWeight = 15f;
    public PhysicalDamageTypes physType = PhysicalDamageTypes.Blunt;
    public string weaponName = "The Tenderiser";
}

public class Raikin
{
    public float hp = 80;
    public float armour = 30f;
    public float higherAgility = 12f;
    public float LowerAgility = 6f;
    public float lowerStrength = 12f;
    public float higherStrength = 18f;
    public float weaponWeight = 13f;
    public PhysicalDamageTypes spoonLight = PhysicalDamageTypes.Slash;
    public PhysicalDamageTypes spoonHeavy = PhysicalDamageTypes.Chop;
}