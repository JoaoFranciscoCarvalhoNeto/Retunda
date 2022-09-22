using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class PacketLapData : BasePacket
{
    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 22)]
    public LapData[] LapData = null!;

    public byte TimeTrialPersonalBestCarId;
    public byte TimeTrialRivalCarId;
}