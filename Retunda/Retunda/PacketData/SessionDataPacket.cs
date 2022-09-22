using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class SessionDataPacket : BasePacket
{
    public Weather Weather;
    public sbyte TrackTemperature;
    public sbyte AirTemperature;
    public byte TotalLaps;
    public ushort TrackLength;
    public SessionType SessionType;
    public sbyte TrackId;
    public byte Formula;
    public ushort SessionTimeLeft;
    public ushort SessionDuration;
    public byte PitSpeedLimit;
    public byte GamePaused;
    public byte Spectating;
    public byte SpectatorCarIndex;
    public byte SliProNativeSupport;
    public byte NumMarshalZones;
    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 21)]
    public MarshalZone[] MarshalZones = null!;
    public SafetyCarStatus SafetyCarStatus;
    public byte NetworkGame;
    public byte NumWeatherForecastSamples;
    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 56)]
    public WeatherForecastSample[] WeatherForecasts = null!;
    public WeatherForecastAccuracy WeatherForecastAccuracy;
    public byte AiDifficulty;
    public uint SeasonLinkId;
    public uint WeekendLinkId;
    public uint SessionLinkId;
    public byte PitStopWindowIdealLap;
    public byte PitStopWindowLatestLap;
    public byte PitStopRejoinPosition;
    public byte SteeringAssist;
    public byte BreakingAssist;
    public byte GearboxAssist;
    public byte PitAssist;
    public byte PitReleaseAssist;
    public byte ERSAssist;
    public byte DRSAssist;
    public byte DynamicRacingLine;
    public byte DynamicRacingLineType;
    public GameMode GameMode;
    public Ruleset Ruleset;
    public uint TimeOfDay;
    public SessionLength SessionLength;
}