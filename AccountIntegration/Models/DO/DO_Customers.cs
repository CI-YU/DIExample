using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountIntegration.Models {
  public class DO_Customers {

    public DO_Customers(string customerID) {
      if (string.IsNullOrEmpty(customerID) == true) throw new ArgumentNullException();
      CustomerID = customerID;
    }
    /// <summary>
    /// 客戶編號
    /// </summary>
    public string CustomerID { get; set; }

    /// <summary>
    /// 帳密整合連結網址
    /// </summary>
    public string WebURL { get; set; }

    /// <summary>
    /// 帳密整合post需使用的body參數
    /// </summary>
    public string Params { get; set; }

    /// <summary>
    /// 登入成功後的關鍵字
    /// </summary>
    public string SuccessKeyword { get; set; }

    /// <summary>
    /// 判斷是何種帳密整合
    /// </summary>
    public string SpecialParam { get; set; }
  }
}