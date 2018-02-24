using System;
using System.Text;

namespace Protocol
{
	/// <summary>
	///  充值商城类型
	/// </summary>
	public enum ChargeMallType
	{
		/// <summary>
		///  充值商品
		/// </summary>
		Charge = 0,
		/// <summary>
		///  人民币礼包
		/// </summary>
		Packet = 1,
	}

	public enum ChargeGoodsTag
	{
		/// <summary>
		///  推荐
		/// </summary>
		Recommend = 1,
	}

	/// <summary>
	///  充值商品
	/// </summary>
	public class ChargeGoods : Protocol.IProtocolStream
	{
		/// <summary>
		///  商品ID
		/// </summary>
		public byte id;
		/// <summary>
		///  描述
		/// </summary>
		public string desc;
		/// <summary>
		///  标签（位组合）
		/// </summary>
		public UInt32 tags;
		/// <summary>
		///  充值金额
		/// </summary>
		public UInt16 money;
		/// <summary>
		///  获得的vip积分
		/// </summary>
		public UInt16 vipScore;
		/// <summary>
		///  道具ID
		/// </summary>
		public UInt32 itemId;
		/// <summary>
		///  道具数量
		/// </summary>
		public UInt16 num;
		/// <summary>
		///  首冲数量补偿
		/// </summary>
		public UInt16 firstAddNum;
		/// <summary>
		///  非首充数量补偿
		/// </summary>
		public UInt16 unfirstAddNum;
		/// <summary>
		///  是否是首充
		/// </summary>
		public byte isFirstCharge;
		/// <summary>
		///  icon
		/// </summary>
		public string icon;
		/// <summary>
		///  剩余天数
		/// </summary>
		public UInt32 remainDays;
		/// <summary>
		///  剩余次数
		/// </summary>
		public byte remainTimes;

		#region METHOD

			public void encode(byte[] buffer, ref int pos_)
			{
				BaseDLL.encode_int8(buffer, ref pos_, id);
				byte[] descBytes = StringHelper.StringToUTF8Bytes(desc);
				BaseDLL.encode_string(buffer, ref pos_, descBytes, (UInt16)(buffer.Length - pos_));
				BaseDLL.encode_uint32(buffer, ref pos_, tags);
				BaseDLL.encode_uint16(buffer, ref pos_, money);
				BaseDLL.encode_uint16(buffer, ref pos_, vipScore);
				BaseDLL.encode_uint32(buffer, ref pos_, itemId);
				BaseDLL.encode_uint16(buffer, ref pos_, num);
				BaseDLL.encode_uint16(buffer, ref pos_, firstAddNum);
				BaseDLL.encode_uint16(buffer, ref pos_, unfirstAddNum);
				BaseDLL.encode_int8(buffer, ref pos_, isFirstCharge);
				byte[] iconBytes = StringHelper.StringToUTF8Bytes(icon);
				BaseDLL.encode_string(buffer, ref pos_, iconBytes, (UInt16)(buffer.Length - pos_));
				BaseDLL.encode_uint32(buffer, ref pos_, remainDays);
				BaseDLL.encode_int8(buffer, ref pos_, remainTimes);
			}

			public void decode(byte[] buffer, ref int pos_)
			{
				BaseDLL.decode_int8(buffer, ref pos_, ref id);
				UInt16 descLen = 0;
				BaseDLL.decode_uint16(buffer, ref pos_, ref descLen);
				byte[] descBytes = new byte[descLen];
				for(int i = 0; i < descLen; i++)
				{
					BaseDLL.decode_int8(buffer, ref pos_, ref descBytes[i]);
				}
				desc = StringHelper.BytesToString(descBytes);
				BaseDLL.decode_uint32(buffer, ref pos_, ref tags);
				BaseDLL.decode_uint16(buffer, ref pos_, ref money);
				BaseDLL.decode_uint16(buffer, ref pos_, ref vipScore);
				BaseDLL.decode_uint32(buffer, ref pos_, ref itemId);
				BaseDLL.decode_uint16(buffer, ref pos_, ref num);
				BaseDLL.decode_uint16(buffer, ref pos_, ref firstAddNum);
				BaseDLL.decode_uint16(buffer, ref pos_, ref unfirstAddNum);
				BaseDLL.decode_int8(buffer, ref pos_, ref isFirstCharge);
				UInt16 iconLen = 0;
				BaseDLL.decode_uint16(buffer, ref pos_, ref iconLen);
				byte[] iconBytes = new byte[iconLen];
				for(int i = 0; i < iconLen; i++)
				{
					BaseDLL.decode_int8(buffer, ref pos_, ref iconBytes[i]);
				}
				icon = StringHelper.BytesToString(iconBytes);
				BaseDLL.decode_uint32(buffer, ref pos_, ref remainDays);
				BaseDLL.decode_int8(buffer, ref pos_, ref remainTimes);
			}
		#endregion

	}

