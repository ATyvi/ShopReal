using System;

namespace Shop.Core.Dto.Weather
{
    public class SunDto
    {
        public string Rise { get; set; }
        public Int64 EpochRise { get; set; }
        public string Set { get; set; }
        public Int64 EpochSet { get; set; }
    }
}