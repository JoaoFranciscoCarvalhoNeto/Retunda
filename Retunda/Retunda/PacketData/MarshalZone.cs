using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class MarshalZone
{
    public float ZoneStart;
    public Flag ZoneFlag;
}