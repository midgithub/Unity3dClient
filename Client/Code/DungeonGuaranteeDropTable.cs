//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DungeonGuaranteeDropTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonGuaranteeDropTable")]
  public partial class DungeonGuaranteeDropTable : global::ProtoBuf.IExtensible
  {
    public DungeonGuaranteeDropTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _MinTimes;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"MinTimes", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int MinTimes
    {
      get { return _MinTimes; }
      set { _MinTimes = value; }
    }
    private int _MaxTimes;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"MaxTimes", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int MaxTimes
    {
      get { return _MaxTimes; }
      set { _MaxTimes = value; }
    }
    private int _DropSet;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"DropSet", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int DropSet
    {
      get { return _DropSet; }
      set { _DropSet = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}