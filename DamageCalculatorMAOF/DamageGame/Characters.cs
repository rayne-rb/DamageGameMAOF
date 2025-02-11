namespace DamageCalculatorMAOF.DamageGame;

//Low HP: 80 - 160 Medium HP: 160 - 240 High HP: 240 - 320
//Low AP: 40 - 60 Medium AP: 80 - 100 High AP: 120 - 160

//Low WW: 4 - 7 Medium WW: 8 - 12 High WW: 13 - 16
//Low CW: 24 - 36 Medium CW: 37 - 48 High CW: 49 - 72

public class Characters
{
    public float Health;
    public float Armour;
    public float CharacterWeight;
    public float Strength;
    public float Agility;
    public float WeaponWeight;
    public PhysicalDamageTypes WeaponType;
    public string WeaponName;
    public string CharacterName;

    public Characters(float hp, float ar, float cw, float st, float ag, float ww, PhysicalDamageTypes wt, string wn,
        string ch)
    {
        Health = hp;
        Armour = ar;
        CharacterWeight = cw;
        Strength = st;
        Agility = ag;
        WeaponWeight = ww;
        WeaponType = wt;
        WeaponName = wn;
        CharacterName = ch;
    }

    public float GetTrueDamage()
    {
        float damage = DamageCalculator.TrueDamageCalculator(Strength, WeaponWeight, WeaponType);
        return damage;
    }

    public float GetAttackSpeed()
    {
        float atkSpeed = DamageCalculator.AttackSpeedCalculator(Strength, WeaponWeight, Agility);
        return atkSpeed;
    }

    public float GetDps()
    {
        float dps = DamageCalculator.DpsCalculator(GetAttackSpeed(), GetTrueDamage());
        return dps;
    }

    public float GetMoveSpeed()
    {
        float moveSpeed = (5f * Agility) / CharacterWeight;
        return moveSpeed;
    }

    public float GetCharacterForce()
    {
        float characterForce = CharacterWeight + Strength;
        return characterForce;
    }

    public float GetArDamageMod()
    {
        float damageMod = DamageModifier.ApDamageModifier(WeaponType);
        return damageMod;
    }

    public float GetHpDamageMod()
    {
        float damageMod = DamageModifier.HpDamageModifier(WeaponType);
        return damageMod;
    }

    public void GetCharacterDetails()
    {
        Console.WriteLine($"Character Name: {CharacterName}\n");

        Console.WriteLine($"Health Points:          {Health}");
        Console.WriteLine($"Armour Points:          {Armour}");
        Console.WriteLine($"Character Weight:       {CharacterWeight}");
        Console.WriteLine($"Character Force:        {GetCharacterForce()}\n");

        Console.WriteLine($"Weapon Name:            {WeaponName}");
        Console.WriteLine($"Weapon Weight:          {WeaponWeight}");
        Console.WriteLine($"Strength:               {Strength}");
        Console.WriteLine($"Weapon Damage Type:     {WeaponType.ToString()}");
        Console.WriteLine($"Calculated Damage:      {GetTrueDamage()}\n");

        Console.WriteLine($"Agility:                {Agility}");
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