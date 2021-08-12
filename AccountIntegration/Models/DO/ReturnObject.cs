using System;
using System.Xml.Serialization;
using Airiti.Common;

namespace AccountIntegration.Models.DO {
  /// <summary>
  /// �^�Ǫ���
  /// </summary>
  /// <typeparam name="T"></typeparam>
  [Serializable]
  public class ReturnObject<T> {
    /// <summary>
    /// �^�ǭ�
    ///   0 = Correct(���榨�\) 
    ///   1 = NotCorrect(���楢��)
    ///   2 = NoData(���榨�\�I�L�k���o���)
    ///   3 = Exception(����o�ͨҥ~���p)
    /// </summary>
    public OpReturnValue ReturnValue { get; set; }
    /// <summary>
    /// ���~�^�ǰT��
    /// </summary>
    public string ReturnMessage { get; set; }
    /// <summary>
    /// �ҥ~���p�I�s���|�T��
    /// </summary>
    public string ReturnStackTrace { get; set; }
    /// <summary>
    /// �^�ǿ��~�N�X
    /// </summary>
    public OpErrNum ReturnErrNum { get; set; }
    /// <summary>
    /// �^�Ǹ��
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