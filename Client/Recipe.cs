public class Recipe
{
    public string? Title { get; set; }
    public string? Instructions { get; set; }
    public int Rating { get; set; }
    public int Servings { get; set; }
    public int PrepTime { get; set; }
    public int CookTime { get; set; }
    public string? Difficulty { get; set; }
    public string? Nutrition { get; set; }
    public string? Notes { get; set; }

    public int TotalTime => PrepTime + CookTime;

    public List<Ingredient> Ingredients { get; set; }

    public Recipe()
    {
        Ingredients = new List<Ingredient>();
    }
}