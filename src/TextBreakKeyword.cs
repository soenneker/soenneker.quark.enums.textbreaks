using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public partial class TextBreakKeyword
{
    public static readonly TextBreakKeyword Enable = new("enable");
    public static readonly TextBreakKeyword Disable = new("disable");
}
