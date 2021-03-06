﻿using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

using Angelo.Connect.Services;
using Angelo.Connect.Web.UI.ViewModels.Admin;
using Angelo.Connect.Models;
using AutoMapper.Extensions;
using Angelo.Common.Mvc.ActionResults;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Angelo.Connect.Web.UI.Components
{
    public class PoolRoleCreateViewComponent : ViewComponent
    {

        public PoolRoleCreateViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync(string poolId = "")
        {
            if (string.IsNullOrEmpty(poolId))
                return new ViewComponentPlaceholder();

            var model = new PoolRoleViewModel()
            {
                PoolId = poolId,
                IsDefault = false,
                IsLocked = false
            };
            return View("PoolRoleCreate", model);
        }


    }
}
