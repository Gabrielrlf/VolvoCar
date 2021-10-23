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
    public class Truck : BaseEntity
    {
        [Required, MaxLength(2), DisplayName("Modelo")]
        public string ModelName { get; set; }

        [Required, DisplayName("Ano modelo")]
        public int YearModel { get; set; }

        [Required, DisplayName("Ano fab")]
        public int YearFabrication { get; set; } = DateTime.Now.Year; 
    }
}
