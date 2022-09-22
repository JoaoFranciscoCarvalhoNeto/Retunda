using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class ParticipantDataPacket : BasePacket
{
    public byte NumActiveCars;

    [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 22)]
    public ParticipantData[] ParticipantData = null!;
}