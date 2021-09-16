using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT_ApartmenstsEFCore.Models
{
    public class ApartmentModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
