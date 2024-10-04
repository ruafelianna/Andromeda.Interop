using Andromeda.Numerics;

namespace Andromeda.Interop.Protocols.Modbus.Abstractions.Args.Extensions
{
    public static class ModbusTCPIPExtensions
    {
        public static byte[] TCPIP_Cmd(
            this IModbusArgs args,
            ushort id,
            byte address,
            ushort protocol = 0
        )
        {
            var main = args.RTU_Main(address);
            var length = unchecked((ushort)main.Length);

            return [
                id.Byte1(),
                id.Byte2(),
                protocol.Byte1(),
                protocol.Byte2(),
                length.Byte1(),
                length.Byte2(),
                .. main
            ];
        }
    }
}
