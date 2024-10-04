using System;

namespace Andromeda.Interop.Ports.Serial.Abstractions.Attributes
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    public sealed class IsWindowsPredefinedAttribute : Attribute
    {
        public IsWindowsPredefinedAttribute()
        {
        }
    }
}
