namespace DamageCalculatorMAOF.DamageGame;

//Low HP: 80 - 160 Medium HP: 160 - 240 High HP: 240 - 320
//Low AP: 40 - 60 Medium AP: 80 - 100 High AP: 120 - 160

//Low WW: 4 - 7 Medium WW: 8 - 12 High WW: 13 - 16
//Low CW: 24 - 36 Medium CW: 37 - 48 High CW: 49 - 72

public class Characters
{
    public float health;
    public float armour;
    public float characterWeight;
    public float strength;
    public float agility;
    public float weaponWeight;
    public PhysicalDamageTypes weaponType;
    public string weaponName;
    public string characterName;

    public Characters(float hp, float ar, float cw, float st, float ag, float ww, PhysicalDamageTypes wt, string wn,
        string ch)
    {
        health = hp;
        armour = ar;
        characterWeight = cw;
        strength = st;
        agility = ag;
        weaponWeight = ww;
        weaponType = wt;
        weaponName = wn;
        characterName = ch;
    }

    public float GetTrueDamage()
    {
        float damage = DamageCalculator.TrueDamageCalculator(strength, weaponWeight, weaponType);
        return damage;
    }

    public float GetAttackSpeed()
    {
        float atkSpeed = DamageCalculator.AttackSpeedCalculator(strength, weaponWeight, agility);
        return atkSpeed;
    }

    public float GetDps()
    {
        float dps = DamageCalculator.DpsCalculator(GetAttackSpeed(), GetTrueDamage());
        return dps;
    }

    public float GetMoveSpeed()
    {
        float moveSpeed = (5f * agility) / characterWeight;
        return moveSpeed;
    }

    public float GetCharacterForce()
    {
        float characterForce = characterWeight * strength;
        return characterForce;
    }

    public float GetArDamageMod()
    {
        float damageMod = DamageModifier.ApDamageModifier(weaponType);
        return damageMod;
    }

    public float GetHpDamageMod()
    {
        float damageMod = DamageModifier.HpDamageModifier(weaponType);
        return damageMod;
    }

    public void GetCharacterDetails()
    {
        Console.WriteLine($"Character Name: {characterName}\n");

        Console.WriteLine($"Starting Health Points: {health}");
        Console.WriteLine($"Starting Armour Points: {armour}");
        Console.WriteLine($"Character Weight:       {characterWeight}\n");

        Console.WriteLine($"Weapon Name:            {weaponName}");
        Console.WriteLine($"Weapon Weight:          {weaponWeight}");
        Console.WriteLine($"Strength:               {strength}");
        Console.WriteLine($"Weapon Damage Type:     {weaponType.ToString()}");
        Console.WriteLine($"Calculated Damage:      {GetTrueDamage()}\n");

        Console.WriteLine($"Agility:                {agility}");
        Console.WriteLine($"Movement Speed:         {GetMoveSpeed()}");
        Console.WriteLine($"Attack Speed:           {GetAttackSpeed()}");
        Console.WriteLine($"Damage Per Second:      {GetDps()}\n");

        Console.WriteLine($"Armour Damage Modifier: {GetArDamageMod()}");
        Console.WriteLine($"Health Damage Modifier: {GetHpDamageMod()}\n");
        Console.WriteLine("-----------------------------------");
    }

    // public class Gulemark
    // {
    //     public static float hp = 320f;
    //     public static float armour = 40f;
    //     public static float characterWeight = 60f;
    //     public static float strength = 18f;
    //     public static float agility = 2f;
    //     public static float moveSpeed = (5f * agility) / characterWeight;
    //     public static float characterForce = characterWeight * strength;
    //     public static float weaponWeight = 15f;
    //     public static PhysicalDamageTypes physType = PhysicalDamageTypes.Blunt;
    //     public static string weaponName = "The Tenderiser";
    // }
    //
    // public class Raikin
    // {
    //     public static float hp = 80;
    //     public static float armour = 30f;
    //     public static float characterWeight = 30f;
    //     public static float higherAgility = 12f;
    //     public static float LowerAgility = 6f;
    //     public static float moveSpeed = (5f * higherAgility) / characterWeight;
    //     public static float lowerStrength = 12f;
    //     public static float higherStrength = 18f;
    //     public static float characterForce = characterWeight * higherStrength;
    //     public static float weaponWeight = 13f;
    //     public static PhysicalDamageTypes spoonLight = PhysicalDamageTypes.Slash;
    //     public static PhysicalDamageTypes spoonHeavy = PhysicalDamageTypes.Chop;
    // }
}