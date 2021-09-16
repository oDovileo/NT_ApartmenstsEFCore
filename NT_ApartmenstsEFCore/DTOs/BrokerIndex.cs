using NT_ApartmenstsEFCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NT_ApartmenstsEFCore.DTOs
{
    public class BrokerIndex
    {
        [DisplayName("Broker")]
        public int CompanyId { get; set; }

        public List<BrokerModel> Brokers { get; set; }

        public List<CompanyModel> Companies { get; set; }
    }
}
