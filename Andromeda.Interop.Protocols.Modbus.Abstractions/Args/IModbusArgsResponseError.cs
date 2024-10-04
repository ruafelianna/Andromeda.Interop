using Andromeda.Interop.Protocols.Modbus.Abstractions.Enums;

namespace Andromeda.Interop.Protocols.Modbus.Abstractions.Args
{
    public interface IModbusArgsResponseError : IModbusArgsResponse
    {
        ModbusExceptionCodes ExceptionCode { get; }

        string Reason => ExceptionCode.AsString();
    }
}
