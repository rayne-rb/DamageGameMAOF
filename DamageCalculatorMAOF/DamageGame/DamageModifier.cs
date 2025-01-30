namespace DamageCalculatorMAOF.DamageGame;

public static class DamageModifier
{
    public static float ApDamageModifier(PhysicalDamageTypes physDamage = PhysicalDamageTypes.None,
        ElementalDamageTypes eleDamage = ElementalDamageTypes.None, UniqueDamageTypes uniqueDamage = UniqueDamageTypes.None)
    {
        float armourModifier = 0;
        
        switch (physDamage)
        {
            case PhysicalDamageTypes.Stab:
                armourModifier = 0.45f;
                break;
            case PhysicalDamageTypes.Slash:
                armourModifier = 0.65f;
                break;
            case PhysicalDamageTypes.Blunt:
                armourModifier = 0.35f;
                break;
            case PhysicalDamageTypes.Pierce:
                armourModifier = 0.25f;
                break;
            case PhysicalDamageTypes.Chop:
                armourModifier = 0.85f;
                break;
            case PhysicalDamageTypes.Rip:
                armourModifier = 0.75f;
                break;
            case PhysicalDamageTypes.None:
                break;
            
        }
    
        switch (eleDamage)
        {
            case ElementalDamageTypes.Fire:
                armourModifier = 0.45f;
                break;
            case ElementalDamageTypes.Electricity:
                armourModifier = 0.1f;
                break;
            case ElementalDamageTypes.Wind:
                armourModifier = 0.1f;
                break;
            case ElementalDamageTypes.Poison:
                armourModifier = 0.0f;
                break;
            case ElementalDamageTypes.Acid:
                armourModifier = 1f;
                break;
            case ElementalDamageTypes.None:
                break;
        }
    
        switch (uniqueDamage)
        {
            case UniqueDamageTypes.Bleed:
                armourModifier = 0f;
                break;
            case UniqueDamageTypes.Explosion:
                armourModifier = 0.75f;
                break;
            case UniqueDamageTypes.Raw:
                armourModifier = 1f;
                break;
            case UniqueDamageTypes.None:
                break;
        }
        
        return armourModifier;
    }
    
    public static float HpDamageModifier(PhysicalDamageTypes physDamage = PhysicalDamageTypes.None,
        ElementalDamageTypes eleDamage = ElementalDamageTypes.None, UniqueDamageTypes uniqueDamage = UniqueDamageTypes.None)
    {
        float healthModifier = 0;
        
                switch (physDamage)
        {
            case PhysicalDamageTypes.Stab:
                healthModifier = 0.15f;
                break;
            case PhysicalDamageTypes.Slash:
                healthModifier = 0.1f;
                break;
            case PhysicalDamageTypes.Blunt:
                healthModifier = 0.55f;
                break;
            case PhysicalDamageTypes.Pierce:
                healthModifier = 0.85f;
                break;
            case PhysicalDamageTypes.Chop:
                healthModifier = 0.25f;
                break;
            case PhysicalDamageTypes.Rip:
                healthModifier = 0.05f;
                break;
            case PhysicalDamageTypes.None:
                break;
            
        }
    
        switch (eleDamage)
        {
            case ElementalDamageTypes.Fire:
                healthModifier = 0.1f;
                break;
            case ElementalDamageTypes.Electricity:
                healthModifier = 0.85f;
                break;
            case ElementalDamageTypes.Wind:
                healthModifier = 0.65f;
                break;
            case ElementalDamageTypes.Poison:
                healthModifier = 0.8f;
                break;
            case ElementalDamageTypes.Acid:
                healthModifier = 0f;
                break;
            case ElementalDamageTypes.None:
                break;
        }
    
        switch (uniqueDamage)
        {
            case UniqueDamageTypes.Bleed:
                healthModifier = 0f;
                break;
            case UniqueDamageTypes.Explosion:
                healthModifier = 0.75f;
                break;
            case UniqueDamageTypes.Raw:
                healthModifier = 1f;
                break;
            case UniqueDamageTypes.None:
                break;
        }
        
        return healthModifier;
    }
}