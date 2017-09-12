/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using AspNet.Security.OAuth.Weibo;
using JetBrains.Annotations;
using System;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// Extension methods to add Weibo authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class WeiboAppBuilderExtensions
    {
        /// <summary>
        /// UseWeiboAuthentication is obsolete.Configure Weibo authentication with AddAuthentication().AddWeibo in ConfigureServices.See https://go.microsoft.com/fwlink/?linkid=845470 for more details.
        /// </summary>
        /// <param name="app">The <see cref="IApplicationBuilder"/> to add the middleware to.</param>
        /// <param name="options">A <see cref="WeiboOptions"/> that specifies options for the middleware.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        [Obsolete("UseWeiboAuthentication is obsolete. Configure Weibo authentication with AddAuthentication().AddWeibo in ConfigureServices. See https://go.microsoft.com/fwlink/?linkid=845470 for more details.", error: true)]
        public static IApplicationBuilder UseWeiboAuthentication(
            [NotNull] this IApplicationBuilder app,
            [NotNull] WeiboOptions options)
        {
            throw new NotSupportedException("This method is no longer supported, see https://go.microsoft.com/fwlink/?linkid=845470");
        }

        /// <summary>
        /// UseWeiboAuthentication is obsolete.Configure Weibo authentication with AddAuthentication().AddWeibo in ConfigureServices.See https://go.microsoft.com/fwlink/?linkid=845470 for more details.
        /// </summary>
        /// <param name="app">The <see cref="IApplicationBuilder"/> to add the middleware to.</param>
        /// <param name="configuration">An action delegate to configure the provided <see cref="WeiboOptions"/>.</param>
        /// <returns>A reference to this instance after the operation has completed.</returns>
        [Obsolete("UseWeiboAuthentication is obsolete. Configure Weibo authentication with AddAuthentication().AddWeibo in ConfigureServices. See https://go.microsoft.com/fwlink/?linkid=845470 for more details.", error: true)]
        public static IApplicationBuilder UseWeiboAuthentication(
            [NotNull] this IApplicationBuilder app,
            [NotNull] Action<WeiboOptions> configuration)
        {
            throw new NotSupportedException("This method is no longer supported, see https://go.microsoft.com/fwlink/?linkid=845470");
        }
    }
}
