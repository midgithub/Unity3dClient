//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LiaoTianDynamicTextureTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LiaoTianDynamicTextureTable")]
  public partial class LiaoTianDynamicTextureTable : global::ProtoBuf.IExtensible
  {
    public LiaoTianDynamicTextureTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Icon;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon
    {
      get { return _Icon; }
      set { _Icon = value; }
    }
    private int _Width;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Width", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Width
    {
      get { return _Width; }
      set { _Width = value; }
    }
    private int _Height;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Height", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Height
    {
      get { return _Height; }
      set { _Height = value; }
    }
    private int _Size;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Size", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Size
    {
      get { return _Size; }
      set { _Size = value; }
    }
    private ProtoTable.LiaoTianDynamicTextureTable.eType _Type;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.LiaoTianDynamicTextureTable.eType Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _Param = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(7, Name=@"Param", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> Param
    {
      get { return _Param; }
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eType")]
    public enum eType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Image", Value=0)]
      Image = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FrameSprite", Value=1)]
      FrameSprite = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}