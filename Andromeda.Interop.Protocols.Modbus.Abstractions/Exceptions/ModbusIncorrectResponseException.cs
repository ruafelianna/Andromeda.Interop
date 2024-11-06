using Andromeda.Interop.Protocols.Modbus.Abstractions.Assets.Translations;

namespace Andromeda.Interop.Protocols.Modbus.Abstractions.Exceptions
{
    public class ModbusIncorrectResponseException : ModbusException
    {
        public ModbusIncorrectResponseException(string param)
            : base(string.Format(
                ModbusExceptionsStrings
                    .ModbusIncorrectResponseException
                    .Value!,
                param
            ))
        {
            IncorrectParam = param;
        }

        public string IncorrectParam { get; }
    }
}
