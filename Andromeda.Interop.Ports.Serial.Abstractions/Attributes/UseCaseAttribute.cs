using System;

namespace Andromeda.Interop.Ports.Serial.Abstractions.Attributes
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    public sealed class UseCaseAttribute : Attribute
    {
        public UseCaseAttribute(string application)
        {
            Application = application;
        }

        public string Application { get; }
    }
}
