using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Dtos.WeatherDtos
{
    public class WeatherResultDto
    {
        public string EffectiveDate { get; set; }
        public Int64 EffectiveEpochDate { get; set; }
        public Int32 Severity { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public string EndDate { get; set; }
        public Int64 EndEpochDate { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
        public string DailyForecastsDate { get; set; }
        public Int64 DailyForecastsEpochDate { get; set; }
        public double TempMinValue { get; set; }
        public string TempMinUnit { get; set; }
        public Int32 TempMinUnitType { get; set; }


    }
}
