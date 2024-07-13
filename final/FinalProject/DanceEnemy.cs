using System;

class DanceEnemy : Enemy {
    private static readonly Random rand = new Random();
    private double doubleDamageChance; // Probability of dealing double damage (e.g., 0.2 for 20%)

    public DanceEnemy(int health, int attackPower, int defense, string name, double doubleDamageChance) 
        : base(health, attackPower, defense, name, "Dance") {
        this.doubleDamageChance = doubleDamageChance;
    }

    public override void Attack() {
        int damage = attackPower;
        if (rand.NextDouble() < doubleDamageChance) {
            damage *= 2;
            Console.WriteLine($"{name} deals double damage!");
        }
        Console.WriteLine($"{name} attacks for {damage} damage!");
        // Apply damage to target here
    }
}
