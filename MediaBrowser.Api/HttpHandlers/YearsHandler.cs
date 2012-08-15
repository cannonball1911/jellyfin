﻿using System;
using MediaBrowser.Common.Net.Handlers;
using MediaBrowser.Controller;
using MediaBrowser.Model.Entities;

namespace MediaBrowser.Api.HttpHandlers
{
    public class YearsHandler : BaseJsonHandler
    {
        protected override object GetObjectToSerialize()
        {
            Folder parent = ApiService.GetItemById(QueryString["id"]) as Folder;
            Guid userId = Guid.Parse(QueryString["userid"]);

            return Kernel.Instance.GetAllYears(parent, userId);
        }
    }
}
