using Andromeda.Interop.Modbus.Abstractions.Args.FC0F_WriteMultipleCoils;
using Andromeda.Interop.Modbus.Abstractions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Andromeda.Interop.Modbus.Args.FC0F_WriteMultipleCoils
{
    public class ArgsRequest_0F :
        ModbusArgsRequestWriteBase,
        IArgsRequest_0F
    {
        public ArgsRequest_0F(
            ushort startAddress,
            IEnumerable<bool> outsVal
        ) : this(
            IArgsRequest_0F.StandardCode,
            startAddress,
            outsVal
        )
        {
        }

        public ArgsRequest_0F(
            byte rawCode,
            ushort startAddress,
            IEnumerable<bool> outsVal
        ) : base(
            rawCode,
            startAddress
        ) => Init(
            outsVal,
            out _quantityOfOutputs,
            out _byteCount,
            out _outputsValue
        );

        public ArgsRequest_0F(
            ModbusFunctionCodes enumCode,
            ushort startAddress,
            IEnumerable<bool> outsVal
        ) : base(
            enumCode,
            startAddress
        ) => Init(
            outsVal,
            out _quantityOfOutputs,
            out _byteCount,
            out _outputsValue
        );

        public override IReadOnlyList<byte> RawData
            => [
                unchecked((byte)(StartingAddress >> 8)),
                unchecked((byte)(StartingAddress & 0xFF)),
                unchecked((byte)(QuantityOfOutputs >> 8)),
                unchecked((byte)(QuantityOfOutputs & 0xFF)),
                ByteCount,
                .. OutputsValue,
            ];

        public ushort StartingAddress => RegAddress;

        private readonly ushort _quantityOfOutputs;
        public ushort QuantityOfOutputs => _quantityOfOutputs;

        private readonly byte _byteCount;
        public byte ByteCount => _byteCount;

        private readonly IReadOnlyList<byte> _outputsValue;
        public IReadOnlyList<byte> OutputsValue => _outputsValue;

        protected virtual void InitQuantityOfOutputs(
            IEnumerable<bool> outsVal,
            out ushort quantityOfOutputs
        )
        {
            var quantity = outsVal.Count();

            ArgumentOutOfRangeException.ThrowIfLessThan(
                quantity, IArgsRequest_0F.MinQuantity);

            ArgumentOutOfRangeException.ThrowIfGreaterThan(
                quantity, IArgsRequest_0F.MaxQuantity);

            ArgumentOutOfRangeException.ThrowIfGreaterThan(
                StartingAddress + quantity - 1, ushort.MaxValue);

            quantityOfOutputs = unchecked((ushort)quantity);
        }

        protected virtual void InitByteCount(
            out byte byteCount
        ) => byteCount = unchecked((byte)((QuantityOfOutputs + 7) >> 3));

        protected virtual void InitOutputsValue(
            IEnumerable<bool> outsVal,
            out IReadOnlyList<byte> outputsValue
        )
        {
            var result = new byte[ByteCount];
            var count = 0;
            foreach (var item in outsVal)
            {
                result[count >> 3] |= unchecked(
                    (byte)((item ? 1 : 0) << (count & 8))
                );
                count++;
            }
            outputsValue = result;
        }

        private void Init(
            IEnumerable<bool> outsVal,
            out ushort quantityOfOutputs,
            out byte byteCount,
            out IReadOnlyList<byte> outputsValue
        )
        {
            InitQuantityOfOutputs(outsVal, out quantityOfOutputs);
            InitByteCount(out byteCount);
            InitOutputsValue(outsVal, out outputsValue);
        }
    }
}
