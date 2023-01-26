using OnlineMuhasebeServer.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Domain.CompanyEntities
{
    public sealed class UniformChartOfAccount : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; } //ana grup,grup,muavin
        public string CompanyId { get; set; }

    }
}
