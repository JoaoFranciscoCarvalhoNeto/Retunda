using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class PacketSessionHistoryData : BasePacket
{
    public byte CarIndex;
    public byte NLaps;
    public byte NTyreStints;

    public byte BestLapTimeLapNum;
    public byte BestSector1LapNum;
    public byte BestSector2LapNum;
    public byte BestSector3LapNum;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 100)]
    public LapHistoryData[] LapHistoryData = null!;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 100)]
    public TyreStintHistoryData[] TyreStintHistoryData = null!;
}