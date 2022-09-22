using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class ParticipantData
{
    public byte AIControlled;
    public byte DriverId;
    public byte NetworkId;
    public byte TeamID;
    public byte MyTeam;
    public byte RaceNumber;

    public byte Nationality;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public char[] Name = null!;

    public byte YourTelemetry;
}