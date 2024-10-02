using Andromeda.Interop.Modbus.Abstractions.Enums;
using System.Collections.Generic;

namespace Andromeda.Interop.Modbus.Abstractions.Args.FC10_WriteMultipleRegisters
{
    public interface IArgsRequest_10 : IModbusArgsRequest
    {
        ushort StartingAddress { get; }

        ushort QuantityOfRegisters { get; }

        byte ByteCount { get; }

        IReadOnlyList<byte> RegistersValue { get; }

        const ushort MinQuantity = 0x0001;

        const ushort MaxQuantity = 0x007B; // 123

        const ModbusDataTypes DataType
            = ModbusDataTypes.HoldingRegister;

        const ModbusFunctionCodes StandardCode
            = ModbusFunctionCodes.WriteMultipleRegisters;
    }
}
