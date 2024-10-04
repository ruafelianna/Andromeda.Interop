namespace Andromeda.Interop.Protocols.Modbus.Abstractions.Exceptions
{
    public class ModbusIncorrectResponseException : ModbusException
    {
        public ModbusIncorrectResponseException(string param)
        {
            IncorrectParam = param;
        }

        public string IncorrectParam { get; }
    }
}
