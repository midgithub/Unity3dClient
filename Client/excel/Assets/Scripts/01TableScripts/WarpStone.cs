//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: WarpStone.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WarpStone")]
  public partial class WarpStone : global::ProtoBuf.IExtensible
  {
    public WarpStone() {}
    
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
    private ProtoTable.WarpStone.eType _Type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.WarpStone.eType Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private int _CorrespondingLocation;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"CorrespondingLocation", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int CorrespondingLocation
    {
      get { return _CorrespondingLocation; }
      set { _CorrespondingLocation = value; }
    }
    private int _LevelLimit;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"LevelLimit", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int LevelLimit
    {
      get { return _LevelLimit; }
      set { _LevelLimit = value; }
    }
    private int _GoldCost;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"GoldCost", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int GoldCost
    {
      get { return _GoldCost; }
      set { _GoldCost = value; }
    }
    private int _IsUnlock;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"IsUnlock", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int IsUnlock
    {
      get { return _IsUnlock; }
      set { _IsUnlock = value; }
    }
    private int _BufferID;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"BufferID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BufferID
    {
      get { return _BufferID; }
      set { _BufferID = value; }
    }
    private string _PropA;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"PropA", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PropA
    {
      get { return _PropA; }
      set { _PropA = value; }
    }
    private string _PropAname;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"PropAname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PropAname
    {
      get { return _PropAname; }
      set { _PropAname = value; }
    }
    private string _PropB;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"PropB", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PropB
    {
      get { return _PropB; }
      set { _PropB = value; }
    }
    private string _PropBname;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"PropBname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string PropBname
    {
      get { return _PropBname; }
      set { _PropBname = value; }
    }
    private string _Icon;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon
    {
      get { return _Icon; }
      set { _Icon = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"eType")]
    public enum eType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"RED", Value=1)]
      RED = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GREEN", Value=2)]
      GREEN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"YELLOW", Value=3)]
      YELLOW = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BLUE", Value=4)]
      BLUE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BLACK", Value=5)]
      BLACK = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}