//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ItemCollectionTable.proto
// Note: requires additional types generated from: Union.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemCollectionTable")]
  public partial class ItemCollectionTable : global::ProtoBuf.IExtensible
  {
    public ItemCollectionTable() {}
    
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
    private string _Icon;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon
    {
      get { return _Icon; }
      set { _Icon = value; }
    }
    private string _Level;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Level", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Level
    {
      get { return _Level; }
      set { _Level = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _Color = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(5, Name=@"Color", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> Color
    {
      get { return _Color; }
    }
  
    private ProtoTable.ItemCollectionTable.eTipsType _TipsType;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"TipsType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemCollectionTable.eTipsType TipsType
    {
      get { return _TipsType; }
      set { _TipsType = value; }
    }
    private int _ItemID;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ItemID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ItemID
    {
      get { return _ItemID; }
      set { _ItemID = value; }
    }
    private string _Desc;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Desc
    {
      get { return _Desc; }
      set { _Desc = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoTable.UnionCell> _TipsContent = new global::System.Collections.Generic.List<ProtoTable.UnionCell>();
    [global::ProtoBuf.ProtoMember(9, Name=@"TipsContent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoTable.UnionCell> TipsContent
    {
      get { return _TipsContent; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _Items = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(10, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> Items
    {
      get { return _Items; }
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eTipsType")]
    public enum eTipsType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SINGLE", Value=1)]
      SINGLE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"COLLECTION", Value=2)]
      COLLECTION = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}