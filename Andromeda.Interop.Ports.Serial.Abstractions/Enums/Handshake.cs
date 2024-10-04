namespace Andromeda.Interop.Ports.Serial.Abstractions.Enums
{
    public enum Handshake : byte
    {
        None = 0,

        XOnXOff = 1,

        RequestToSend = 2,

        Both = 3,
    }
}