	/// <summary>
	///  充值礼包
	/// </summary>
	public class ChargePacket : Protocol.IProtocolStream
	{
		/// <summary>
		///  商品ID
		/// </summary>
		public byte id;
		/// <summary>
		///  名字
		/// </summary>
		public string name;
		/// <summary>
		///  原价
		/// </summary>
		public UInt16 oldPrice;
		/// <summary>
		///  价格
		/// </summary>
		public UInt16 money;
		/// <summary>
		///  获得的vip积分
		/// </summary>
		public UInt16 vipScore;
		/// <summary>
		///  icon
		/// </summary>
		public string icon;
		/// <summary>
		///  开始时间
		/// </summary>
		public UInt32 startTime;
		/// <summary>
		///  结束时间
		/// </summary>
		public UInt32 endTime;
		/// <summary>
		///  当天剩余次数
		/// </summary>
		public UInt16 limitDailyNum;
		/// <summary>
		///  当天剩余次数
		/// </summary>
		public UInt16 limitTotalNum;
		/// <summary>
		///  礼包内容
		/// </summary>
		public ItemReward[] rewards = new ItemReward[0];

		#region METHOD

			public void encode(byte[] buffer, ref int pos_)
			{
				BaseDLL.encode_int8(buffer, ref pos_, id);
				byte[] nameBytes = StringHelper.StringToUTF8Bytes(name);
				BaseDLL.encode_string(buffer, ref pos_, nameBytes, (UInt16)(buffer.Length - pos_));
				BaseDLL.encode_uint16(buffer, ref pos_, oldPrice);
				BaseDLL.encode_uint16(buffer, ref pos_, money);
				BaseDLL.encode_uint16(buffer, ref pos_, vipScore);
				byte[] iconBytes = StringHelper.StringToUTF8Bytes(icon);
				BaseDLL.encode_string(buffer, ref pos_, iconBytes, (UInt16)(buffer.Length - pos_));
				BaseDLL.encode_uint32(buffer, ref pos_, startTime);
				BaseDLL.encode_uint32(buffer, ref pos_, endTime);
				BaseDLL.encode_uint16(buffer, ref pos_, limitDailyNum);
				BaseDLL.encode_uint16(buffer, ref pos_, limitTotalNum);
				BaseDLL.encode_uint16(buffer, ref pos_, (UInt16)rewards.Length);
				for(int i = 0; i < rewards.Length; i++)
				{
					rewards[i].encode(buffer, ref pos_);
				}
			}

			public void decode(byte[] buffer, ref int pos_)
			{
				BaseDLL.decode_int8(buffer, ref pos_, ref id);
				UInt16 nameLen = 0;
				BaseDLL.decode_uint16(buffer, ref pos_, ref nameLen);
				byte[] nameBytes = new byte[nameLen];
				for(int i = 0; i < nameLen; i++)
				{
					BaseDLL.decode_int8(buffer, ref pos_, ref nameBytes[i]);
				}
				name = StringHelper.BytesToString(nameBytes);
				BaseDLL.decode_uint16(buffer, ref pos_, ref oldPrice);
				BaseDLL.decode_uint16(buffer, ref pos_, ref money);
				BaseDLL.decode_uint16(buffer, ref pos_, ref vipScore);
				UInt16 iconLen = 0;
				BaseDLL.decode_uint16(buffer, ref pos_, ref iconLen);
				byte[] iconBytes = new byte[iconLen];
				for(int i = 0; i < iconLen; i++)
				{
					BaseDLL.decode_int8(buffer, ref pos_, ref iconBytes[i]);
				}
				icon = StringHelper.BytesToString(iconBytes);
				BaseDLL.decode_uint32(buffer, ref pos_, ref startTime);
				BaseDLL.decode_uint32(buffer, ref pos_, ref endTime);
				BaseDLL.decode_uint16(buffer, ref pos_, ref limitDailyNum);
				BaseDLL.decode_uint16(buffer, ref pos_, ref limitTotalNum);
				UInt16 rewardsCnt = 0;
				BaseDLL.decode_uint16(buffer, ref pos_, ref rewardsCnt);
				rewards = new ItemReward[rewardsCnt];
				for(int i = 0; i < rewards.Length; i++)
				{
					rewards[i] = new ItemReward();
					rewards[i].decode(buffer, ref pos_);
				}
			}
		#endregion

	}

	[Protocol]
	public class WorldBillingGoodsReq : Protocol.IProtocolStream, Protocol.IGetMsgID
	{
		public const UInt32 MsgID = 604007;

		#region METHOD
			public UInt32 GetMsgID()
			{
				return MsgID;
			}

			public void encode(byte[] buffer, ref int pos_)
			{
			}

			public void decode(byte[] buffer, ref int pos_)
			{
			}
		#endregion

	}

