//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MissionScoreTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MissionScoreTable")]
  public partial class MissionScoreTable : global::ProtoBuf.IExtensible
  {
    public MissionScoreTable() {}
    
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
    private string _UnOpenedChestBoxIcon;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"UnOpenedChestBoxIcon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UnOpenedChestBoxIcon
    {
      get { return _UnOpenedChestBoxIcon; }
      set { _UnOpenedChestBoxIcon = value; }
    }
    private string _OpenedChestBoxIcon;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"OpenedChestBoxIcon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OpenedChestBoxIcon
    {
      get { return _OpenedChestBoxIcon; }
      set { _OpenedChestBoxIcon = value; }
    }
    private int _Score;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Score", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Score
    {
      get { return _Score; }
      set { _Score = value; }
    }
    private int _TotalScore;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"TotalScore", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int TotalScore
    {
      get { return _TotalScore; }
      set { _TotalScore = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _Awards = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(7, Name=@"Awards", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> Awards
    {
      get { return _Awards; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}