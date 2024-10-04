namespace Andromeda.Interop.Ports.Serial.Abstractions.Enums
{
    public enum Parity : byte
    {
        /// <summary>
        /// no parity bit is sent and the transmission is shortened
        /// </summary>
        None = 0,

        /// <summary>
        /// the parity bit is set so that the number of 1 bits is odd
        /// </summary>
        Odd = 1,

        /// <summary>
        /// the parity bit is set so that the number of 1 bits is even
        /// </summary>
        Even = 2,

        /// <summary>
        /// the parity bit is always set to the mark signal condition (1 bit value)
        /// </summary>
        Mark = 3,

        /// <summary>
        /// always sends the parity bit in the space signal condition (0 bit value)
        /// </summary>
        Space = 4,
    }
}
