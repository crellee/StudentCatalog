﻿using System.Web;
using System.Web.Mvc;

namespace StudentCatalogFall2016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
