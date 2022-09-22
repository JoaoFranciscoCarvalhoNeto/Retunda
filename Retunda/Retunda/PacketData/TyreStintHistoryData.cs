using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class TyreStintHistoryData
{
    public byte EndLap;
    public byte TyreActualCompound;
    public byte TyreVisualCompound;
}