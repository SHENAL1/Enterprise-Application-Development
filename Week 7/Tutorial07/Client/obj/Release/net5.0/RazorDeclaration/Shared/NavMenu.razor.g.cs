// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tutorial07.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Tutorial07.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Tutorial07.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Tutorial07.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "F:\Documents\Level-6\Enterprise Application\Week 7\Shenal_Anthony_Tute07_W1742306\Tutorial07\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
