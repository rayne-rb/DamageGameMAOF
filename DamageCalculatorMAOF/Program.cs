using DamageCalculatorMAOF.DamageGame;

Gulemark gulemark = new Gulemark();
Raikin raikin = new Raikin();

string userInputString = string.Empty;

//attacking character
float weaponWeight = raikin.weaponWeight;
float strength = raikin.strength;
PhysicalDamageTypes weaponDamageType = raikin.physType;
float agilityValue = raikin.agility;

//targeted character
float heatlhValue = gulemark.hp;
float armourValue = gulemark.armour;

while (heatlhValue > 0)
{
    float armourDamageModifier = DamageModifier.ApDamageModifier(weaponDamageType);
    float healthDamageModifier = DamageModifier.HpDamageModifier(weaponDamageType);
    float damage = DamageCalculator.TrueDamageCalculator(strength, weaponWeight);
    float newArmourValue = DamageCalculator.ApDamage(damage, armourValue, armourDamageModifier);
    float remainingDamageAfterArmour = DamageCalculator.CalculatedRemainingDamage(damage, armourValue, armourDamageModifier);
    float newHealthValue =
        DamageCalculator.HpDamage(remainingDamageAfterArmour, heatlhValue, newArmourValue, healthDamageModifier);
    float remainingDamageAfterHealth = remainingDamageAfterArmour - heatlhValue;
    float attackSpeed = DamageCalculator.AttackSpeedCalculator(strength, weaponWeight, agilityValue);
    float damagePerSecond = DamageCalculator.DpsCalculator(attackSpeed, damage);
    
    Console.WriteLine($"Targeted Character Starting Health Points:  {heatlhValue}");
    Console.WriteLine($"Targeted Character Starting Armour Points:  {armourValue}");
    Console.WriteLine("");
    Console.WriteLine($"Attacking Character Weapon Weight:          {weaponWeight}");
    Console.WriteLine($"Attacking Character Strength:               {strength}");
    Console.WriteLine($"Attacking Character Weapon Damage Type:     {weaponDamageType.ToString()}");
    Console.WriteLine($"Attacking Character Calculated Damage:      {damage}");
    Console.WriteLine($"Attacking Character Attack Speed:           {attackSpeed}");
    Console.WriteLine($"Attacking Character Damage Per Second:      {damagePerSecond}");
    Console.WriteLine("");
    Console.WriteLine($"Attacking Character Armour Damage Modifier: {armourDamageModifier}");
    Console.WriteLine($"Attacking Character Health Damage Modifier: {healthDamageModifier}");
    Console.WriteLine("");
    
    if (remainingDamageAfterArmour != damage)
    {
        Console.WriteLine($"Damage Remaining After Armour:              {remainingDamageAfterArmour}");
    }
    else
    {
        Console.WriteLine($"Damage did not breach armour");
    }
    
    if (newHealthValue > 0)
    {
        Console.WriteLine("");
        Console.WriteLine($"Targeted Character Armour Points After Damage: {newArmourValue}");
        Console.WriteLine($"Targeted Character Health Points After Damage: {newHealthValue}");
        while (userInputString != "Exit")
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to deal damage again? (y/n)");
            userInputString = Console.ReadLine();

            if (userInputString == "y")
            {
                heatlhValue = newHealthValue;
                armourValue = newArmourValue;
                userInputString = "Exit";
            }
            else if (userInputString == "n")
            {
                Console.WriteLine("Damage Calculator Stopped");
                heatlhValue = 0;
                userInputString = "Exit";
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        userInputString = string.Empty;
    }
    else
    {
        heatlhValue = 0;
        Console.WriteLine($"Targeted Character Armour Points After Damage:  {newArmourValue}");
        Console.WriteLine($"Targeted Character Health Points After Damage:  {newHealthValue}");
        Console.WriteLine($"Remaining Damage:                               {remainingDamageAfterHealth}");
        Console.WriteLine("");
    }
    
}
Console.WriteLine("Damage Calculator Stopped");