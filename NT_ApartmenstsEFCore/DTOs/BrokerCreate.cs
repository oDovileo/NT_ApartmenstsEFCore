using NT_ApartmenstsEFCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NT_ApartmenstsEFCore.DTOs
{
    public class BrokerCreate
    {
        public string Name { get; set; }

        public List<CompanyModel> Companies { get; set; }

        [DisplayName("Company")]
        public int CompanyId { get; set; }
    }
}
