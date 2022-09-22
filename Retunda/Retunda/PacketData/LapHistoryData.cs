using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class LapHistoryData
{
    public uint LapTime;
    public ushort Sector1Time;
    public ushort Sector2Time;
    public ushort Sector3Time;
    public byte LapValidBitFlags;
}