using System;
public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address)
        : base(title, description, date, time, address)
    {
    }

    public string WeatherForecast
    {
        get { return weatherForecast; }
        set { weatherForecast = value; }
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}

