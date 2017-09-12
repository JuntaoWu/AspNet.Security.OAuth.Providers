/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System;
using Microsoft.AspNetCore.Authentication;
using AspNet.Security.OAuth.Weibo;
using JetBrains.Annotations;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class WeiboExtensions
    {
        public static AuthenticationBuilder AddMicrosoftAccount(this AuthenticationBuilder builder)
            => builder.AddMicrosoftAccount(WeiboDefaults.AuthenticationScheme, _ => { });

        public static AuthenticationBuilder AddMicrosoftAccount(this AuthenticationBuilder builder, Action<WeiboOptions> configureOptions)
            => builder.AddMicrosoftAccount(WeiboDefaults.AuthenticationScheme, configureOptions);

        public static AuthenticationBuilder AddMicrosoftAccount(this AuthenticationBuilder builder, string authenticationScheme, Action<WeiboOptions> configureOptions)
            => builder.AddMicrosoftAccount(authenticationScheme, WeiboDefaults.DisplayName, configureOptions);

        public static AuthenticationBuilder AddMicrosoftAccount(this AuthenticationBuilder builder, string authenticationScheme, string displayName, Action<WeiboOptions> configureOptions)
            => builder.AddOAuth<WeiboOptions, WeiboHandler>(authenticationScheme, displayName, configureOptions);

    }
}
