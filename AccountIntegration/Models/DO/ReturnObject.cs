using System;
using System.Xml.Serialization;
using Airiti.Common;

namespace AccountIntegration.Models.DO {
  /// <summary>
  /// 回傳物件
  /// </summary>
  /// <typeparam name="T"></typeparam>
  [Serializable]
  public class ReturnObject<T> {
    /// <summary>
    /// 回傳值
    ///   0 = Correct(執行成功) 
    ///   1 = NotCorrect(執行失敗)
    ///   2 = NoData(執行成功！無法取得資料)
    ///   3 = Exception(執行發生例外狀況)
    /// </summary>
    public OpReturnValue ReturnValue { get; set; }
    /// <summary>
    /// 錯誤回傳訊息
    /// </summary>
    public string ReturnMessage { get; set; }
    /// <summary>
    /// 例外狀況呼叫堆疊訊息
    /// </summary>
    public string ReturnStackTrace { get; set; }
    /// <summary>
    /// 回傳錯誤代碼
    /// </summary>
    public OpErrNum ReturnErrNum { get; set; }
    /// <summary>
    /// 回傳資料
    /// </summary>
    [XmlElement("T")]
    public T ReturnData { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public ReturnObject() {
      ReturnErrNum = OpErrNum.None;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="pException"></param>
    public void SetException(Exception pException) {
      ReturnValue = OpReturnValue.Exception;
      ReturnErrNum = OpErrNum.Exception;
      ReturnStackTrace = pException.StackTrace;
      ReturnMessage = pException.Message;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="pSource"></param>
    /// <typeparam name="TSource"></typeparam>
    public void SetErrorReturn<TSource>(ReturnObject<TSource> pSource) {
      ReturnValue = pSource.ReturnValue;
      ReturnStackTrace = pSource.ReturnStackTrace;
      ReturnErrNum = pSource.ReturnErrNum;
      ReturnMessage = pSource.ReturnMessage;
    }
  }
}