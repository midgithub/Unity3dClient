//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: WarpStoneLevel.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WarpStoneLevel")]
  public partial class WarpStoneLevel : global::ProtoBuf.IExtensible
  {
    public WarpStoneLevel() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _TotalExp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"TotalExp", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int TotalExp
    {
      get { return _TotalExp; }
      set { _TotalExp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}