using System.Runtime.InteropServices;

namespace Retunda.PacketData
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class PacketHeader
    {
        public ushort PacketFormat;
        public byte GameMajorVersion;
        public byte GameMinorVersion;
        public byte PacketVersion;
        public byte PacketId;
        public ulong SessionUid;
        public float SessionTime;
        public uint FrameIdentifier;
        public byte PlayerCarIndex;
        public byte SecondaryPlayerCarIndex;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public abstract class BasePacket
    {
        public PacketHeader Header = null!;
    }
}