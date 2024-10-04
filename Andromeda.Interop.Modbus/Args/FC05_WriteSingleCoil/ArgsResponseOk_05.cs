using Andromeda.Interop.Modbus.Abstractions.Args.FC05_WriteSingleCoil;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Andromeda.Interop.Modbus.Args.FC05_WriteSingleCoil
{
    public class ArgsResponseOk_05 :
        ModbusArgsResponseOkWriteBase<IArgsRequest_05, ArgsResponseOk_05>,
        IArgsResponseOk_05
    {
        protected ArgsResponseOk_05(
            IArgsRequest_05 request,
            IReadOnlyList<byte> data
        ) : base(request, data)
        {
        }

        public static Task<ArgsResponseOk_05> Create(
            IArgsRequest_05 request,
            Func<int, CancellationToken, Task<IReadOnlyList<byte>>> getBytes,
            CancellationToken token = default
        ) => Create(
            (request, bytes) => new ArgsResponseOk_05(request, bytes),
            request,
            getBytes,
            token
        );

        public ushort OutputAddress => RegAddress;

        public ushort OutputValue => DataValue;

        protected override void InitRegAddress(
            IArgsRequest_05 request,
            IReadOnlyList<byte> data,
            out ushort regAddress
        )
        {
            base.InitRegAddress(request, data, out regAddress);

            ArgumentOutOfRangeException.ThrowIfNotEqual(
                regAddress,
                request.OutputAddress
            );
        }

        protected override void InitDataValue(
            IArgsRequest_05 request,
            IReadOnlyList<byte> data,
            out ushort dataValue
        )
        {
            base.InitDataValue(request, data, out dataValue);

            ArgumentOutOfRangeException.ThrowIfNotEqual(
                dataValue,
                request.OutputValue
            );
        }
    }
}