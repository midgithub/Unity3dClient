//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RaceEndDropTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RaceEndDropTable")]
  public partial class RaceEndDropTable : global::ProtoBuf.IExtensible
  {
    public RaceEndDropTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private int _DungeonID;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"DungeonID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int DungeonID
    {
      get { return _DungeonID; }
      set { _DungeonID = value; }
    }
    private int _LevelRange;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"LevelRange", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int LevelRange
    {
      get { return _LevelRange; }
      set { _LevelRange = value; }
    }
    private string _DropSets;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"DropSets", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DropSets
    {
      get { return _DropSets; }
      set { _DropSets = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}