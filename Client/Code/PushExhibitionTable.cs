//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PushExhibitionTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PushExhibitionTable")]
  public partial class PushExhibitionTable : global::ProtoBuf.IExtensible
  {
    public PushExhibitionTable() {}
    
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
    private int _FinishLevel;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"FinishLevel", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int FinishLevel
    {
      get { return _FinishLevel; }
      set { _FinishLevel = value; }
    }
    private string _IconPath;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"IconPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string IconPath
    {
      get { return _IconPath; }
      set { _IconPath = value; }
    }
    private string _LinkInfo;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"LinkInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LinkInfo
    {
      get { return _LinkInfo; }
      set { _LinkInfo = value; }
    }
    private int _StartTime;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"StartTime", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int StartTime
    {
      get { return _StartTime; }
      set { _StartTime = value; }
    }
    private int _EndTime;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"EndTime", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int EndTime
    {
      get { return _EndTime; }
      set { _EndTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}