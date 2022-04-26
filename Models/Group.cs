using System.ComponentModel.DataAnnotations;

namespace dotNetDependencyInjection.Models
{
    public class Group
    {
        public ICollection<PersonGroup>? PersonGroups { get; set; } //kolekcja pośrednicząca

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
