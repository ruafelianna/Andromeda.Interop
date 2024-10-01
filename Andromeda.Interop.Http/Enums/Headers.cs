using Andromeda.SourceGenerators.Enum;

namespace Andromeda.Interop.Http.Enums
{
    [HasConstStrings(ConstClass = nameof(HeaderConsts))]
    public enum Headers
    {
        Accept,
        ContentType,
    }

    public static class HeaderConsts
    {
        public const string Accept = "Accept";

        public const string ContentType = "Content-Type";
    }
}
