//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RandBaseTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RandBaseTable")]
  public partial class RandBaseTable : global::ProtoBuf.IExtensible
  {
    public RandBaseTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _BaseRatio;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"BaseRatio", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BaseRatio
    {
      get { return _BaseRatio; }
      set { _BaseRatio = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _QLP = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"QLP", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> QLP
    {
      get { return _QLP; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _QLOMin = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"QLOMin", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> QLOMin
    {
      get { return _QLOMin; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _QLOMax = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(5, Name=@"QLOMax", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> QLOMax
    {
      get { return _QLOMax; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}