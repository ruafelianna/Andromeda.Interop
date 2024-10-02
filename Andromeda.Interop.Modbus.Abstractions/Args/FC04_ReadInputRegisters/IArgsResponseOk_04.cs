using System.Collections.Generic;

namespace Andromeda.Interop.Modbus.Abstractions.Args.FC04_ReadInputRegisters
{
    public interface IArgsResponseOk_04 : IModbusArgsResponseOk
    {
        byte ByteCount { get; }

        ushort StartingAddress { get; }

        ushort QuantityOfInputRegisters { get; }

        IReadOnlyList<byte> InputRegisters { get; }

        IReadOnlyList<ushort> RegistersDirect { get; }

        IReadOnlyList<ushort> RegistersReverse { get; }
    }
}
