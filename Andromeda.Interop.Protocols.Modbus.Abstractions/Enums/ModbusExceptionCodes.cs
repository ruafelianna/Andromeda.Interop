using Andromeda.Interop.Protocols.Modbus.Abstractions.Assets.Translations;
using Andromeda.Localization.Abstractions;
using Andromeda.SourceGenerators.Enum;

namespace Andromeda.Interop.Protocols.Modbus.Abstractions.Enums
{
    [HasStrings<ITranslationUnit, ExMsgFormatter>(
        GenerateFunctions = true,
        StringsClass = nameof(ModbusExceptionCodesStrings),
        StringsNamespace = $"{nameof(Andromeda)}.{nameof(Interop)}.{nameof(Protocols)}.{nameof(Modbus)}.{nameof(Abstractions)}.{nameof(Assets)}.{nameof(Assets.Translations)}"
    )]
    public enum ModbusExceptionCodes : byte
    {
        /// <summary>
        /// Function code received in the query is not recognized
        /// or allowed by server
        /// </summary>
        InvalidFunctionCode = 0x01,

        /// <summary>
        /// Data address of some or all the required entities
        /// are not allowed or do not exist in server
        /// </summary>
        InvalidDataAddress = 0x02,

        /// <summary>
        /// Value is not accepted by server
        /// </summary>
        InvalidDataValue = 0x03,

        /// <summary>
        /// Unrecoverable error occurred while server was attempting
        /// to perform requested action
        /// </summary>
        ServerDeviceFailure = 0x04,

        /// <summary>
        /// Server has accepted request and is processing it,
        /// but a long duration of time is required. This response
        /// is returned to prevent a timeout error from occurring
        /// in the client. Client can next issue a Poll Program Complete
        /// message to determine whether processing is completed
        /// </summary>
        Acknowledge = 0x05,

        /// <summary>
        /// Server is engaged in processing a long-duration command;
        /// client should retry later
        /// </summary>
        ServerDeviceBusy = 0x06,

        /// <summary>
        /// Server cannot perform the programming functions;
        /// client should request diagnostic or error information from server
        /// </summary>
        NegativeAcknowledge = 0x07,

        /// <summary>
        /// Server detected a parity error in memory;
        /// client can retry the request
        /// </summary>
        MemoryParityError = 0x08,

        /// <summary>
        /// Specialized for Modbus gateways:
        /// indicates a misconfigured gateway
        /// </summary>
        GatewayPathUnavailable = 0x0A,

        /// <summary>
        /// Specialized for Modbus gateways:
        /// sent when server fails to respond
        /// </summary>
        GatewayTargetDeviceFailedToRespond = 0x0B,
    }

    internal class ExMsgFormatter : IFormatter<ITranslationUnit>
    {
        public string? AsString(ITranslationUnit? obj)
            => obj?.Value;
    }
}
