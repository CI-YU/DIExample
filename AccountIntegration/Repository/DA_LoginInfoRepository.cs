using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountIntegration.Models.DO;
using AccountIntegration.Models.Interface;

namespace AccountIntegration.Repository {
  public class DA_LoginInfoRepository:ILoginRepository {
    private readonly string _connectionString = null;
    public DA_LoginInfoRepository(string connectionString) {
      if (string.IsNullOrEmpty(connectionString) == true) throw new ArgumentNullException();
      _connectionString = connectionString;
    }

    public DO_LoginInfo LoginInfo() {
      // TODO : 為了簡化範例複雜度，省略SQL存取。
      var LoginInfo = new DO_LoginInfo();
      return LoginInfo;
    }
  }
}