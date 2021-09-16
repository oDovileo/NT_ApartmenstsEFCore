using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT_ApartmenstsEFCore.Models
{
    public class CompanyBroker
    {
        public int BrokerId { get; set; }

        public BrokerModel Broker { get; set; }

        public CompanyModel Company { get; set; }

        public int CompanyId { get; set; }
    }
}
