﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using Angelo.Connect.Models;
using Angelo.Connect.News.Models;
using Angelo.Connect.News.UI.ViewModels.Validation;
using Angelo.Connect.Security;

namespace Angelo.Connect.News.UI.ViewModels
{
    public class NewsPostSettingsViewModel
    {
        public string NewsPostId { get; set; }

        public bool IsPrivate { get; set; }

        public IEnumerable<NewsCategory> Categories { get; set; }

        public IEnumerable<ContentVersion> Versions { get; set; }

        public IEnumerable<SecurityClaimConfig> PostPrivacyConfig { get; set; }
    }
}
