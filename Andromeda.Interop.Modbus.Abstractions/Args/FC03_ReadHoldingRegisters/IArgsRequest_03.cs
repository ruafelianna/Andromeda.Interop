using Andromeda.Interop.Modbus.Abstractions.Enums;

namespace Andromeda.Interop.Modbus.Abstractions.Args.FC03_ReadHoldingRegisters
{
    public interface IArgsRequest_03 : IModbusArgsRequest
    {
        ushort StartingAddress { get; }

        ushort QuantityOfRegisters { get; }

        const ushort MinQuantity = 0x0001;

        const ushort MaxQuantity = 0x007D; // 125

        const ModbusDataTypes DataType
            = ModbusDataTypes.HoldingRegister;

        const ModbusFunctionCodes StandardCode
            = ModbusFunctionCodes.ReadHoldingRegisters;
    }
}
