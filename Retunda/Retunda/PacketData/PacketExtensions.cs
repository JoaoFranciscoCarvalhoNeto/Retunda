namespace Retunda.PacketData;

public static class PacketExtensions
{
    public static bool IsEqualExceptHeader<T>(this T packet, T other) where T : BasePacket
    {
        return other is { } otherPacket && typeof(T).GetFields().Where(f => f.Name != "Header").All(field => field.GetValue(otherPacket)!.Equals(field.GetValue(packet)));
    }
}