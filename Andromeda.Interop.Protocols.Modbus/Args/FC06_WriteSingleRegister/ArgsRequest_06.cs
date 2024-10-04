using Andromeda.Interop.Protocols.Modbus.Abstractions.Enums;
using Andromeda.Numerics;
using System.Collections.Generic;

namespace Andromeda.Interop.Protocols.Modbus.Args.FC06_WriteSingleRegister
{
    public class ArgsRequest_06 :
        ModbusArgsRequestWriteBase,
        IArgsRequest_06
    {
        public ArgsRequest_06(
            ushort regAddr,
            ushort value
        ) : this(
            IArgsRequest_06.StandardCode,
            regAddr,
            value
        )
        {
        }

        public ArgsRequest_06(
            byte rawCode,
            ushort regAddr,
            ushort value
        ) : base(
            rawCode,
            regAddr
        ) => InitRegisterValue(
            value,
            out _registerValue
        );

        public ArgsRequest_06(
            ModbusFunctionCodes enumCode,
            ushort regAddr,
            ushort value
        ) : base(
            enumCode,
            regAddr
        ) => InitRegisterValue(
            value,
            out _registerValue
        );

        public override IReadOnlyList<byte> RawData
            => [
                RegisterAddress.Byte1(),
                RegisterAddress.Byte2(),
                RegisterValue.Byte1(),
                RegisterValue.Byte2(),
            ];

        public ushort RegisterAddress => RegAddress;

        private readonly ushort _registerValue;
        public ushort RegisterValue => _registerValue;

        protected virtual void InitRegisterValue(
            ushort value,
            out ushort registerValue
        ) => registerValue = value;
    }
}
