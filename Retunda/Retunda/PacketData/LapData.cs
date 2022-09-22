using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class LapData
{
    public uint LastLapTime;
    public uint CurrentLapTime;
    public ushort Sector1Time;
    public ushort Sector2Time;
    public float LapDistance;
    public float TotalDistance;
    public float SafetyCarDelta;
    public byte CarPosition;
    public byte CurrentLapNumber;
    public PitStatus PitStatus;
    public byte NumPitStops;
    public byte Sector;
    public byte CurrentLapInvalid;
    public byte Penalties;
    public byte NumUnservedDriveThroughPenalties;
    public byte NumUnservedStopGoPenalties;
    public byte GridPosition;
    public DriverStatus DriverStatus;
    public ResultStatus ResultStatus;
    public byte PitLaneTimerActive;
    public ushort PitLaneTimeInLane;
    public ushort PitLaneTime;
    public byte PitStopShouldServePenalty;
}