namespace BlazorApp22.Classes
{
    public enum Categories
    {
        Electronics,
        Books,
        Food
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Categories Category { get; set; }
        public int Count { get; set; }
        public double Total { get; set; }
    }
}
