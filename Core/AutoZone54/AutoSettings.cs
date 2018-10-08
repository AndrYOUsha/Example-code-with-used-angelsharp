using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserAutoZone54.Core.Interfaces;

namespace ParserAutoZone54.Core.AutoZone54
{
    class AutoSettings : IParserSettings
    {
        public string BaseUrl { get; set; } = "https://autozona54.ru";
        public string Prefix { get; set; } = "samodelkino";
    }
}
