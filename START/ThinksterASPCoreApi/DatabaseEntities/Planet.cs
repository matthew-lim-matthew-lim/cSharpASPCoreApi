using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThinksterASPCoreApi.DatabaseEntities
{
    public class Planet
    {
        // Used by the entity framework to make sure that the id increments
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        // [Required] tag is for POST data validation, that the user gives valid data
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Mass { get; set; }
        public List<Moon> Moons { get; set; }
    }
}
