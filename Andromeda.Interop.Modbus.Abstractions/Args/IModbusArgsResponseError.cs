using Andromeda.Interop.Modbus.Abstractions.Enums;

namespace Andromeda.Interop.Modbus.Abstractions.Args
{
    public interface IModbusArgsResponseError : IModbusArgsResponse
    {
        ModbusExceptionCodes ExceptionCode { get; }

        string Reason => ExceptionCode.AsString();
    }
}
