using Andromeda.Interop.Protocols.Modbus.Abstractions.Args;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.Factory;

namespace Andromeda.Interop.Protocols.Modbus.Args.Factory
{
    public class ModbusArgsErrorFactory : IModbusArgsErrorFactory
    {
        public DCreateError<IModbusArgsResponseError> Create
            => ModbusArgsResponseErrorBase.Create;
    }
}
