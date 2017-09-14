/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;

namespace AspNet.Security.OAuth.Weibo
{
    /// <summary>
    /// Default values for Weibo authentication.
    /// </summary>
    public static class WeiboDefaults
    {
        public const string AuthenticationScheme = "Weibo";

        public const string DisplayName = "Weibo";

        public const string CallbackPath = "/signin-weibo";

        public const string Issuer = "Weibo";

        public const string AuthorizationEndpoint = "https://api.weibo.com/oauth2/authorize";

        public const string TokenEndpoint = "https://api.weibo.com/oauth2/access_token";

        public const string UserInformationEndpoint = "https://api.weibo.com/2/users/show.json";

        public const string RevokeAuthorizationEndpoint = "";
    }
}
