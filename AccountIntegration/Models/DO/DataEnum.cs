namespace Airiti.Common {
  #region 查詢連結 AND 或 OR 或 NOT
  public enum OpAndOr {
    AND,
    OR,
    NOT,
  }
  #endregion
  #region 欄位型別
  public enum OpDataType {
    Char,
    Date,
    Number,
    Varchar,
    Null
  }
  #endregion
  #region 是否附加Field Name
  public enum OpAppendName {
    No,
    Yes,
  }
  #endregion
  #region 欄位運算子
  public enum OpOperator {
    /// <summary>=</summary>
    Equals,
    /// <summary>&lt;&gt;</summary>
    NotEquals,
    /// <summary>&gt;=</summary>
    GreaterThanOrEquals,
    /// <summary>&lt;=</summary>
    LessThanOrEquals,
    /// <summary>&gt;</summary>
    GreaterThan,
    /// <summary>&lt;</summary>
    LessThan,
    /// <summary>Like '%xxx%'</summary>
    Like,
    /// <summary>Like '%xxx'</summary>
    LikeFirst,
    /// <summary>Like 'xxx%'</summary>
    LikeLast,
  }
  #endregion
  #region 回傳值
  /// <summary>
  /// 回傳值
  /// </summary>
  public enum OpReturnValue {
    /// <summary>執行成功</summary>
    Correct,
    /// <summary>執行失敗</summary>
    NotCorrect,
    /// <summary>執行成功！無法取得資料</summary>
    NoData,
    /// <summary>執行發生例外狀況</summary>
    Exception,
  }
  #endregion
  #region 錯誤訊息
  public enum OpErrNum {
    None,
    Exception,
  }
  #endregion
  #region 操作模式
  public enum OperateMode {
    Insert = 0, //新增
    Update = 1,//更新
    Delete = 2,//刪除
    //EXECSP = 3,//執行存儲過程
  }
  #endregion
}