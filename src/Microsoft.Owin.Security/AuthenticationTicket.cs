// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Security.Claims;

namespace Microsoft.Owin.Security
{
    public class AuthenticationTicket
    {
        public AuthenticationTicket(ClaimsIdentity identity, AuthenticationProperties properties)
        {
            Identity = identity;
            Properties = properties;
        }

        public AuthenticationTicket(ClaimsIdentity identity, IDictionary<string, string> extra)
        {
            Identity = identity;
            Properties = new AuthenticationProperties(extra);
        }

        public ClaimsIdentity Identity { get; private set; }
        public AuthenticationProperties Properties { get; private set; }
    }
}
