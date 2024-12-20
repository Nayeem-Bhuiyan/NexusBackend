using NBSoft.Application.Common.Mappings;
using NBSoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Application.Features.CountryInfo.Queries.GetAllCountries
{
    public class GetAllCountryDto: IMapFrom<Country>
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string code { get; set; }
        public string mobileDialingCode { get; set; }
        public string flagUrl { get; set; }
    }
}
