using System;

namespace Shop.Core.Dto.Weather
{
    public class RainDto
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public Int32 UnitType { get; set; }
    }
}