﻿using System.Web;
using System.Web.Mvc;

namespace Aula_03___ExemploValidacao
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}