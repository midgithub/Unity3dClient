//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GuidanceMainTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuidanceMainTable")]
  public partial class GuidanceMainTable : global::ProtoBuf.IExtensible
  {
    public GuidanceMainTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Desc;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc
    {
      get { return _Desc; }
      set { _Desc = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _LinkItems = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"LinkItems", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> LinkItems
    {
      get { return _LinkItems; }
    }
  
    private int _UnLockLevel;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"UnLockLevel", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int UnLockLevel
    {
      get { return _UnLockLevel; }
      set { _UnLockLevel = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}