using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.UseCase.Extentions
{
    public static class HttpContextHelper
    {
        public static IHttpContextAccessor Accessor { get; set; }
        public static HttpContext HttpContext => Accessor?.HttpContext;
        public static IHeaderDictionary ResponseHeaders => HttpContext?.Response?.Headers;
    }
}
