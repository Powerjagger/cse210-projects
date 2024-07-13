
using System;

public class HealthPotion : Item {
    private int healAmount;

    public HealthPotion(string name, string description, int value, int healAmount) 
        : base(name, description, value) {
        this.healAmount = healAmount;
    }

    public override void Use() {
        Console.WriteLine($"Used {Name}. Restored {healAmount} HP.");
    }
}
