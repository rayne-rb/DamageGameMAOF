using DamageCalculatorMAOF.DamageGame;

bool Cancelled = false;

Characters gulemark =
    new Characters(320f, 40f, 60f, 18f, 5f, 15f, PhysicalDamageTypes.Blunt, "The Tenderiser", "Gulemark");
Characters raikin = new Characters(100f, 30f, 30f, 16f, 12f, 14f, PhysicalDamageTypes.Slash, "War Spoon", "Raikin");
Characters thimble = new Characters(80f, 30f, 24f, 8f, 12f, 9f, PhysicalDamageTypes.Stab, "Throwing Needle", "Thimble");
Characters jack = new Characters(150f, 80f, 37f, 10f, 7f, 8f, PhysicalDamageTypes.Blunt, "Jaffle Iron",
    "Jack the Jaffler");

string userInputString = string.Empty;
bool battled = false;

//Character 1
var character1 = thimble;
float remainingDamage1 = 0f;
float ogArmour1 = character1.armour;

//Character 2
var character2 = jack;
float remainingDamage2 = 0f;
float ogArmour2 = character2.armour;

while (character1.health > 0 && character2.health > 0)
{
    character1.GetCharacterDetails();

    character2.GetCharacterDetails();

    while (userInputString != "y" && userInputString != "n")
    {
        if (battled)
        {
            Console.WriteLine($"Battle Characters Again? (y/n)");
        }
        else
        {
            Console.WriteLine($"Battle Characters? (y/n)");
        }

        userInputString = Console.ReadLine();

        if (!(userInputString == "y" || userInputString == "n"))
            Console.WriteLine("Input Invalid");
    }

    if (userInputString == "n")
    {
        character1.health = 0;
        character2.health = 0;
        Cancelled = true;
        Console.WriteLine("");
        Console.WriteLine("Damage Calculator Stopped");
    }

    if (userInputString == "y")
    {
        ogArmour1 = character1.armour;
        character1.armour = DamageCalculator.ApDamage(character2.GetTrueDamage(), character1.armour, character2.GetArDamageMod());
        remainingDamage2 = DamageCalculator.CalculatedRemainingDamage(character2.GetTrueDamage(), ogArmour1, character2.GetArDamageMod());
        character1.health = DamageCalculator.HpDamage(remainingDamage2, character1.health, character1.armour, character2.GetHpDamageMod());
        
        ogArmour2 = character2.armour;
        character2.armour = DamageCalculator.ApDamage(character1.GetTrueDamage(), character2.armour, character1.GetArDamageMod());
        remainingDamage1 = DamageCalculator.CalculatedRemainingDamage(character1.GetTrueDamage(), ogArmour2, character1.GetArDamageMod());
        character2.health = DamageCalculator.HpDamage(remainingDamage1, character2.health, character2.armour, character1.GetHpDamageMod());
    }
    
    userInputString = string.Empty;
}

if (!Cancelled)
{
    character1.GetCharacterDetails();
    character2.GetCharacterDetails();
    Console.WriteLine("");
    if (character1.health > 0)
    {
        Console.WriteLine($"{character1.characterName} Wins!");
    }
    
    if (character2.health > 0)
    {
        Console.WriteLine($"{character2.characterName} Wins!");
    }
    
    if (character1.health == character2.health)
    {
        Console.WriteLine("It's a Draw!");
    }
    Console.WriteLine("");
    Console.WriteLine("Damage Calculator Stopped");
}

// //attacking character
// float weaponWeight = Raikin.weaponWeight;
// float strength = Raikin.higherStrength;
// PhysicalDamageTypes weaponDamageType = Raikin.spoonHeavy;
// float agilityValue = Raikin.LowerAgility;
// float characterWeight = Raikin.characterWeight;
// float characterForce = Raikin.characterForce;
//
//
// //targeted character
// float heatlhValue = Gulemark.hp;
// float armourValue = Gulemark.armour;
//
// while (heatlhValue > 0)
// {
//     float armourDamageModifier = DamageModifier.ApDamageModifier(weaponDamageType);
//     float healthDamageModifier = DamageModifier.HpDamageModifier(weaponDamageType);
//     float damage = DamageCalculator.TrueDamageCalculator(strength, weaponWeight);
//     float newArmourValue = DamageCalculator.ApDamage(damage, armourValue, armourDamageModifier);
//     float remainingDamageAfterArmour = DamageCalculator.CalculatedRemainingDamage(damage, armourValue, armourDamageModifier);
//     float newHealthValue =
//         DamageCalculator.HpDamage(remainingDamageAfterArmour, heatlhValue, newArmourValue, healthDamageModifier);
//     float remainingDamageAfterHealth = remainingDamageAfterArmour - heatlhValue;
//     float attackSpeed = DamageCalculator.AttackSpeedCalculator(strength, weaponWeight, agilityValue);
//     float damagePerSecond = DamageCalculator.DpsCalculator(attackSpeed, damage);
//     
//     Console.WriteLine($"Targeted Character Starting Health Points:  {heatlhValue}");
//     Console.WriteLine($"Targeted Character Starting Armour Points:  {armourValue}");
//     Console.WriteLine("");
//     Console.WriteLine($"Attacking Character Weapon Weight:          {weaponWeight}");
//     Console.WriteLine($"Attacking Character Strength:               {strength}");
//     Console.WriteLine($"Attacking Character Weapon Damage Type:     {weaponDamageType.ToString()}");
//     Console.WriteLine($"Attacking Character Calculated Damage:      {damage}");
//     Console.WriteLine($"Attacking Character Agility:                {agilityValue}");
//     Console.WriteLine($"Attacking Character Attack Speed:           {attackSpeed}");
//     Console.WriteLine($"Attacking Character Damage Per Second:      {damagePerSecond}");
//     Console.WriteLine("");
//     Console.WriteLine($"Attacking Character Armour Damage Modifier: {armourDamageModifier}");
//     Console.WriteLine($"Attacking Character Health Damage Modifier: {healthDamageModifier}");
//     Console.WriteLine("");
//     
//     if (remainingDamageAfterArmour != damage)
//     {
//         Console.WriteLine($"Damage Remaining After Armour:              {remainingDamageAfterArmour}");
//     }
//     else
//     {
//         Console.WriteLine($"Damage did not breach armour");
//     }
//     
//     if (newHealthValue > 0)
//     {
//         Console.WriteLine("");
//         Console.WriteLine($"Targeted Character Armour Points After Damage: {newArmourValue}");
//         Console.WriteLine($"Targeted Character Health Points After Damage: {newHealthValue}");
//         while (userInputString != "Exit")
//         {
//             Console.WriteLine("");
//             Console.WriteLine("Would you like to deal damage again? (y/n)");
//             userInputString = Console.ReadLine();
//
//             if (userInputString == "y")
//             {
//                 heatlhValue = newHealthValue;
//                 armourValue = newArmourValue;
//                 userInputString = "Exit";
//             }
//             else if (userInputString == "n")
//             {
//                 heatlhValue = 0;
//                 userInputString = "Exit";
//             }
//             else
//             {
//                 Console.WriteLine("Invalid Input");
//             }
//         }
//         userInputString = string.Empty;
//     }
//     else
//     {
//         heatlhValue = 0;
//         Console.WriteLine($"Targeted Character Armour Points After Damage:  {newArmourValue}");
//         Console.WriteLine($"Targeted Character Health Points After Damage:  {newHealthValue}");
//         Console.WriteLine($"Remaining Damage:                               {remainingDamageAfterHealth}");
//         Console.WriteLine("");
//     }
//     
// }
// Console.WriteLine("Damage Calculator Stopped");