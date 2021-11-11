using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;

namespace MyModule
{
    public class AdminMenu : INavigationProvider
    {
        private readonly IStringLocalizer S;

        public AdminMenu(IStringLocalizer<AdminMenu> localizer)
        {
            S = localizer;
        }

        public Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            // We want to add our menus to the "admin" menu only.
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return Task.CompletedTask;
            }

            // Adding our menu items to the builder.
            // The builder represents the full admin menu tree.
            builder
                .Add(S["My Root View"], S["My Root View"].PrefixPosition(),  rootView => rootView               
                    .Add(S["Child One"], S["Child One"].PrefixPosition(), childOne => childOne
                        .Action("ChildOne", "DemoNav", new { area = "MyModule"}))
                    .Add(S["Child Two"], S["Child Two"].PrefixPosition(), childTwo => childTwo
                        .Action("ChildTwo", "DemoNav", new { area = "MyModule"})));

            return Task.CompletedTask;
        }
    }
}