// FireEnemy.cs

using System;

public class FireEnemy : Enemy {
    private static readonly Random rand = new Random();
    private double burnChance;

    public FireEnemy(string name, int health, int attackPower, int defense, double burnChance) 
        : base(name, health, attackPower, defense) {
        this.burnChance = burnChance;
    }

    public override void Attack(Player player) {
        if (rand.NextDouble() < burnChance) {
            player.Health -= AttackPower;
            Console.WriteLine($"{Name} attacks with fire, causing burn!");
        } else {
            Console.WriteLine($"{Name} attacks with fire!");
        }
    }

    public override void TakeDamage(int damage) {
        Health -= damage;
        if (Health <= 0) {
            Console.WriteLine($"{Name} defeated!");
        }
    }
}
