namespace Andromeda.Interop.Modbus.Abstractions.Args.FC06_WriteSingleRegister
{
    public interface IArgsResponseOk_06 : IModbusArgsResponseOk
    {
        ushort RegisterAddress { get; }

        ushort RegisterValue { get; }
    }
}
