namespace DamageCalculatorMAOF.DamageGame;

public static class DamageCalculator
{
    public static float TrueDamageCalculator(float strength, float weaponWeight, PhysicalDamageTypes phystype = PhysicalDamageTypes.None)
    {
        var trueDamage = (strength + weaponWeight) * 2f;
        
        // Low strength: 6 - 11, medium strength: 12 - 17, high strength: 18 - 24
        switch (phystype)
        {
            case PhysicalDamageTypes.Stab:
                if(strength < 6f)
                    trueDamage *= 0.75f;
                break;
            case PhysicalDamageTypes.Slash:
                if(strength < 6f)
                    trueDamage *= 0.75f;
                break;
            case PhysicalDamageTypes.Blunt:
                if(strength < 12f)
                    trueDamage *= 0.85f;
                break;
            case PhysicalDamageTypes.Pierce:
                if(strength < 18f)
                    trueDamage *= 0.75f;
                break;
            case PhysicalDamageTypes.Chop:
                if(strength < 18f)
                    trueDamage *= 0.75f;
                break;
            case PhysicalDamageTypes.Rip:
                if(strength < 12f)
                    trueDamage *= 0.85f;
                break;
            case PhysicalDamageTypes.None:
                break;
        }
        
        if (weaponWeight >= strength)
        {
            trueDamage -= weaponWeight * 2f;
        }
        return trueDamage;
    }

    public static float AttackSpeedCalculator(float strength, float weaponWeight, float agility)
    {
        var attackSpeed = (agility * strength) / (2f * weaponWeight);

        return attackSpeed;
    }

    public static float DpsCalculator(float attackSpeed, float damage)
    {
        var dps = damage * attackSpeed;
        
        return dps;
    }
    
    public static float CalculatedRemainingDamage(float damage, float armour, float armourDamageModifier)
    {
        var ogArmour = armour;
        var newDamage = damage;
    
        if (armour > 0)
        {
            armour -= damage * armourDamageModifier;
        }
        if (armour <= 0)
        {
            newDamage -= ogArmour;
        }
        return newDamage;
    }
    
    public static float ApDamage(float damage, float armour, float armourDamageModifier)
    {
        var ogArmour = armour;
        var newDamage = damage;
    
        if (armour > 0)
        {
            armour -= damage * armourDamageModifier;
        }
        if (armour <= 0)
        {
            armour = 0;
        }
        return armour;
    }

    public static float HpDamage(float damage, float health, float armour, float healthDamageModifier)
    {
        if (armour > 0)
        {
            health -= damage * healthDamageModifier;
        }
        if (armour == 0)
        {
            health -= damage;
        }
        if (health <= 0)
            health = 0;

        return health;
    }

    // static float OldHpDamageCalculator(float ogDamage, float hp, float armour) 
    // {
    //     var ogArmour = armour;
    //     var newDamage = ogDamage;
    //
    //     if (armour > 0)
    //     {
    //         armour -= (float)(ogDamage * 0.45);
    //         hp -= (float)(ogDamage * 0.10);
    //     }
    //     if (armour <= 0)
    //     {
    //         armour = 0;
    //         newDamage -= ogArmour;
    //         hp -= newDamage;
    //     }
    //
    //     return hp;
    // }
    //
    // static float OldArmourDamageCalculator(float ogDamage, float armour) 
    // {
    //     var ogArmour = armour;
    //     var newDamage = ogDamage;
    //
    //     if (armour > 0)
    //     {
    //         armour -= (float)(ogDamage * 0.45);
    //     }
    //     if (armour <= 0)
    //     {
    //         armour = 0;
    //     }
    //
    //     return armour;
    // }
}