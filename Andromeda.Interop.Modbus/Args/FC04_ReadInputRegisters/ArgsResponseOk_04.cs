using Andromeda.Interop.Modbus.Abstractions.Args.FC04_ReadInputRegisters;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Andromeda.Interop.Modbus.Args.FC04_ReadInputRegisters
{
    public class ArgsResponseOk_04 :
        ModbusArgsResponseOkReadBase<IArgsRequest_04, ArgsResponseOk_04>,
        IArgsResponseOk_04
    {
        protected ArgsResponseOk_04(
            IArgsRequest_04 request,
            IReadOnlyList<byte> data
        ) : base(request, data)
            => Init(
                request,
                data,
                out _startingAddress,
                out _quantityOfInputRegisters
            );

        public static Task<ArgsResponseOk_04> Create(
            IArgsRequest_04 request,
            Func<int, CancellationToken, Task<IReadOnlyList<byte>>> getBytes,
            CancellationToken token = default
        ) => Create(
            (request, bytes) => new ArgsResponseOk_04(request, bytes),
            request,
            getBytes,
            token
        );

        public IReadOnlyList<byte> InputRegisters => Bytes;

        private readonly ushort _startingAddress;
        public ushort StartingAddress => _startingAddress;

        private readonly ushort _quantityOfInputRegisters;
        public ushort QuantityOfInputRegisters => _quantityOfInputRegisters;

        public IReadOnlyList<ushort> RegistersDirect
            => Helpers.AsUShorts(InputRegisters, true);

        public IReadOnlyList<ushort> RegistersReverse
            => Helpers.AsUShorts(InputRegisters, false);

        protected override void InitByteCount(
            IArgsRequest_04 request,
            IReadOnlyList<byte> data,
            out byte byteCount
        )
        {
            base.InitByteCount(request, data, out byteCount);

            ArgumentOutOfRangeException.ThrowIfNotEqual(
                request.QuantityOfInputRegisters << 1,
                byteCount
            );
        }

        protected virtual void InitStartingAddress(
            IArgsRequest_04 request,
            IReadOnlyList<byte> data,
            out ushort startingAddress
        ) => startingAddress = request.StartingAddress;

        protected virtual void InitQuantityOfInputRegisters(
            IArgsRequest_04 request,
            IReadOnlyList<byte> data,
            out ushort quantityOfRegisters
        ) => quantityOfRegisters = request.QuantityOfInputRegisters;

        private void Init(
            IArgsRequest_04 request,
            IReadOnlyList<byte> data,
            out ushort startingAddress,
            out ushort quantityOfInputRegisters
        )
        {
            InitStartingAddress(request, data, out startingAddress);
            InitQuantityOfInputRegisters(request, data, out quantityOfInputRegisters);
        }
    }
}
