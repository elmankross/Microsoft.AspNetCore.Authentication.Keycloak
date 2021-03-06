﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jboss.AspNetCore.Authentication.Keycloak.PolicyRequirements.ResourceAccess
{
    public class ResourceAccess
    {
        [JsonPropertyName("roles")]
        public List<string> Roles { get; set; }
    }
}
