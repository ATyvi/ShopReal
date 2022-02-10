using System;

namespace Shop.Core.Dto.Weather
{
    public class DayDto
    {
        public Int32 Icon { get; set; }
        public string IconPhrase { get; set; }
        public LocalSourceDto LocalSource { get; set; }
        public Boolean HasPrecipitation { get; set; }
        public String PrecipitationType { get; set; }
        public String PrecipitationIntensity { get; set; }
        public string ShortPhrase { get; set; }
        public string LongPhrase { get; set; }
        public Int32 PrecipitationProbability { get; set; }
        public Int32 ThunderstormProbability { get; set; }
        public Int32 RainProbability { get; set; }
        public Int32 SnowProbability { get; set; }
        public Int32 IceProbability { get; set; }
        public WindDto Wind { get; set; }
        public WindGustDto WindGust { get; set; }
        public TotalLiquidDto TotalLiquid { get; set; }
        public RainDto Rain { get; set; }
        public SnowDto Snow { get; set; }
        public IceDto Ice { get; set; }
        public float HoursOfPrecipitation { get; set;}
        public float HoursOfRain { get; set; }
        public Int32 CloudCover { get; set; }
        public EvapotranspirationDto Evapotranspiration { get; set; }
        public SolarIrradianceDto SolarIrradiance { get; set; }


    }
    
}