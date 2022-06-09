using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_2.Models
{
    [Table("Flight", Schema = "Test_2")]
    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFlight { get; set; }


        [Required]
        public int IdPlane { get; set; }

        [Required]
        public int IdCityDict { get; set; }



        [Required]
        public DateTime FlightDate { get; set; }

        [MaxLength(200)]
        public string Comments { get; set; }



        [ForeignKey("IdPlane")]
        public virtual Plane Plane { get; set; }

        [ForeignKey("IdCityDict")]
        public virtual CityDict CityDict { get; set; }




    }
}
