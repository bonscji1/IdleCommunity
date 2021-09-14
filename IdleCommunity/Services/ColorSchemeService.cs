using System.Collections.Generic;
using MudBlazor;

namespace IdleCommunity.Services
{
    public class ColorSchemeService : IColorSchemeService
    {
/*todo: change colors to what i want*/
        public Dictionary<string, Color> ColorScheme { get; } = new ()
        {
            {"/",Color.Primary},
            {"/counter",Color.Dark}
        };
    }
}