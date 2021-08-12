using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountIntegration.Models.DO {
  public class DO_LoginInfo {
    public DO_LoginInfo() {

    }
    public string 帳號 { get; set; }

    public string 密碼 { get; set; }

    public string 客戶編號 { get; set; }

    public string 登入類型 { get; set; }
  }
}