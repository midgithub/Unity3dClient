//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SoundTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SoundTable")]
  public partial class SoundTable : global::ProtoBuf.IExtensible
  {
    public SoundTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Descrip;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Descrip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Descrip
    {
      get { return _Descrip; }
      set { _Descrip = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _Path = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(3, Name=@"Path", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> Path
    {
      get { return _Path; }
    }
  
    private int _IsRandom;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"IsRandom", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int IsRandom
    {
      get { return _IsRandom; }
      set { _IsRandom = value; }
    }
    private int _Type;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}