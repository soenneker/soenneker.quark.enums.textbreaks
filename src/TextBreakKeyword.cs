using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[Intellenum<string>]
public partial class TextBreakKeywordKeyword
{
    public static readonly TextBreakKeyword Enable = new("enable");
    public static readonly TextBreakKeyword Disable = new("disable");

    public static implicit operator TextBreakKeyword(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
