using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NT_ApartmenstsEFCore.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }

        [DisplayName("Name of the comapny")]
        public string Name { get; set; }

        public List<CompanyBroker> CompanyBrokers { get; set; }

        public List<BrokerModel> Brokers { get; set; }
    }
}
