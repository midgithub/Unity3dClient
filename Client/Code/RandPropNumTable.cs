//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RandPropNumTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RandPropNumTable")]
  public partial class RandPropNumTable : global::ProtoBuf.IExtensible
  {
    public RandPropNumTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private ProtoTable.RandPropNumTable.eColor _Color;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.RandPropNumTable.eColor Color
    {
      get { return _Color; }
      set { _Color = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _Value = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> Value
    {
      get { return _Value; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _Weight = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(4, Name=@"Weight", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> Weight
    {
      get { return _Weight; }
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eColor")]
    public enum eColor
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"WHITE", Value=1)]
      WHITE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BLUE", Value=2)]
      BLUE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PURPLE", Value=3)]
      PURPLE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GREEN", Value=4)]
      GREEN = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PINK", Value=5)]
      PINK = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"YELLOW", Value=6)]
      YELLOW = 6
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}