	[Protocol]
	public class WorldBillingGoodsRes : Protocol.IProtocolStream, Protocol.IGetMsgID
	{
		public const UInt32 MsgID = 604008;
		public ChargeGoods[] goods = new ChargeGoods[0];

		#region METHOD
			public UInt32 GetMsgID()
			{
				return MsgID;
			}

			public void encode(byte[] buffer, ref int pos_)
			{
				BaseDLL.encode_uint16(buffer, ref pos_, (UInt16)goods.Length);
				for(int i = 0; i < goods.Length; i++)
				{
					goods[i].encode(buffer, ref pos_);
				}
			}

			public void decode(byte[] buffer, ref int pos_)
			{
				UInt16 goodsCnt = 0;
				BaseDLL.decode_uint16(buffer, ref pos_, ref goodsCnt);
				goods = new ChargeGoods[goodsCnt];
				for(int i = 0; i < goods.Length; i++)
				{
					goods[i] = new ChargeGoods();
					goods[i].decode(buffer, ref pos_);
				}
			}
		#endregion

	}

	/// <summary>
	///  获取充值礼包商品
	/// </summary>
	[Protocol]
	public class WorldBillingChargePacketReq : Protocol.IProtocolStream, Protocol.IGetMsgID
	{
		public const UInt32 MsgID = 604009;

		#region METHOD
			public UInt32 GetMsgID()
			{
				return MsgID;
			}

			public void encode(byte[] buffer, ref int pos_)
			{
			}

			public void decode(byte[] buffer, ref int pos_)
			{
			}
		#endregion

	}

	/// <summary>
	///  返回充值礼包商品
	/// </summary>
	[Protocol]
	public class WorldBillingChargePacketRes : Protocol.IProtocolStream, Protocol.IGetMsgID
	{
		public const UInt32 MsgID = 604010;
		public ChargePacket[] goods = new ChargePacket[0];

		#region METHOD
			public UInt32 GetMsgID()
			{
				return MsgID;
			}

			public void encode(byte[] buffer, ref int pos_)
			{
				BaseDLL.encode_uint16(buffer, ref pos_, (UInt16)goods.Length);
				for(int i = 0; i < goods.Length; i++)
				{
					goods[i].encode(buffer, ref pos_);
				}
			}

			public void decode(byte[] buffer, ref int pos_)
			{
				UInt16 goodsCnt = 0;
				BaseDLL.decode_uint16(buffer, ref pos_, ref goodsCnt);
				goods = new ChargePacket[goodsCnt];
				for(int i = 0; i < goods.Length; i++)
				{
					goods[i] = new ChargePacket();
					goods[i].decode(buffer, ref pos_);
				}
			}
		#endregion

	}

	/// <summary>
	///  请求购买商品(这里只判断能不能买)
	/// </summary>
	[Protocol]
	public class WorldBillingChargeReq : Protocol.IProtocolStream, Protocol.IGetMsgID
	{
		public const UInt32 MsgID = 604011;
		/// <summary>
		///  商城类型
		/// </summary>
		public byte mallType;
		/// <summary>
		///  商品ID
		/// </summary>
		public UInt32 goodsId;

		#region METHOD
			public UInt32 GetMsgID()
			{
				return MsgID;
			}

			public void encode(byte[] buffer, ref int pos_)
			{
				BaseDLL.encode_int8(buffer, ref pos_, mallType);
				BaseDLL.encode_uint32(buffer, ref pos_, goodsId);
			}

			public void decode(byte[] buffer, ref int pos_)
			{
				BaseDLL.decode_int8(buffer, ref pos_, ref mallType);
				BaseDLL.decode_uint32(buffer, ref pos_, ref goodsId);
			}
		#endregion

	}

	/// <summary>
	///  返回能否购买商品
	/// </summary>
	[Protocol]
	public class WorldBillingChargeRes : Protocol.IProtocolStream, Protocol.IGetMsgID
	{
		public const UInt32 MsgID = 604012;
		/// <summary>
		///  结果
		/// </summary>
		public UInt32 result;

		#region METHOD
			public UInt32 GetMsgID()
			{
				return MsgID;
			}

			public void encode(byte[] buffer, ref int pos_)
			{
				BaseDLL.encode_uint32(buffer, ref pos_, result);
			}

			public void decode(byte[] buffer, ref int pos_)
			{
				BaseDLL.decode_uint32(buffer, ref pos_, ref result);
			}
		#endregion

	}

	/// <summary>
	///  通知客户端发货了
	/// </summary>
	[Protocol]
	public class SceneBillingSendGoodsNotify : Protocol.IProtocolStream, Protocol.IGetMsgID
	{
		public const UInt32 MsgID = 504003;

		#region METHOD
			public UInt32 GetMsgID()
			{
				return MsgID;
			}

			public void encode(byte[] buffer, ref int pos_)
			{
			}

			public void decode(byte[] buffer, ref int pos_)
			{
			}
		#endregion

	}

}
