using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Membership.OpenAuth;

namespace Mojosol
{
    internal static class AuthConfig
    {
        public static void RegisterOpenAuth()
        {
            // See http://go.microsoft.com/fwlink/?LinkId=252803 for details on setting up this ASP.NET
            // application to support logging in via external services.

            OpenAuth.AuthenticationClients.AddTwitter(
                consumerKey: "KztTs2PVdJk2k5W2afS6w",
                consumerSecret: "vo7YwAqYxPVkOzW1xnkd2ZUvu3rFEWkbj9gWG5FHbsE");

            OpenAuth.AuthenticationClients.AddFacebook(
                appId: "404440493022558",
                appSecret: "05bf4777a1ff432c76658d96e53e88dd");

            OpenAuth.AuthenticationClients.AddMicrosoft(
                clientId: "000000004410C5A3",
                clientSecret: "ByoP7kqChjIZrPAnA1rDcSZjIc5qANSh");

            OpenAuth.AuthenticationClients.AddGoogle();
        }
    }
}