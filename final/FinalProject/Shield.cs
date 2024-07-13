// Shield.cs

using System;

public class Shield : NonConsumable {
    private int damageReductionAmount;

    public Shield(string name, string description, int value, int damageReductionAmount)
        : base(name, description, value) {
        this.damageReductionAmount = damageReductionAmount;
    }

    public override void Use() {
        // Apply the damage reduction effect description
        Console.WriteLine($"Used {Name}. Decreases damage taken by {damageReductionAmount}.");
    }
}
