using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VolvoCar.Domain.Model
{
    public class Truck : BaseEntity
    {
        [Required(ErrorMessage = "Escolha entre FH ou FM"), MaxLength(2), DisplayName("Modelo")]
        public string ModelName { get; set; }

        [Required(ErrorMessage = "O ano do modelo só pode ser o atual ou subsequente!"), DisplayName("Ano modelo")]
        public int YearModel { get; set; }

        [Required, DisplayName("Ano fab")]
        public int YearFabrication { get; set; } = DateTime.Now.Year; 
    }
}
