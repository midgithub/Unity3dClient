//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MechanismTable.proto
// Note: requires additional types generated from: Union.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MechanismTable")]
  public partial class MechanismTable : global::ProtoBuf.IExtensible
  {
    public MechanismTable() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Description;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Description
    {
      get { return _Description; }
      set { _Description = value; }
    }
    private int _Index;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Index", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Index
    {
      get { return _Index; }
      set { _Index = value; }
    }
    private string _DescriptionA;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"DescriptionA", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DescriptionA
    {
      get { return _DescriptionA; }
      set { _DescriptionA = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoTable.UnionCell> _ValueA = new global::System.Collections.Generic.List<ProtoTable.UnionCell>();
    [global::ProtoBuf.ProtoMember(5, Name=@"ValueA", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoTable.UnionCell> ValueA
    {
      get { return _ValueA; }
    }
  
    private string _DescriptionB;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"DescriptionB", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DescriptionB
    {
      get { return _DescriptionB; }
      set { _DescriptionB = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoTable.UnionCell> _ValueB = new global::System.Collections.Generic.List<ProtoTable.UnionCell>();
    [global::ProtoBuf.ProtoMember(7, Name=@"ValueB", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoTable.UnionCell> ValueB
    {
      get { return _ValueB; }
    }
  
    private string _DescriptionC;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"DescriptionC", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DescriptionC
    {
      get { return _DescriptionC; }
      set { _DescriptionC = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoTable.UnionCell> _ValueC = new global::System.Collections.Generic.List<ProtoTable.UnionCell>();
    [global::ProtoBuf.ProtoMember(9, Name=@"ValueC", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoTable.UnionCell> ValueC
    {
      get { return _ValueC; }
    }
  
    private string _DescriptionD;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"DescriptionD", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DescriptionD
    {
      get { return _DescriptionD; }
      set { _DescriptionD = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoTable.UnionCell> _ValueD = new global::System.Collections.Generic.List<ProtoTable.UnionCell>();
    [global::ProtoBuf.ProtoMember(11, Name=@"ValueD", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoTable.UnionCell> ValueD
    {
      get { return _ValueD; }
    }
  
    private string _DescriptionE;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"DescriptionE", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DescriptionE
    {
      get { return _DescriptionE; }
      set { _DescriptionE = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoTable.UnionCell> _ValueE = new global::System.Collections.Generic.List<ProtoTable.UnionCell>();
    [global::ProtoBuf.ProtoMember(13, Name=@"ValueE", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoTable.UnionCell> ValueE
    {
      get { return _ValueE; }
    }
  
    private string _DescriptionF;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"DescriptionF", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DescriptionF
    {
      get { return _DescriptionF; }
      set { _DescriptionF = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoTable.UnionCell> _ValueF = new global::System.Collections.Generic.List<ProtoTable.UnionCell>();
    [global::ProtoBuf.ProtoMember(15, Name=@"ValueF", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoTable.UnionCell> ValueF
    {
      get { return _ValueF; }
    }
  
    private string _DescriptionG;
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"DescriptionG", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DescriptionG
    {
      get { return _DescriptionG; }
      set { _DescriptionG = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoTable.UnionCell> _ValueG = new global::System.Collections.Generic.List<ProtoTable.UnionCell>();
    [global::ProtoBuf.ProtoMember(17, Name=@"ValueG", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoTable.UnionCell> ValueG
    {
      get { return _ValueG; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}