﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreApp.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetSpecificClaims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var claim = claimsPrincipal.Claims.FirstOrDefault(x => x.Type == claimType);
            return (claim == null ? string.Empty : claim.Value);
        }
    }
}
