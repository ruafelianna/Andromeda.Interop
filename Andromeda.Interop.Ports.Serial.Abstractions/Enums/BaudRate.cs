using Andromeda.Interop.Ports.Serial.Abstractions.Attributes;

namespace Andromeda.Interop.Ports.Serial.Abstractions.Enums
{
    public enum BaudRate : uint
    {
        [IsWindowsPredefined]
        b75 = 75,

        [IsWindowsPredefined]
        [UseCase("Bell 101 modem")]
        b110 = 110,

        [IsWindowsPredefined]
        b134_5 = 134,

        [IsWindowsPredefined]
        b150 = 150,

        [IsWindowsPredefined]
        [UseCase("Bell 103 modem")]
        [UseCase("V.21 modem")]
        b300 = 300,

        [IsWindowsPredefined]
        b600 = 600,

        [IsWindowsPredefined]
        [UseCase("Bell 202 modem")]
        [UseCase("Bell 212A modem")]
        [UseCase("V.22 modem")]
        b1200 = 1200,

        [IsWindowsPredefined]
        b1800 = 1800,

        [UseCase("V.22bis modem")]
        [IsWindowsPredefined]
        b2400 = 2400,

        [IsWindowsPredefined]
        [UseCase("V.27ter modem")]
        b4800 = 4800,

        [IsWindowsPredefined]
        b7200 = 7200,

        [IsWindowsPredefined]
        [UseCase("V.32 modem")]
        b9600 = 9600,

        [IsWindowsPredefined]
        [UseCase("V.32bis modem")]
        b14400 = 14400,

        [IsWindowsPredefined]
        b19200 = 19200,

        b28800 = 28800,

        [UseCase("MIDI port")]
        b31250 = 31250,

        [IsWindowsPredefined]
        b38400 = 38400,

        [IsWindowsPredefined]
        [UseCase("V.90 modem")]
        [UseCase("V.92 modem")]
        b56000 = 56000,

        [IsWindowsPredefined]
        [UseCase("V.32bis modem with V.42bis compression")]
        b57600 = 57600,

        [UseCase("BACnet MS/TP networks")]
        b76800 = 76800,

        [IsWindowsPredefined]
        [UseCase("V.34bis modem with V.42bis compression")]
        [UseCase("low cost serial V.90 modem with V.42bis compression")]
        [UseCase("low cost serial V.90 modem with V.44 compression")]
        [UseCase("low cost serial V.92 modem with V.42bis compression")]
        [UseCase("low cost serial V.92 modem with V.44 compression")]
        b115200 = 115200,

        [IsWindowsPredefined]
        [UseCase("Basic Rate Interface ISDN terminal adapter")]
        b128000 = 128000,

        [UseCase("LocalTalk")]
        [UseCase("high end serial V.90 modem with V.42bis compression")]
        [UseCase("high end serial V.90 modem with V.44 compression")]
        [UseCase("high end serial V.92 modem with V.42bis compression")]
        [UseCase("high end serial V.92 modem with V.44 compression")]
        b230400 = 230400,

        [UseCase("DMX512")]
        [UseCase("stage lighting and effects network")]
        b250000 = 250000,

        [IsWindowsPredefined]
        b256000 = 256000,
    }
}
