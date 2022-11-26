using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GraphQLAPI.Models
{
    public class UpdateSuperPower
    {
        [Key]

        public Guid Id { get; set; }

        public string SuperPower { get; set; }
        public string? Description { get; set; }

        [ForeignKey("SuperHeroId")]

        public Guid? SuperHeroId { get; set; }

        public Superhero SuperHero { get; set; }
    }
}
