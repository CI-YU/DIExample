using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountIntegration.Models {
  public class DO_Accounts {

    /// <summary>
    /// 客戶編號
    /// </summary>
    public string CustomerID { get; set; }

    /// <summary>
    /// 帳密整合連結網址
    /// </summary>
    public string WebURL { get; set; }

    /// <summary>
    /// 帳密整合需使用的參數
    /// </summary>
    public string Params { get; set; }

  }
}