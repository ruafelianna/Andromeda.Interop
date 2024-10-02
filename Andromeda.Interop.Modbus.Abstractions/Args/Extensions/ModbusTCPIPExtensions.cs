namespace Andromeda.Interop.Modbus.Abstractions.Args.Extensions
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
                unchecked((byte)(id >> 8)),
                unchecked((byte)(id & 0xFF)),
                unchecked((byte)(protocol >> 8)),
                unchecked((byte)(protocol & 0xFF)),
                unchecked((byte)(length >> 8)),
                unchecked((byte)(length & 0xFF)),
                .. main
            ];
        }
    }
}
