using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC01_ReadCoils;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC02_ReadDiscreteInputs;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC03_ReadHoldingRegisters;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC04_ReadInputRegisters;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC05_WriteSingleCoil;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC06_WriteSingleRegister;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC0F_WriteMultipleCoils;
using Andromeda.Interop.Protocols.Modbus.Abstractions.Args.FC10_WriteMultipleRegisters;
using System.Threading.Tasks;
using System.Threading;
using Andromeda.Interop.Ports.Serial.Abstractions;

namespace Andromeda.Interop.Protocols.Modbus.Abstractions
{
    public interface IModbusRTUClient : IModbusClient
    {
        Task<IArgsResponseOk_01> ReadCoils(
            ISerialPort port,
            byte address,
            IArgsRequest_01 request,
            CancellationToken token = default
        );

        Task<IArgsResponseOk_02> ReadDiscreteInputs(
            ISerialPort port,
            byte address,
            IArgsRequest_02 request,
            CancellationToken token = default
        );

        Task<IArgsResponseOk_03> ReadHoldingRegisters(
            ISerialPort port,
            byte address,
            IArgsRequest_03 request,
            CancellationToken token = default
        );

        Task<IArgsResponseOk_04> ReadInputRegisters(
            ISerialPort port,
            byte address,
            IArgsRequest_04 request,
            CancellationToken token = default
        );

        Task<IArgsResponseOk_05> WriteSingleCoil(
            ISerialPort port,
            byte address,
            IArgsRequest_05 request,
            CancellationToken token = default
        );

        Task<IArgsResponseOk_06> WriteSingleRegister(
            ISerialPort port,
            byte address,
            IArgsRequest_06 request,
            CancellationToken token = default
        );

        Task<IArgsResponseOk_0F> WriteMultipleCoils(
            ISerialPort port,
            byte address,
            IArgsRequest_0F request,
            CancellationToken token = default
        );

        Task<IArgsResponseOk_10> WriteMultipleRegisters(
            ISerialPort port,
            byte address,
            IArgsRequest_10 request,
            CancellationToken token = default
        );
    }
}
