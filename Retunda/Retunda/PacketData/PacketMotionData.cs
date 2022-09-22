using System.Runtime.InteropServices;

namespace Retunda.PacketData;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public class PacketMotionData : BasePacket
{
    public CarMotionData[] CarMotionData = null!;

    public float[] SuspensionPosition = null!;
    public float[] SuspensionVelocity = null!;
    public float[] SuspensionAcceleration = null!;
    public float[] WheelSpeed = null!;
    public float[] WheelSlip = null!;
    public float LocalVelocityX;
    public float LocalVelocityY;
    public float LocalVelocityZ;
    public float AngularVelocityX;
    public float AngularVelocityY;
    public float AngularVelocityZ;
    public float AngularAccelerationX;
    public float AngularAccelerationY;
    public float AngularAccelerationZ;
    public float FrontWheelsAngle;
}