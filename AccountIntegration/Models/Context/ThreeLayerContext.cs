using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountIntegration.Models.Interface;

namespace AccountIntegration.Models.Context {
  public partial class ThreeLayerContext {
    // Locator
    private static ThreeLayerContext _current;

    public static ThreeLayerContext Current {
      get {
        // Require
        if (_current == null) throw new InvalidOperationException();

        // Return
        return _current;
      }
    }

    public static void Initialize(ThreeLayerContext context) {
      #region Contracts

      if (context == null) throw new ArgumentNullException();

      #endregion

      // Arguments
      _current = context;
    }
  }

  public partial class ThreeLayerContext {
    // Constructors
    public ThreeLayerContext(ICustomerRepository customerRepository, IAccountRepository AccountRepository) {
      #region Contracts

      if (customerRepository == null) throw new ArgumentNullException();

      #endregion

      // Arguments
      this.CustomerRepository = customerRepository;
    }   
    // Properties
    public ICustomerRepository CustomerRepository { get; private set; }

    public IAccountRepository AccountRepository { get; private set; }
  }
}