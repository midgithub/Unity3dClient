//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ItemTable.proto
namespace ProtoTable
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemTable")]
  public partial class ItemTable : global::ProtoBuf.IExtensible
  {
    public ItemTable() {}
    
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
    private int _IdSequence;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"IdSequence", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int IdSequence
    {
      get { return _IdSequence; }
      set { _IdSequence = value; }
    }
    private ProtoTable.ItemTable.eType _Type;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemTable.eType Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private string _TypeName;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"TypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TypeName
    {
      get { return _TypeName; }
      set { _TypeName = value; }
    }
    private ProtoTable.ItemTable.eEPrompt _EPrompt;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"EPrompt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemTable.eEPrompt EPrompt
    {
      get { return _EPrompt; }
      set { _EPrompt = value; }
    }
    private ProtoTable.ItemTable.eSubType _SubType;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"SubType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemTable.eSubType SubType
    {
      get { return _SubType; }
      set { _SubType = value; }
    }
    private string _SubTypeName;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"SubTypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string SubTypeName
    {
      get { return _SubTypeName; }
      set { _SubTypeName = value; }
    }
    private ProtoTable.ItemTable.eThirdType _ThirdType;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"ThirdType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemTable.eThirdType ThirdType
    {
      get { return _ThirdType; }
      set { _ThirdType = value; }
    }
    private string _ThirdTypeName;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"ThirdTypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ThirdTypeName
    {
      get { return _ThirdTypeName; }
      set { _ThirdTypeName = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _Occu = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(11, Name=@"Occu", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> Occu
    {
      get { return _Occu; }
    }
  
    private ProtoTable.ItemTable.eColor _Color;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemTable.eColor Color
    {
      get { return _Color; }
      set { _Color = value; }
    }
    private int _NeedLevel;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"NeedLevel", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int NeedLevel
    {
      get { return _NeedLevel; }
      set { _NeedLevel = value; }
    }
    private int _BaseAttackSpeedRate;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"BaseAttackSpeedRate", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int BaseAttackSpeedRate
    {
      get { return _BaseAttackSpeedRate; }
      set { _BaseAttackSpeedRate = value; }
    }
    private ProtoTable.ItemTable.eCanUse _CanUse;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"CanUse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemTable.eCanUse CanUse
    {
      get { return _CanUse; }
      set { _CanUse = value; }
    }
    private bool _CanTrade;
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"CanTrade", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool CanTrade
    {
      get { return _CanTrade; }
      set { _CanTrade = value; }
    }
    private ProtoTable.ItemTable.eOwner _Owner;
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"Owner", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemTable.eOwner Owner
    {
      get { return _Owner; }
      set { _Owner = value; }
    }
    private bool _IsSeal;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"IsSeal", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsSeal
    {
      get { return _IsSeal; }
      set { _IsSeal = value; }
    }
    private int _SealMax;
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"SealMax", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int SealMax
    {
      get { return _SealMax; }
      set { _SealMax = value; }
    }
    private bool _IsDecompose;
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"IsDecompose", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsDecompose
    {
      get { return _IsDecompose; }
      set { _IsDecompose = value; }
    }
    private int _SellItemID;
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"SellItemID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int SellItemID
    {
      get { return _SellItemID; }
      set { _SellItemID = value; }
    }
    private int _Price;
    [global::ProtoBuf.ProtoMember(22, IsRequired = true, Name=@"Price", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Price
    {
      get { return _Price; }
      set { _Price = value; }
    }
    private int _CdGroup;
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"CdGroup", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int CdGroup
    {
      get { return _CdGroup; }
      set { _CdGroup = value; }
    }
    private int _CoolTime;
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"CoolTime", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int CoolTime
    {
      get { return _CoolTime; }
      set { _CoolTime = value; }
    }
    private int _TimeLeft;
    [global::ProtoBuf.ProtoMember(25, IsRequired = true, Name=@"TimeLeft", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int TimeLeft
    {
      get { return _TimeLeft; }
      set { _TimeLeft = value; }
    }
    private int _MaxNum;
    [global::ProtoBuf.ProtoMember(26, IsRequired = true, Name=@"MaxNum", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int MaxNum
    {
      get { return _MaxNum; }
      set { _MaxNum = value; }
    }
    private string _EffectDescription;
    [global::ProtoBuf.ProtoMember(27, IsRequired = true, Name=@"EffectDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string EffectDescription
    {
      get { return _EffectDescription; }
      set { _EffectDescription = value; }
    }
    private string _Description;
    [global::ProtoBuf.ProtoMember(28, IsRequired = true, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Description
    {
      get { return _Description; }
      set { _Description = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _ComeLink = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(29, Name=@"ComeLink", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> ComeLink
    {
      get { return _ComeLink; }
    }
  
    private readonly global::System.Collections.Generic.List<int> _RelationID = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(30, Name=@"RelationID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> RelationID
    {
      get { return _RelationID; }
    }
  
    private string _Icon;
    [global::ProtoBuf.ProtoMember(31, IsRequired = true, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Icon
    {
      get { return _Icon; }
      set { _Icon = value; }
    }
    private string _ModelPath;
    [global::ProtoBuf.ProtoMember(32, IsRequired = true, Name=@"ModelPath", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ModelPath
    {
      get { return _ModelPath; }
      set { _ModelPath = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _Path2 = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(33, Name=@"Path2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> Path2
    {
      get { return _Path2; }
    }
  
    private int _OnUseBuffId;
    [global::ProtoBuf.ProtoMember(34, IsRequired = true, Name=@"OnUseBuffId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int OnUseBuffId
    {
      get { return _OnUseBuffId; }
      set { _OnUseBuffId = value; }
    }
    private int _OnGetBuffId;
    [global::ProtoBuf.ProtoMember(35, IsRequired = true, Name=@"OnGetBuffId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int OnGetBuffId
    {
      get { return _OnGetBuffId; }
      set { _OnGetBuffId = value; }
    }
    private bool _CanDungeonUse;
    [global::ProtoBuf.ProtoMember(36, IsRequired = true, Name=@"CanDungeonUse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool CanDungeonUse
    {
      get { return _CanDungeonUse; }
      set { _CanDungeonUse = value; }
    }
    private int _RecommendPrice;
    [global::ProtoBuf.ProtoMember(37, IsRequired = true, Name=@"RecommendPrice", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int RecommendPrice
    {
      get { return _RecommendPrice; }
      set { _RecommendPrice = value; }
    }
    private ProtoTable.ItemTable.eComeType _ComeType;
    [global::ProtoBuf.ProtoMember(38, IsRequired = true, Name=@"ComeType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemTable.eComeType ComeType
    {
      get { return _ComeType; }
      set { _ComeType = value; }
    }
    private string _ComeDesc;
    [global::ProtoBuf.ProtoMember(39, IsRequired = true, Name=@"ComeDesc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ComeDesc
    {
      get { return _ComeDesc; }
      set { _ComeDesc = value; }
    }
    private int _ResID;
    [global::ProtoBuf.ProtoMember(40, IsRequired = true, Name=@"ResID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int ResID
    {
      get { return _ResID; }
      set { _ResID = value; }
    }
    private int _Tag;
    [global::ProtoBuf.ProtoMember(41, IsRequired = true, Name=@"Tag", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Tag
    {
      get { return _Tag; }
      set { _Tag = value; }
    }
    private int _SuitID;
    [global::ProtoBuf.ProtoMember(42, IsRequired = true, Name=@"SuitID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int SuitID
    {
      get { return _SuitID; }
      set { _SuitID = value; }
    }
    private int _EquipPropID;
    [global::ProtoBuf.ProtoMember(43, IsRequired = true, Name=@"EquipPropID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int EquipPropID
    {
      get { return _EquipPropID; }
      set { _EquipPropID = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _MutexBuff = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(44, Name=@"MutexBuff", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public global::System.Collections.Generic.List<int> MutexBuff
    {
      get { return _MutexBuff; }
    }
  
    private bool _CanAnnounce;
    [global::ProtoBuf.ProtoMember(45, IsRequired = true, Name=@"CanAnnounce", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool CanAnnounce
    {
      get { return _CanAnnounce; }
      set { _CanAnnounce = value; }
    }
    private string _LinkInfo;
    [global::ProtoBuf.ProtoMember(46, IsRequired = true, Name=@"LinkInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string LinkInfo
    {
      get { return _LinkInfo; }
      set { _LinkInfo = value; }
    }
    private int _bNeedJump;
    [global::ProtoBuf.ProtoMember(47, IsRequired = true, Name=@"bNeedJump", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int bNeedJump
    {
      get { return _bNeedJump; }
      set { _bNeedJump = value; }
    }
    private int _FunctionID;
    [global::ProtoBuf.ProtoMember(48, IsRequired = true, Name=@"FunctionID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int FunctionID
    {
      get { return _FunctionID; }
      set { _FunctionID = value; }
    }
    private ProtoTable.ItemTable.eUseLimiteType _UseLimiteType;
    [global::ProtoBuf.ProtoMember(49, IsRequired = true, Name=@"UseLimiteType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTable.ItemTable.eUseLimiteType UseLimiteType
    {
      get { return _UseLimiteType; }
      set { _UseLimiteType = value; }
    }
    private int _UseLimiteValue;
    [global::ProtoBuf.ProtoMember(50, IsRequired = true, Name=@"UseLimiteValue", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int UseLimiteValue
    {
      get { return _UseLimiteValue; }
      set { _UseLimiteValue = value; }
    }
    private int _Abandon;
    [global::ProtoBuf.ProtoMember(51, IsRequired = true, Name=@"Abandon", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Abandon
    {
      get { return _Abandon; }
      set { _Abandon = value; }
    }
    private int _PackageID;
    [global::ProtoBuf.ProtoMember(52, IsRequired = true, Name=@"PackageID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int PackageID
    {
      get { return _PackageID; }
      set { _PackageID = value; }
    }
    private int _OldTitle;
    [global::ProtoBuf.ProtoMember(53, IsRequired = true, Name=@"OldTitle", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int OldTitle
    {
      get { return _OldTitle; }
      set { _OldTitle = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"eType")]
    public enum eType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EQUIP", Value=1)]
      EQUIP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXPENDABLE", Value=2)]
      EXPENDABLE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATERIAL", Value=3)]
      MATERIAL = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TASK", Value=4)]
      TASK = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FASHION", Value=5)]
      FASHION = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"INCOME", Value=6)]
      INCOME = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ENERGY", Value=7)]
      ENERGY = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FUCKTITTLE", Value=8)]
      FUCKTITTLE = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"VirtualPack", Value=9)]
      VirtualPack = 9
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eEPrompt")]
    public enum eEPrompt
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EPT_NONE", Value=0)]
      EPT_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EPT_NEW_EQUIP", Value=1)]
      EPT_NEW_EQUIP = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EPT_RED_POINT", Value=2)]
      EPT_RED_POINT = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eSubType")]
    public enum eSubType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ST_NONE", Value=0)]
      ST_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WEAPON", Value=1)]
      WEAPON = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HEAD", Value=2)]
      HEAD = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHEST", Value=3)]
      CHEST = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BELT", Value=4)]
      BELT = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LEG", Value=5)]
      LEG = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOOT", Value=6)]
      BOOT = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RING", Value=7)]
      RING = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NECKLASE", Value=8)]
      NECKLASE = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BRACELET", Value=9)]
      BRACELET = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TITLE", Value=10)]
      TITLE = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FASHION_HAIR", Value=11)]
      FASHION_HAIR = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FASHION_HEAD", Value=12)]
      FASHION_HEAD = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FASHION_SASH", Value=13)]
      FASHION_SASH = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FASHION_CHEST", Value=14)]
      FASHION_CHEST = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FASHION_LEG", Value=15)]
      FASHION_LEG = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FASHION_EPAULET", Value=16)]
      FASHION_EPAULET = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GOLD", Value=17)]
      GOLD = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"POINT", Value=18)]
      POINT = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXP", Value=19)]
      EXP = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DRUG", Value=20)]
      DRUG = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WARRIOR_SOUL", Value=22)]
      WARRIOR_SOUL = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DUEL_COIN", Value=23)]
      DUEL_COIN = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MATERIAL_JINGPO", Value=24)]
      MATERIAL_JINGPO = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EnchantmentsCard", Value=25)]
      EnchantmentsCard = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ResurrectionCcurrency", Value=26)]
      ResurrectionCcurrency = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BindGOLD", Value=27)]
      BindGOLD = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BindPOINT", Value=28)]
      BindPOINT = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GiftPackage", Value=29)]
      GiftPackage = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GuildContri", Value=30)]
      GuildContri = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SP", Value=31)]
      SP = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EnergyStone", Value=32)]
      EnergyStone = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Coupon", Value=33)]
      Coupon = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MonthCard", Value=34)]
      MonthCard = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Jar", Value=35)]
      Jar = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GiftBox", Value=36)]
      GiftBox = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FatigueDrug", Value=37)]
      FatigueDrug = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Drawing", Value=38)]
      Drawing = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Fragment", Value=39)]
      Fragment = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"VipExp", Value=40)]
      VipExp = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ExperiencePill", Value=41)]
      ExperiencePill = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GoldJarPoint", Value=42)]
      GoldJarPoint = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MagicJarPoint", Value=43)]
      MagicJarPoint = 43
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eThirdType")]
    public enum eThirdType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"TT_NONE", Value=0)]
      TT_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HUGESWORD", Value=1)]
      HUGESWORD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"KATANA", Value=2)]
      KATANA = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SHORTSWORD", Value=3)]
      SHORTSWORD = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BEAMSWORD", Value=4)]
      BEAMSWORD = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BLUNT", Value=5)]
      BLUNT = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REVOLVER", Value=6)]
      REVOLVER = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CROSSBOW", Value=7)]
      CROSSBOW = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HANDCANNON", Value=8)]
      HANDCANNON = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RIFLE", Value=9)]
      RIFLE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PISTOL", Value=10)]
      PISTOL = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STAFF", Value=11)]
      STAFF = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WAND", Value=12)]
      WAND = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SPEAR", Value=13)]
      SPEAR = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"STICK", Value=14)]
      STICK = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CLOTH", Value=51)]
      CLOTH = 51,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SKIN", Value=52)]
      SKIN = 52,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LIGHT", Value=53)]
      LIGHT = 53,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HEAVY", Value=54)]
      HEAVY = 54,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLATE", Value=55)]
      PLATE = 55,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SmallFatigueDrug", Value=300)]
      SmallFatigueDrug = 300,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MiddleFatigueDrug", Value=301)]
      MiddleFatigueDrug = 301,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BigFatigueDrug", Value=302)]
      BigFatigueDrug = 302
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eColor")]
    public enum eColor
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CL_NONE", Value=0)]
      CL_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"WHITE", Value=1)]
      WHITE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BLUE", Value=2)]
      BLUE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PURPLE", Value=3)]
      PURPLE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GREEN", Value=4)]
      GREEN = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PINK", Value=5)]
      PINK = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"YELLOW", Value=6)]
      YELLOW = 6
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eCanUse")]
    public enum eCanUse
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CanNot", Value=0)]
      CanNot = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UseOne", Value=1)]
      UseOne = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UseTotal", Value=2)]
      UseTotal = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eOwner")]
    public enum eOwner
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NOTBIND", Value=1)]
      NOTBIND = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ROLEBIND", Value=2)]
      ROLEBIND = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACCBIND", Value=3)]
      ACCBIND = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eComeType")]
    public enum eComeType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CT_SHOP", Value=0)]
      CT_SHOP = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CT_MISSION", Value=1)]
      CT_MISSION = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CT_ACTIVITY", Value=2)]
      CT_ACTIVITY = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"eUseLimiteType")]
    public enum eUseLimiteType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NOLIMITE", Value=0)]
      NOLIMITE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DAYLIMITE", Value=1)]
      DAYLIMITE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"VIPLIMITE", Value=2)]
      VIPLIMITE = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}