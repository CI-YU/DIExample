using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountIntegration.Models.DO;

namespace AccountIntegration.Models.Interface {
  public interface ILoginRepository {
    DO_LoginInfo LoginInfo();
  }
}