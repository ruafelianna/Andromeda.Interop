using System.Collections.Generic;

namespace Andromeda.Interop.Modbus.Abstractions.Args.FC01_ReadCoils
{
    public interface IArgsResponseOk_01 : IModbusArgsResponseOk
    {
        byte ByteCount { get; }

        IReadOnlyList<byte> CoilStatus { get; }

        IReadOnlyList<bool> Coils { get; }

        ushort QuantityOfCoils { get; }

        ushort StartingAddress { get; }
    }
}
