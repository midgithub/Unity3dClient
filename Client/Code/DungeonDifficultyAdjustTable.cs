//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DungeonDifficultyAdjustTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonDifficultyAdjustTable")]
  public partial class DungeonDifficultyAdjustTable : global::ProtoBuf.IExtensible
  {
    public DungeonDifficultyAdjustTable() {}
    
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
    private int _PlayerNum;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"PlayerNum", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int PlayerNum
    {
      get { return _PlayerNum; }
      set { _PlayerNum = value; }
    }
    private int _MonsterHPFactor;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"MonsterHPFactor", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int MonsterHPFactor
    {
      get { return _MonsterHPFactor; }
      set { _MonsterHPFactor = value; }
    }
    private int _MonsterAttackFactor;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"MonsterAttackFactor", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int MonsterAttackFactor
    {
      get { return _MonsterAttackFactor; }
      set { _MonsterAttackFactor = value; }
    }
    private int _BossHPFactor;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"BossHPFactor", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BossHPFactor
    {
      get { return _BossHPFactor; }
      set { _BossHPFactor = value; }
    }
    private int _BossAttackFactor;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"BossAttackFactor", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BossAttackFactor
    {
      get { return _BossAttackFactor; }
      set { _BossAttackFactor = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}