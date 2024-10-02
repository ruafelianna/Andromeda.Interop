using Andromeda.Interop.Modbus.Abstractions.Enums;

namespace Andromeda.Interop.Modbus.Abstractions.Args.FC02_ReadDiscreteInputs
{
    public interface IArgsRequest_02 : IModbusArgsRequest
    {
        ushort StartingAddress { get; }

        ushort QuantityOfInputs { get; }

        const ushort MinQuantity = 0x0001;

        const ushort MaxQuantity = 0x07D0; // 2000

        const ModbusDataTypes DataType
            = ModbusDataTypes.DiscreteInput;

        const ModbusFunctionCodes StandardCode
            = ModbusFunctionCodes.ReadDiscreteInputs;
    }
}
