using Andromeda.SourceGenerators.Enum;

namespace Andromeda.Interop.Protocols.Http.Enums
{
    [HasStrings(StringsClass = nameof(MimeTypeConsts))]
    public enum MimeTypes
    {
        ApplicationJson,
        TextPlain,
    }

    public static class MimeTypeConsts
    {
        public const string Application = "application";

        public const string Text = "text";

        // ---------------------------------------------

        public const string Json = "json";

        public const string Plain = "plain";

        // ---------------------------------------------

        public const string ApplicationJson = $"{Application}/{Json}";

        public const string TextPlain = $"{Text}/{Plain}";
    }
}
