//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DungeonHellTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonHellTable")]
  public partial class DungeonHellTable : global::ProtoBuf.IExtensible
  {
    public DungeonHellTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _HardType;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"HardType", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int HardType
    {
      get { return _HardType; }
      set { _HardType = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _MonsterGroups = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"MonsterGroups", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> MonsterGroups
    {
      get { return _MonsterGroups; }
    }
  
    private int _Prob;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Prob", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Prob
    {
      get { return _Prob; }
      set { _Prob = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}