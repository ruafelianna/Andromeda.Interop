using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC0F_WriteMultipleCoils;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Enums;
using Andromeda.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Andromeda.Interop.Protocols.Modbus.Args.FC0F_WriteMultipleCoils
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
                StartingAddress.Byte1(),
                StartingAddress.Byte2(),
                QuantityOfOutputs.Byte1(),
                QuantityOfOutputs.Byte2(),
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
        )
        {
            var count = QuantityOfOutputs.ContainingBytes();

            ArgumentOutOfRangeException.ThrowIfGreaterThan(count, byte.MaxValue);

            byteCount = unchecked((byte)count);
        }

        protected virtual void InitOutputsValue(
            IEnumerable<bool> outsVal,
            out IReadOnlyList<byte> outputsValue
        )
        {
            var result = new byte[ByteCount];
            var count = 0;
            foreach (var item in outsVal)
            {
                result[count.FullBytes()] |= unchecked(
                    (byte)((item ? 1 : 0) << count.Mod8())
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
