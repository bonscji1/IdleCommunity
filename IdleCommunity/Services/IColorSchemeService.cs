using System.Collections.Generic;
using MudBlazor;

namespace IdleCommunity.Services
{
    public interface IColorSchemeService
    {
        Dictionary<string, Color> ColorScheme { get; }
    }
}