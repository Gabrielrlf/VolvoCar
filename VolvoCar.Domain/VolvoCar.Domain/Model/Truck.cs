using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoCar.Domain.Model
{
    public class Truck
    {
        [Key]
        [DisplayName("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Modelo")]
        [MaxLength(2)]
        public string ModelName { get; set; }

        [DisplayName("Ano modelo")]
        public int YearModel { get; set; }

        [DisplayName("Ano fab")]
        public int YearFabrication { get; set; } 
    }
}
