//===============================================================================
// Microsoft FastTrack for Azure
// WebForms and ASMX with Azure AD Authentication Samples
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASMXWebDemo
{
    public partial class _Default : Page
    {
        protected readonly Dictionary<string, string> UserInformation = new Dictionary<string, string>();
        protected readonly Dictionary<string, string> DatabaseInformation = new Dictionary<string, string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
            {
                HttpContext.Current.GetOwinContext().Authentication.Challenge(
                    new AuthenticationProperties { RedirectUri = "/" },
                    OpenIdConnectAuthenticationDefaults.AuthenticationType);
            }
            else
            {
                // Get current user information.
                try
                {
                    foreach (var claim in ((System.Security.Claims.ClaimsIdentity)User.Identity).Claims)
                    {
                        this.UserInformation[claim.Type] = claim.Value;
                    }
                }
                catch (Exception exc)
                {
                    this.UserInformation["ExceptionMessage"] = exc.Message;
                    this.UserInformation["ExceptionDetails"] = exc.ToString();
                }
            }
        }
    }
}