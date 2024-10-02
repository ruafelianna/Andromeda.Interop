using Andromeda.Interop.Modbus.Abstractions.Enums;

namespace Andromeda.Interop.Modbus.Abstractions.Args.FC06_WriteSingleRegister
{
    public interface IArgsRequest_06 : IModbusArgsRequest
    {
        ushort RegisterAddress { get; }

        ushort RegisterValue { get; }

        const ushort MinValue = 0x0000;

        const ushort MaxValue = 0xFFFF;

        const ModbusDataTypes DataType
            = ModbusDataTypes.HoldingRegister;

        const ModbusFunctionCodes StandardCode
            = ModbusFunctionCodes.WriteSingleRegister;
    }
}
