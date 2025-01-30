// See https://aka.ms/new-console-template for more information

using DamageCalculatorMAOF.DamageGame;


float weaponWeight =12f;
float strength = 24f;
float heatlhValue = 100f;
float armourValue = 100f;
float agilityValue = 5f;
PhysicalDamageTypes weaponDamageType = PhysicalDamageTypes.Stab;

float armourDamageModifier = DamageModifier.ApDamageModifier(weaponDamageType);
float healthDamageModifier = DamageModifier.HpDamageModifier(weaponDamageType);
float damage = DamageCalculator.TrueDamageCalculator(strength, weaponWeight);
float newArmourValue = DamageCalculator.ApDamage(damage, armourValue, armourDamageModifier);
float remainingDamage = DamageCalculator.CalculatedRemainingDamage(damage, armourValue, armourDamageModifier);
float newHealthValue = DamageCalculator.HpDamage(remainingDamage, heatlhValue, newArmourValue, healthDamageModifier);
float attackSpeed = DamageCalculator.AttackSpeedCalculator(strength, weaponWeight, agilityValue);
float damagePerSecond = DamageCalculator.DpsCalculator(attackSpeed, damage);

Console.WriteLine($"Weapon Weight: {weaponWeight}");
Console.WriteLine($"Character Strength: {strength}");
Console.WriteLine($"Starting Health Points: {heatlhValue}");
Console.WriteLine($"Starting Armour Points: {armourValue}");
Console.WriteLine($"Weapon Damage Type: {weaponDamageType.ToString()}");
Console.WriteLine($"Calculated Damage: {damage}");
Console.WriteLine($"Attack Speed: {attackSpeed}");
Console.WriteLine($"Damage Per Second: {damagePerSecond}");
Console.WriteLine("");
if (remainingDamage != damage)
{
    Console.WriteLine($"Remaining Damage: {remainingDamage}");
}
else
{
    Console.WriteLine($"Damage did not breach armour");
}
Console.WriteLine($"Armour Damage Modifier: {armourDamageModifier}");
Console.WriteLine($"Health Damage Modifier: {healthDamageModifier}");
Console.WriteLine($"Armour Points After Damage: {newArmourValue}");
Console.WriteLine($"Health Points After Damage: {newHealthValue}");

