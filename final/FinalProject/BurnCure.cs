class BurnCure : Consumable {
    public BurnCure(string name, string description, int value, int quantity) 
        : base(name, description, value, quantity) {}

    protected override void ApplyEffect() {
        // Logic to remove burn status
        Console.WriteLine("Burn status removed.");
    }
}
