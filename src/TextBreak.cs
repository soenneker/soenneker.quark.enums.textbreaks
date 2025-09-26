using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// An HTML CSS keyword set in .NET enumeration form
/// </summary>
[Intellenum<string>]
public partial class TextBreak
{
    public static readonly TextBreak Enable = new("enable");
    public static readonly TextBreak Disable = new("disable");

    public static implicit operator TextBreak(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
