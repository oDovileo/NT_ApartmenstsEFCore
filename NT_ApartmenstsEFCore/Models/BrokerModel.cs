using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NT_ApartmenstsEFCore.Models
{
    public class BrokerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        [NotMapped]
        public string FullName { get; set; }



        public bool Deleted { get; set; } = false;

        public CompanyModel Company { get; set; }

        public int? CompanyId { get; set; }

        public List<CompanyBroker> CompanyBrokers { get; set; }
    }
}
