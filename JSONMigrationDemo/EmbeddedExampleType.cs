namespace Repository.Models
{
    public class EmbeddedExampleType
    {
        public int Id { get; set; }

        public string NameRenamed { get; set; } = null!;

        public double NewProperty { get; set; }
    }
}
