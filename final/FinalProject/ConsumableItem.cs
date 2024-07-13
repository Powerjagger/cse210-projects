class Consumable : Item {
    public int Quantity { get; private set; }

    public Consumable(string name, string description, int value, int quantity) 
        : base(name, description, value) {
        Quantity = quantity;
    }

    public override void Use() {
        if (Quantity > 0) {
            Quantity--;
            Console.WriteLine($"{Name} used. {Quantity} remaining.");
            // Add logic to apply the consumable's effect
        } else {
            Console.WriteLine($"{Name} is out of stock.");
        }
    }

    public override string ToString() {
        return base.ToString() + $"\nQuantity: {Quantity}";
    }
}

