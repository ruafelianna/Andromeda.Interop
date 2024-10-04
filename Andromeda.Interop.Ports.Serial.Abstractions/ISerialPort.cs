using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Andromeda.Interop.Ports.Serial.Abstractions
{
    public interface ISerialPort : IDisposable
    {
        Task<IReadOnlyList<byte>> ReadAsync(
            int count,
            CancellationToken token = default
        );

        Task WriteAsync(
            IReadOnlyList<byte> buffer,
            CancellationToken token = default
        );
    }
}
