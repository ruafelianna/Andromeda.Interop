using Andromeda.Interop.Modbus.Abstractions.Enums;
using System.Collections.Generic;

namespace Andromeda.Interop.Modbus.Abstractions.Args
{
    public interface IModbusArgs
    {
        byte RawFunctionCode { get; }

        ModbusFunctionCodes FunctionCode { get; }

        IReadOnlyList<byte> RawData { get; }
    }
}
