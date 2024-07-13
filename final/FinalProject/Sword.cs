// Sword.cs

using System;

public class Sword : NonConsumable {
    private int damageIncreaseAmount;

    public Sword(string name, string description, int value, int damageIncreaseAmount)
        : base(name, description, value) {
        this.damageIncreaseAmount = damageIncreaseAmount;
    }

    public override void Use() {
        // Apply the damage increase effect permanently or until replaced
        Console.WriteLine($"Used {Name}. Increased damage by {damageIncreaseAmount}.");
    }
}
