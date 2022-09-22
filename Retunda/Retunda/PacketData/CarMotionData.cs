using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class CarMotionData
{
    public float WorldPositionX;
    public float WorldPositionY;
    public float WorldPositionZ;
    public float WorldVelocityX;
    public float WorldVelocityY;
    public float WorldVelocityZ;
    public short WorldForwardDirX;
    public short WorldForwardDirY;
    public short WorldForwardDirZ;
    public short WorldRightDirX;
    public short WorldRightDirY;
    public short WorldRightDirZ;
    public float GForceLateral;
    public float GForceLongitudinal;
    public float GForceVertical;
    public float Yaw;
    public float Pitch;
    public float Roll;
}