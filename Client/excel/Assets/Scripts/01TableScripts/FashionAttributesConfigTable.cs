//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FashionAttributesConfigTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FashionAttributesConfigTable")]
  public partial class FashionAttributesConfigTable : global::ProtoBuf.IExtensible
  {
    public FashionAttributesConfigTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _Attributes = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Attributes", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> Attributes
    {
      get { return _Attributes; }
    }
  
    private int _DefaultAttribute;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"DefaultAttribute", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int DefaultAttribute
    {
      get { return _DefaultAttribute; }
      set { _DefaultAttribute = value; }
    }
    private int _FreeSelecteTimes;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"FreeSelecteTimes", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int FreeSelecteTimes
    {
      get { return _FreeSelecteTimes; }
      set { _FreeSelecteTimes = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}