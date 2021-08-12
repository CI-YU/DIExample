using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AccountIntegration.Models;

namespace AccountIntegration.Controllers {
  public class LoginController : ApiController {

    /// <summary>
    /// 傳入客戶編號、帳號、密碼，進行登入動作，回傳是否成功
    /// </summary>
    /// <param name="客戶編號"></param>
    /// <param name="帳號"></param>
    /// <param name="密碼"></param>
    /// <returns></returns>
    public HttpResponseMessage Login(string 客戶編號, string 帳號, string 密碼) {
      var LoginData = new LoginService().Login(客戶編號, 帳號, 密碼);
      HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, LoginData);
      return response;
    }
  }
}
