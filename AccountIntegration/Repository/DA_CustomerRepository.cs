using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountIntegration.Models;
using AccountIntegration.Models.Interface;

namespace AccountIntegration.Repository {
  public class DA_CustomerRepository : ICustomerRepository {
    private readonly string _connectionString = null;
    public DA_CustomerRepository(string connectionString) {
      if (string.IsNullOrEmpty(connectionString) == true) throw new ArgumentNullException();
      _connectionString = connectionString;
    }

    public DO_Customers GetCustomer() {
      // TODO : 為了簡化範例複雜度，省略SQL存取。
      var customer = new DO_Customers("客戶編號");
      return customer;
    }

    public string getCustomerLoginKey() {
      // TODO : 為了簡化範例複雜度，省略SQL存取。
      var customer = new DO_Customers("客戶編號");
      return "";
    }
  }
}