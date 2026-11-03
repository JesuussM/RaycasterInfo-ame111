using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace RaycasterInfo_ame111.Components.Layout
{
    public partial class MainLayout
    {
        [Inject]
        private IJSRuntime JSRuntime { get; set; } = default!;
        private async Task ScrollToSection(string elementId)
        {
            await JSRuntime.InvokeVoidAsync("eval",
                $"document.getElementById('{elementId}')?.scrollIntoView({{ behavior: 'smooth' }});");
        }
    }
}
