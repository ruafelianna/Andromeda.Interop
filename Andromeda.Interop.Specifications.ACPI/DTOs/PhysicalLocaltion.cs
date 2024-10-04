using System.Drawing;
using Andromeda.Interop.Specifications.ACPI.Enums;

namespace Andromeda.Interop.Specifications.ACPI.DTOs
{
    /// <param name="Revision">6:0</param>
    /// <param name="IgnoreColor">7</param>
    /// <param name="Color">31:8 (red 8:15, green 16:23, blue 24:31)</param>
    /// <param name="Width">47:32</param>
    /// <param name="Height">63:48</param>
    /// <param name="UserVisible">64</param>
    /// <param name="Dock">65</param>
    /// <param name="Lid">66</param>
    /// <param name="Panel">69:67</param>
    /// <param name="VerticalPosition">71:70</param>
    /// <param name="HorizontalPosition">73:72</param>
    /// <param name="Shape">77:74</param>
    /// <param name="GroupOrientation">78</param>
    /// <param name="GroupToken">86:79</param>
    /// <param name="GroupPosition">94:87</param>
    /// <param name="Bay">95</param>
    /// <param name="Ejectable">96</param>
    /// <param name="OSPMEjectionRequired">97</param>
    /// <param name="CabinetNumber">105:98</param>
    /// <param name="CardCageNumber">113:106</param>
    /// <param name="Reference">114</param>
    /// <param name="Rotation">118:115</param>
    /// <param name="Order">123:119</param>
    /// <param name="Reserved">127:124</param>
    /// <param name="VerticalOffset">143:128</param>
    /// <param name="HorizontalOffset">159:144</param>
    public record PhysicalLocaltion(
        byte Revision,
        bool IgnoreColor,
        Color Color,
        ushort Width,
        ushort Height,
        bool UserVisible,
        bool Dock,
        bool Lid,
        Panel Panel,
        VerticalPosition VerticalPosition,
        HorizontalPosition HorizontalPosition,
        Shape Shape,
        bool GroupOrientation,
        byte GroupToken,
        byte GroupPosition,
        bool Bay,
        bool Ejectable,
        bool OSPMEjectionRequired,
        byte CabinetNumber,
        byte CardCageNumber,
        bool Reference,
        Rotation Rotation,
        byte Order,
        byte Reserved,
        ushort? VerticalOffset,
        ushort? HorizontalOffset
    );
}
