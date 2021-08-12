using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountIntegration.Models.Context;
using AccountIntegration.Models.DO;
using AccountIntegration.Repository;

namespace AccountIntegration.Models {
  #region Login interface
  public interface ILogin {
    /// <summary>
    /// 傳入客戶編號、帳號、密碼，進行登入動作
    /// </summary>
    /// <param name="客戶編號">客戶編號</param>
    /// <param name="帳號">帳號</param>
    /// <param name="密碼">密碼</param>
    /// <returns></returns>
    bool Login(string 客戶編號, string 帳號, string 密碼);
  }
  #endregion

  #region Login abstract class 
  public abstract class ALogin : ILogin {
    public abstract bool Login(string 客戶編號, string 帳號, string 密碼);

    /// <summary>
    /// 依據客戶編號取得客戶登入相關資訊
    /// </summary>
    /// <param name="客戶編號">客戶編號</param>
    /// <returns></returns>
    public DO_Customers getCustomerInfo(string 客戶編號) {
      #region 必要宣告

      #endregion

      #region 額外宣告
      var objReturn = new DO_Customers(客戶編號);
      #endregion

      try {

        objReturn = ThreeLayerContext.Current.CustomerRepository.GetCustomer();
        return objReturn;
        //#region Step 1 記錄傳入參數

        //#endregion

        //#region Step 2 組成Sql語法

        //#endregion

        //#region Step 3 執行Sql語法
        //#region Step 3-1 判斷語法是否執行成功
        //#region Step 3-1-1 執行失敗，紀錄錯誤，回傳Null

        //#endregion

        //#region Step 3-1-2 成行成功，紀錄成功，回傳客戶登入設定資訊

        //#endregion      
        //#endregion
        //#endregion
      } catch (Exception e) {

      } finally {

      }
      return objReturn;
    }


  }
  #endregion

  #region controller入口 class
  public class LoginService {
    #region Dictionary:登入種類
    private readonly Dictionary<string, ILogin> _TypeOfService = new Dictionary<string, ILogin> {
      {"JavaWebService", new JavaWebServiceLogin()},
   };
    #endregion

    public ReturnObject<LoginData> Login(string 客戶編號, string 帳號, string 密碼) {
      #region 必要宣告

      #endregion

      #region 額外宣告
      var objReturn = new ReturnObject<LoginData>();
      bool IsSuccess = false;
      #endregion
      try {
        #region Step 1 依據客戶編號取得客戶登入相關資訊
        var CustomerLoginInfo = getCustomerLoginInfo("客戶編號");
        #endregion

        #region Step 2 判斷資料是否取得完成
        #region Step 2-1 判斷CustomerLoginKey是否有設定
        if (string.IsNullOrEmpty(CustomerLoginKey)) {
          throw new Exception("");
        }
        #endregion

        #region  Step 2-2 判斷CustomerLoginKey是否設定正確
        if (!_TypeOfService.ContainsKey(CustomerLoginKey))
          throw new ArgumentException("非這幾類登入模式");
        #endregion
        #endregion

        #region 判斷帳號密碼是否需額外處理
        var 帳號密碼加密清單 = getEncrypt(CustomerLoginInfo, 帳號, 密碼);
        #endregion

        #region Step 3 依據客戶登入類型執行登入動作 
        IsSuccess = _TypeOfService[CustomerLoginKey].Login("客戶編號", "帳號", "密碼");
        #endregion

        #region Step 4 客戶帳號登入是否成功，當登入失敗，回傳錯誤訊息
        if (!IsSuccess) {
          throw new Exception("");
        }
        #endregion

        #region Step 5 檢查521A帳號是否已存在，
        #region Step 5-1 521A帳號不存在，新增資料到521A，回傳登入資訊，告訴使用者因為是首次使用，詢問是否要不要綁定華藝母帳號
        #endregion
        #endregion

        #region Step 6 521A帳號已存在，檢查522帳號是否存在
        #region Step 6-1 522帳號不存在，回傳521A帳號進行登入

        #endregion

        #region Step 6-2 522帳號存在，更新522使用期限，並回傳華藝母帳號進行登入

        #endregion
        #endregion
      } catch (Exception e) {
        //TODO 待完成錯誤處理 
        return objReturn;
      } finally { }
      return objReturn;
    }

    /// <summary>
    /// 新增使用者帳號
    /// </summary>
    /// <param name="客戶編號">客戶編號</param>
    /// <param name="帳號">帳號</param>
    /// <returns></returns>
    public bool AddAccountInfo(string 客戶編號, string 帳號) {
      #region 必要宣告

      #endregion

      #region 額外宣告
      var objReturn = false;
      #endregion

      try {
        #region Step 1 紀錄傳入參數

        #endregion
        #region Step 2 組合Sql語法

        #endregion

        #region Step 3 執行Sql語法

        #endregion
      } catch (Exception) {

        throw;
      } finally { }
      return objReturn;
    }

