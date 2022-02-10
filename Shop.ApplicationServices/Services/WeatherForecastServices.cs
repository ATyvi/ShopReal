using Nancy.Json;
using Shop.Core.Dto.Weather;
using Shop.Core.Dtos.WeatherDtos;
using Shop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Shop.ApplicationServices.Services
{
    public class WeatherForecastServices : IWeatherForecastServices
    {
        public string WeatherDetail(string city)
        {
            string apikey = "OTSjbiu1hw8SiIdTp1ekUCx2lvkSio9R";
            var url = $"http://www.accuweather.com/en/ee/tallinn/127964/daily-weather-forecast/127964?unit=c&lang=en-us";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                DailyForecastsDto weatherInfo = (new JavaScriptSerializer()).Deserialize<DailyForecastsDto>(json);
                HeadlineDto headlineInfo = (new JavaScriptSerializer()).Deserialize<HeadlineDto>(json);

                WeatherResultDto result = new WeatherResultDto();

                result.EffectiveDate = headlineInfo.EffectiveDate;
                result.EffectiveEpochDate = headlineInfo.EffectiveEpochDate;
                result.Severity = headlineInfo.Severity;
                result.Text = headlineInfo.Text;
                result.Category = headlineInfo.Category;
                result.EndDate = headlineInfo.EndDate;
                result.EndEpochDate = headlineInfo.EndEpochDate;
                result.MobileLink = headlineInfo.MobileLink;
                result.Link = headlineInfo.Link;
                result.DailyForecastsDate = headlineInfo.Date;
                result.DailyForecastsEpochDate = headlineInfo.EpochDate;
                result.TempMinValue = headlineInfo.Temperature.Minimum.Value;
                result.TempMinUnit = headlineInfo.Temperature.Minimum.Unit;
                result.TempMinUnitType = headlineInfo.Temperature.Mininum.UnitType;

                var jsonString = new JavaScriptSerializer().Serialize(result);

                return jsonString;
            }
        }
    }
}
