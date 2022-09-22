using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class WeatherForecastSample
{
    public SessionType SessionType;
    public byte TimeOffset;
    public Weather Weather;
    public sbyte TrackTemperature;
    public sbyte TrackTemperatureChange;
    public sbyte AirTemperature;
    public sbyte AirTemperatureChange;
    public byte RainPercentage;
}