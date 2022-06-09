using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_2.Models
{
    [Table("CityDict", Schema = "Test_2")]
    public class CityDict
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCityDict { get; set; }

        [Required]
        [MaxLength(30)]
        public string City { get; set; }


        public ICollection<Flight> Flights { get; set; }
    }
}
