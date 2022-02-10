using System;

namespace Shop.Core.Dto.Weather
{
    public class AirAndPollenDto
    {
        public string Name { get; set; }
        public Int32 Value { get; set; }
        public string Category { get; set; }
        public Int32 CategoryValue { get; set; }
        public string Type { get; set; }
    }
}