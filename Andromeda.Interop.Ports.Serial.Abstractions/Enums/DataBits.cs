namespace Andromeda.Interop.Ports.Serial.Abstractions.Enums
{
    public enum DataBits : byte
    {
        /// <summary>
        /// For Baudot code
        /// </summary>
        Five = 5,

        /// <summary>
        /// Rarely used
        /// </summary>
        Six = 6,

        /// <summary>
        /// For ASCII
        /// </summary>
        Seven = 7,

        /// <summary>
        /// Most commonly used
        /// </summary>
        Eight = 8,

        /// <summary>
        /// Rarely used
        /// </summary>
        Nine = 9,
    }
}
