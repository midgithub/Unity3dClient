//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: BuffDrugConfigTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BuffDrugConfigTable")]
  public partial class BuffDrugConfigTable : global::ProtoBuf.IExtensible
  {
    public BuffDrugConfigTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private string _Description;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Description
    {
      get { return _Description; }
      set { _Description = value; }
    }
    private int _FreeUseLevel;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"FreeUseLevel", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int FreeUseLevel
    {
      get { return _FreeUseLevel; }
      set { _FreeUseLevel = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}