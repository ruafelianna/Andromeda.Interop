namespace Andromeda.Interop.Modbus.Abstractions.Args.FC10_WriteMultipleRegisters
{
    public interface IArgsResponseOk_10 : IModbusArgsResponseOk
    {
        ushort StartingAddress { get; }

        ushort QuantityOfRegisters { get; }
    }
}