    /// <summary>
    /// 依客戶編號及帳號檢查TBL521A資料是否已經存在
    /// </summary>
    /// <param name="客戶編號">客戶編號</param>
    /// <param name="帳號">帳號</param>
    /// <returns></returns>
    public bool IsTBL521ADataExist(string 客戶編號, string 帳號) {
      #region 必要宣告

      #endregion

      #region 額外宣告
      var objReturn = false;
      #endregion
      try {

        #region 記錄傳入參數

        #endregion

        #region 組Sql語法

        #endregion

        #region 執行Sql語法
        #region Step 1 如果帳號已存在=>回傳true

        #endregion

        #region Step 2 如果帳號不存在=>回傳false
        #endregion
        #endregion

      } catch (Exception e) {

        return objReturn;
      } finally { }
      return objReturn;
    }
    /// <summary>
    /// 依客戶編號及帳號檢查TBL522資料是否已經存在
    /// </summary>
    /// <param name="客戶編號"></param>
    /// <param name="帳號"></param>
    /// <returns></returns>
    public bool IsTBL522DataExist(string 客戶編號, string 帳號) {
      #region 必要宣告

      #endregion

      #region 額外宣告
      var objReturn = false;
      #endregion
      try {

        #region 記錄傳入參數

        #endregion

        #region 組Sql語法

        #endregion

        #region 執行Sql語法
        #region Step 1 如果帳號已存在=>回傳true

        #endregion

        #region Step 2 如果帳號不存在=>回傳false
        #endregion
        #endregion

      } catch (Exception e) {

        return objReturn;
      } finally { }
      return objReturn;
    }

    /// <summary>
    /// 取得帳密整合登入資料
    /// </summary>
    /// <param name="客戶編號"></param>
    /// <returns></returns>
    private DO_Customers getCustomerLoginInfo(string 客戶編號) {
      #region 必要宣告

      #endregion

      #region 額外宣告
      var objReturn = new DO_Customers(客戶編號);
      #endregion
      try {
        objReturn = ThreeLayerContext.Current.CustomerRepository.GetCustomer();
        return objReturn;
      } catch (Exception e) {
        //TODO 待完成錯誤處理 
        return objReturn;
      } finally { }
    }

    /// <summary>
    /// 判斷帳號密碼是否要額外加密，要的話在這執行加密
    /// </summary>
    /// <param name="CustomerData">客戶帳整資料(從DB來的)</param>
    /// <param name="帳號">使用者輸入帳號</param>
    /// <param name="密碼">使用者輸入密碼</param>
    /// <returns></returns>
    public List<object> getEncrypt(DO_Customers CustomerData, string 帳號, string 密碼) {
      #region 必要宣告
      #endregion
      #region 額外宣告 
      var returnObj = new List<object>();
      #endregion
      try {
        #region Step 1 判斷傳入參數是否設定正確
        #region Step 1-1 失敗，回傳沒傳入參數的錯誤訊息
        #endregion
        #endregion
        #region Step 2 根據客戶編號做該客戶指定的加密動作
        #endregion
      } catch (Exception e) {

      } finally {

      }
      return returnObj;
    }
  }

  #endregion

  #region JavaWebServiceLogin class
  /// <summary>
  /// JavawebService登入模組
  /// </summary>
  public class JavaWebServiceLogin : ALogin {
    public override bool Login(string 客戶編號, string 帳號, string 密碼) {
      #region 必要宣告

      #endregion

      #region 額外宣告
      DO_LoginInfo LoginInfo = null;
      #endregion
      try {
        #region Step 1 依據客戶編號取得webServicelLogin相關資訊
        getCustomerInfo("");
        #region Step 1-1 判斷資料是否取得完成

        #region Step 1-1-1 資料取得成功

        #endregion

        #region Step 1-1-2 資料取得失敗

        #endregion

        #endregion  
        #endregion

        #region Step 2 執行登入動作
        Login(LoginInfo);
        #endregion

      } catch (Exception e) {
        //TODO 待完成錯誤處理 
        return false;
      } finally { }
      return true;
    }

    public bool Login(DO_LoginInfo PLoginInfo) {
      #region 必要宣告

      #endregion

      #region 額外宣告

      #endregion
      try {
        #region Step 1 取得回傳值

        #region Step 1-1 判斷取得回傳值是否成功
        #region Step 1-1-1 資料取得成功

        #endregion

        #region Step 1-1-2 資料取得失敗

        #endregion
        #endregion

        #endregion

        #region Step 2 判斷回傳值是否登入成功

        #region Step 2-1 登入成功

        #region Step 2-1-1 依客戶編號及帳號檢查帳號資料是否已經存在
        if (!IsAccountExist("", "")) {
          #region Step 3-1-1-1 如果帳號不存在=>新增帳號資料
          var IsOk = AddAccountInfo("", "");
          if (IsOk) {
            #region Step 3-1-1-1-1 成功=>回傳true 
            #endregion
          } else {
            #region Step 3-1-1-1-2 失敗=>未確認
            //TODO 新增帳號失敗，
            #endregion
          }
          #endregion
        }
        #endregion

        #endregion

        #region Step 2-2 登入失敗

        #endregion

        #endregion

      } catch (Exception e) {
        //TODO 待完成錯誤處理 
        return false;
      } finally { }
      return true;
    }
  }
  #endregion

  public class LoginData { }
}

