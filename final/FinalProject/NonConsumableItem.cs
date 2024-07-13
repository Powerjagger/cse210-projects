// NonConsumable.cs

using System;

public abstract class NonConsumable : Item {
    public NonConsumable(string name, string description, int value)
        : base(name, description, value) {
    }

    // Abstract method for using non-consumable items
    public abstract void Use();
}
