class FrostbiteCure : Consumable {
    public FrostbiteCure(string name, string description, int value, int quantity) 
        : base(name, description, value, quantity) {}

    protected override void ApplyEffect() {
        // Logic to remove frostbite status
        Console.WriteLine("Frostbite status removed.");
    }
}
