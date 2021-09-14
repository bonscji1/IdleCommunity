#pragma checksum "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbbd3e4aea4e5024c40c04f71a53ad98370ac5b8"
// <auto-generated/>
#pragma warning disable 1591
namespace IdleCommunity.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using IdleCommunity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using IdleCommunity.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(8);
                __builder2.AddAttribute(9, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
                      appMenuBarColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(11);
                    __builder3.AddAttribute(12, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 13 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 13 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(17);
                    __builder3.AddAttribute(18, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 14 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
                       Typo.h4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(20, "MainAppBar");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(22);
                __builder2.AddAttribute(23, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
                                                Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
                            _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDrawerHeader>(27);
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(29);
                        __builder4.AddAttribute(30, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 18 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "Class", "mt-1");
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(33, "Places");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n        ");
                    __builder3.OpenComponent<IdleCommunity.Shared.NavMenu>(35);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(37);
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(39, 
#nullable restore
#line 23 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
       
    
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/mnt/LinuxSpace/Work/Projects/IdleCommunity/IdleCommunity/Shared/MainLayout.razor"
       
    Color appMenuBarColor;
    protected override Task OnInitializedAsync()
    {
        appMenuBarColor = _colorSchemeService.ColorScheme[_navManager.Uri.Replace(_navManager.BaseUri, "/")];
        return base.OnInitializedAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IColorSchemeService _colorSchemeService { get; set; }
    }
}
#pragma warning restore 1591
