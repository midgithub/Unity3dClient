//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: GuildRoundtableTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuildRoundtableTable")]
  public partial class GuildRoundtableTable : global::ProtoBuf.IExtensible
  {
    public GuildRoundtableTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private ProtoTable.GuildRoundtableTable.eType _Type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.GuildRoundtableTable.eType Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private int _TimesLimit;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"TimesLimit", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int TimesLimit
    {
      get { return _TimesLimit; }
      set { _TimesLimit = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _GetItems = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(4, Name=@"GetItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> GetItems
    {
      get { return _GetItems; }
    }
  
    private int _MailContentID;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"MailContentID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int MailContentID
    {
      get { return _MailContentID; }
      set { _MailContentID = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"eType")]
    public enum eType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"First", Value=0)]
      First = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Help", Value=1)]
      Help = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FreeHelp", Value=2)]
      FreeHelp = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}