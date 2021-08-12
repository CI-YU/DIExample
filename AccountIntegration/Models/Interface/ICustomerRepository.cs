using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountIntegration.Models.Interface {

  //放業務流程，例如:
  public interface ICustomerRepository {
    //取得客戶資料
    DO_Customers GetCustomer();

    //取得客戶資料的key值
    string getCustomerLoginKey();
  }
}