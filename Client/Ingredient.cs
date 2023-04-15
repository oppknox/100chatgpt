public class Ingredient
{
    public string? Name { get; set; }
    public double Amount { get; set; }
    public string? Unit { get; set; }

    public static readonly List<string> CommonUnits = new List<string>
    {
        "tsp", "tbsp", "fl oz", "cup", "pint", "quart", "gallon", "ml", "cl", "dl", "l", "mg", "g", "kg", "oz", "lb"
    };
}