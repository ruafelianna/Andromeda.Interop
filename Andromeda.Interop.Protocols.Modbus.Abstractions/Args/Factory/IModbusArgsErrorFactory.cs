namespace Andromeda.Interop.Protocols.Modbus.Abstractions.Args.Factory
{
    public interface IModbusArgsErrorFactory
    {
        DCreateError<IModbusArgsResponseError> Create { get; }
    }
}
