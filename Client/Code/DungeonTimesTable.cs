//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DungeonTimesTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonTimesTable")]
  public partial class DungeonTimesTable : global::ProtoBuf.IExtensible
  {
    public DungeonTimesTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _BaseTimes;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BaseTimes", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BaseTimes
    {
      get { return _BaseTimes; }
      set { _BaseTimes = value; }
    }
    private int _BaseBuyTimes;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"BaseBuyTimes", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BaseBuyTimes
    {
      get { return _BaseBuyTimes; }
      set { _BaseBuyTimes = value; }
    }
    private int _BuyTimesVipPrivilege;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"BuyTimesVipPrivilege", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BuyTimesVipPrivilege
    {
      get { return _BuyTimesVipPrivilege; }
      set { _BuyTimesVipPrivilege = value; }
    }
    private int _BuyTimesCostItemID;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"BuyTimesCostItemID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BuyTimesCostItemID
    {
      get { return _BuyTimesCostItemID; }
      set { _BuyTimesCostItemID = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _BuyTimesCost = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(6, Name=@"BuyTimesCost", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> BuyTimesCost
    {
      get { return _BuyTimesCost; }
    }
  
    private string _UsedTimesCounter;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"UsedTimesCounter", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UsedTimesCounter
    {
      get { return _UsedTimesCounter; }
      set { _UsedTimesCounter = value; }
    }
    private string _BuyTimesCounter;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"BuyTimesCounter", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string BuyTimesCounter
    {
      get { return _BuyTimesCounter; }
      set { _BuyTimesCounter = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}