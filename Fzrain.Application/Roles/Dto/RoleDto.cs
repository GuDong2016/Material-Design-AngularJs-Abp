﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Fzrain.Authorization.Roles;

namespace Fzrain.Roles.Dto
{
    [AutoMapFrom(typeof(Role))]
    public class RoleDto : FullAuditedEntityDto<long>
    {
        public string  Name { get; set; }
        public bool IsStatic { get; set; }
        public bool IsDefault { get; set; }
    }
}
