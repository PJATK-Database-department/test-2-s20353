using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_2.Models
{
    [Table("Firefighter_Action", Schema = "Test_2")]
    public class Flight_Passenger
    {
        [Required]
        public int IdFlight { get; set; }
        [Required]
        public int IdPassenger { get; set; }


        [ForeignKey("IdFlight")]
        public virtual Flight Flight { get; set; }

        [ForeignKey("IdPassenger")]
        public virtual Passenger Passenger { get; set; }
    }
}
