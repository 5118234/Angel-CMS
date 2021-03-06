﻿using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
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
    public class SiteRoleListViewComponent : ViewComponent
    {
        private SiteManager _siteManager;

        public SiteRoleListViewComponent(SiteManager siteManager)
        {
            _siteManager = siteManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string siteId  = "")
        {

            ViewData["siteId"] = siteId;

            return await Task.FromResult(View());
        }


    }
}
