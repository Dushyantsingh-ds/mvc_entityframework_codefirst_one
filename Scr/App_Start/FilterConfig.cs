﻿using System.Web;
using System.Web.Mvc;

namespace Code_First_Approach_in_Entity_Framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}