using Andromeda.Interop.Protocols.Modbus.Abstractions.Args;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC05_WriteSingleCoil;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Enums;
using Andromeda.Numerics;
using System.Collections.Generic;

namespace Andromeda.Interop.Protocols.Modbus.Args.FC05_WriteSingleCoil
{
    public class ArgsRequest_05 :
        ModbusArgsRequestWriteBase,
        IArgsRequest_05
    {
        public ArgsRequest_05(
            ushort regAddr,
            bool isOn
        ) : this(
            IArgsRequest_05.StandardCode,
            regAddr,
            isOn
        )
        {
        }

        public ArgsRequest_05(
            byte rawCode,
            ushort regAddr,
            bool isOn
        ) : base(
            rawCode,
            regAddr
        ) => InitOutputValue(
            isOn,
            out _outputValue
        );

        public ArgsRequest_05(
            ModbusFunctionCodes enumCode,
            ushort regAddr,
            bool isOn
        ) : base(
            enumCode,
            regAddr
        ) => InitOutputValue(
            isOn,
            out _outputValue
        );

        public override IReadOnlyList<byte> RawData
            => [
                OutputAddress.Byte1(),
                OutputAddress.Byte2(),
                OutputValue.Byte1(),
                OutputValue.Byte2(),
            ];

        public ushort OutputAddress => RegAddress;

        private readonly ushort _outputValue;
        public ushort OutputValue => _outputValue;

        protected virtual void InitOutputValue(
           bool isOn,
           out ushort outputValue
        ) => outputValue = isOn ? Consts.On : Consts.Off;
    }
}
