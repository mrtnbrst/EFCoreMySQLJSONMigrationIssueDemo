using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class RegularTableClass
    {
        public int Id { get; set; }

        public double TestColumn { get; set; }

        [Column(TypeName = "json")]
        public ICollection<EmbeddedExampleType> ExampleTypeCollection { get; set; } = null!;
    }
}
