using Andromeda.Interop.Modbus.Abstractions.Enums;

namespace Andromeda.Interop.Modbus.Abstractions.Args.FC01_ReadCoils
{
    public interface IArgsRequest_01 : IModbusArgsRequest
    {
        ushort StartingAddress { get; }

        ushort QuantityOfCoils { get; }

        const ushort MinQuantity = 0x0001;

        const ushort MaxQuantity = 0x07D0; // 2000

        const ModbusDataTypes DataType
            = ModbusDataTypes.DiscreteOutput;

        const ModbusFunctionCodes StandardCode
            = ModbusFunctionCodes.ReadCoils;
    }
}
