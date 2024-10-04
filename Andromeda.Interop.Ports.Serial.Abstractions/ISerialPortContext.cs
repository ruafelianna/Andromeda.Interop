using Andromeda.Interop.Ports.Serial.Abstractions.Enums;
using System.Collections.Generic;

namespace Andromeda.Interop.Ports.Serial.Abstractions
{
    public interface ISerialPortContext
    {
        public const string WindownCOMPortPattern
            = @"^COM([1-9]\d?|1\d{2}|2[0-4]\d|25[0-6])$";

        string PortName { get; set; }

        BaudRate BaudRate { get; set; }

        DataBits DataBits { get; set; }

        Parity Parity { get; set; }

        StopBits StopBits { get; set; }

        Handshake Handshake { get; set; }

        static abstract IEnumerable<string> AvailablePorts { get; }
    }
}
