﻿using System.Collections.Generic;

namespace Fzrain.Authorization.Roles
{
    internal class RoleManagementConfig : IRoleManagementConfig
    {
        public List<StaticRoleDefinition> StaticRoles { get; }

        public RoleManagementConfig()
        {
            StaticRoles = new List<StaticRoleDefinition>();
        }
    }
}