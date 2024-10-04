using Andromeda.Interop.Protocols.Modbus.Abstractions.Args;

namespace Andromeda.Interop.Protocols.Modbus.Abstractions.Exceptions
{
    public class ModbusProtocolException : ModbusException
    {
        public ModbusProtocolException(IModbusArgsResponseError args) :
            base(args.Reason)
        {
            ErrorArgs = args;
        }

        public IModbusArgsResponseError ErrorArgs { get; }
    }
}
