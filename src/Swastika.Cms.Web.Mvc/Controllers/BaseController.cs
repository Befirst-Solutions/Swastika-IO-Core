// Licensed to the Swastika I/O Foundation under one or more agreements.
// The Swastika I/O Foundation licenses this file to you under the GNU General Public License v3.0 license.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Swastika.Cms.Lib;
using Swastika.Cms.Lib.Services;
using Swastika.Common.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Swastika.Cms.Mvc.Controllers
{
    public class BaseController<T> : Controller
    {
        public ViewContext ViewContext { get; set; }
        protected string _lang;
        protected string _domain;
        protected IHostingEnvironment _env;
        public const string CONST_ROUTE_DEFAULT_CULTURE = SWCmsConstants.Default.Specificulture;

        public BaseController(IHostingEnvironment env)
        {
            _env = env;
            string lang = RouteData != null && RouteData.Values["culture"] != null
               ? RouteData.Values["culture"].ToString() : CONST_ROUTE_DEFAULT_CULTURE;
        }

        //public BaseController(IHostingEnvironment env, IStringLocalizer<SharedResource> localizer)
        //{
        //    _env = env;
        //    string lang = RouteData != null && RouteData.Values["culture"] != null
        //        ? RouteData.Values["culture"].ToString() : CONST_ROUTE_DEFAULT_CULTURE;
        //    listCultures = listCultures ?? CultureRepository.GetInstance().GetModelList();
        //}

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!string.IsNullOrEmpty(GlobalConfigurationService.Instance.GetConnectionString()))
            {
                GetLanguage();
            }
            base.OnActionExecuting(context);
        }

        protected void GetLanguage()
        {
            _lang = RouteData != null && RouteData.Values["culture"] != null
                ? RouteData.Values["culture"].ToString() : CONST_ROUTE_DEFAULT_CULTURE;
            _domain = string.Format("{0}://{1}", Request.Scheme, Request.Host);
            ViewBag.culture = _lang;
            //ViewBag.currentCulture = listCultures.FirstOrDefault(c => c.Specificulture == _lang);
            //ViewBag.cultures = listCultures;
        }

        protected async Task<List<string>> UploadListFileAsync(string folderPath)
        {
            List<string> result = new List<string>();
            var files = HttpContext.Request.Form.Files;
            foreach (var file in files)
            {
                string fileName = await UploadFileAsync(file, folderPath);
                if (!string.IsNullOrEmpty(fileName))
                {
                    result.Add(fileName);
                }
            }
            return result;
        }

        protected async Task<string> UploadFileAsync(IFormFile file, string folderPath)
        {
            if (file != null && file.Length > 0)
            {
                string fileName = await CommonHelper.UploadFileAsync(System.IO.Path.Combine(_env.WebRootPath, folderPath), file);
                if (!string.IsNullOrEmpty(fileName))
                {
                    string filePath = string.Format("{0}/{1}", folderPath, fileName);
                    return filePath;
                }
                else
                {
                    return string.Empty;
                }
            }
            else
            {
                return string.Empty;
            }
        }
    }
}