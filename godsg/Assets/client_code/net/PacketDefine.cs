﻿

namespace P3Net
{
	//定义每种消息的个数
	public enum PacketNumber
	{
		//client ==> login
		PACKET_CL_NUMBER = 20,
		//login ==> client
		PACKET_LC_NUMBER = 20,

		//client ==> game server
		PACKET_CG_NUMBER = 2000,
		//game server ==> client
		PACKET_GC_NUMBER = 2000,
	}

	public enum PacketBegin
	{
		//client ==> login
		PACKET_CL_BEGIN = 101,
		//login ==> client
		PACKET_LC_BEGIN = PACKET_CL_BEGIN + PacketNumber.PACKET_CL_NUMBER,

		//client ==> game server
		PACKET_CG_BEGIN = PACKET_LC_BEGIN + PacketNumber.PACKET_LC_NUMBER,
		//game server ==> client
		PACKET_GC_BEGIN = PACKET_CG_BEGIN + PacketNumber.PACKET_CG_NUMBER,
	}

	public enum PacketClientGameNumber
	{
		//client ==> game
		PACKET_CG_LOGIN_NUMBER = 10, //角色登陆消息的起始id
		PACKET_CG_ACCOUNT_NUMBER = 10, //角色的账户信息
		PACKET_CG_HERO_NUMBER = 30, //角色的卡牌信息
		PACKET_CG_ITEM_NUMBER = 20, //角色的物品信息
		PACKET_CG_LEVEL_NUMBER = 20, //角色的关卡信息
		PACKET_CG_BATTLE_PVE_NUMBER = 20, //-- PVE的战斗信息
		PACKET_CG_MATRIX_NUMBER = 10, //阵法信息
		PACKET_CG_SHOP_NUMBER = 20, //商店信息
		PACKET_CG_LOTTERY_DRAW_NUMBER = 20, //抽卡信息
		PACKET_CG_MAIL_NUMBER = 20, //邮件信息
		PACKET_CG_CHAT_NUMBER = 10, //聊天信息
		PACKET_CG_FRIEND_NUMBER = 20, //好友信息
		PACKET_CG_CONVERT_NUMBER = 10,
		PACKET_CG_RANK_NUMBER		= 10,
		PACKET_CG_PVP_NUMBER	 = 20,
        PACKET_CG_MISSION_NUMBER = 10, //任务信息
		PACKET_CG_ATTENDANCE_NUMBER	= 10, // 签到
        PACKET_CG_TRIAL_NUMBER = 10, // 试炼 心魔
        PACKET_CG_SECT_NUMBER = 50, //宗派
		PACKET_CG_EIGHTY_NUMBER		= 20, // 八十一难
        PACKET_CG_CLIENT_NUMBER = 10, // 客户端

		//game ==> client
		PACKET_GC_LOGIN_NUMBER = 10, //login
		PACKET_GC_ACCOUNT_NUMBER = 10, //account
		PACKET_GC_HERO_NUMBER = 30, //hero
		PACKET_GC_ITEM_NUMBER = 20, //item
		PACKET_GC_LEVEL_NUMBER = 20, //关卡
		PACKET_GC_BATTLE_PVE_NUMBER = 20, //-- PVE的战斗信息
		PACKET_GC_MATRIX_NUMBER = 10, //阵法信息
		PACKET_GC_SHOP_NUMBER = 20, //商店信息
		PACKET_GC_LOTTERY_DRAW_NUMBER = 20, //抽卡信息
		PACKET_GC_MAIL_NUMBER = 20, //邮件信息
        PACKET_GC_CHAT_NUMBER = 10, //聊天信息
        PACKET_GC_FRIEND_NUMBER = 20, //好友信息
		PACKET_GC_CONVERT_NUMBER = 10,
		PACKET_GC_RANK_NUMBER	    = 10,
		PACKET_GC_PVP_NUMBER	 = 20,
        PACKET_GC_MISSION_NUMBER = 10, //任务信息
		PACKET_GC_ATTENDANCE_NUMBER	= 10, // 签到
        PACKET_GC_TRIAL_NUMBER = 10, // 试炼 心魔
        PACKET_GC_SECT_NUMBER = 50, //宗派
		PACKET_GC_EIGHTY_NUMBER		= 20, // 八十一难
        PACKET_GC_CLIENT_NUMBER = 10, // 客户端

	}

	public enum PacketClientGameBegin
	{
		//client ==> game
		PACKET_CG_LOGIN_BEGIN = PacketBegin.PACKET_CG_BEGIN,//login
		PACKET_CG_ACCOUNT_BEGIN = PACKET_CG_LOGIN_BEGIN + PacketClientGameNumber.PACKET_CG_LOGIN_NUMBER, //account
		PACKET_CG_HERO_BEGIN = PACKET_CG_ACCOUNT_BEGIN + PacketClientGameNumber.PACKET_CG_ACCOUNT_NUMBER,//hero
		PACKET_CG_ITEM_BEGIN = PACKET_CG_HERO_BEGIN + PacketClientGameNumber.PACKET_CG_HERO_NUMBER, //item
		PACKET_CG_LEVEL_BEGIN = PACKET_CG_ITEM_BEGIN + PacketClientGameNumber.PACKET_CG_ITEM_NUMBER, //level
		PACKET_CG_BATTLE_PVE_BEGIN = PACKET_CG_LEVEL_BEGIN + PacketClientGameNumber.PACKET_CG_LEVEL_NUMBER,	//-- PVE的战斗信息
		PACKET_CG_MATRIX_BEGIN = PACKET_CG_BATTLE_PVE_BEGIN + PacketClientGameNumber.PACKET_CG_BATTLE_PVE_NUMBER,	//-- 阵法信息
		PACKET_CG_SHOP_BEGIN = PACKET_CG_MATRIX_BEGIN + PacketClientGameNumber.PACKET_CG_MATRIX_NUMBER,	//-- 商店信息
        PACKET_CG_LOTTERY_DRAW_BEGIN = PACKET_CG_SHOP_BEGIN + PacketClientGameNumber.PACKET_CG_SHOP_NUMBER,	//-- 商店信息
        PACKET_CG_MAIL_BEGIN = PACKET_CG_LOTTERY_DRAW_BEGIN + PacketClientGameNumber.PACKET_CG_LOTTERY_DRAW_NUMBER,	//-- 邮件信息
        PACKET_CG_CHAT_BEGIN = PACKET_CG_MAIL_BEGIN + PacketClientGameNumber.PACKET_CG_MAIL_NUMBER,	//-- 聊天信息
        PACKET_CG_FRIEND_BEGIN = PACKET_CG_CHAT_BEGIN + PacketClientGameNumber.PACKET_CG_CHAT_NUMBER,	//-- 好友信息
        PACKET_CG_CONVERT_BEGIN = PACKET_CG_FRIEND_BEGIN + PacketClientGameNumber.PACKET_CG_FRIEND_NUMBER, //兑换信息
		PACKET_CG_RANK_BEGIN = PACKET_CG_CONVERT_BEGIN + PacketClientGameNumber.PACKET_CG_CONVERT_NUMBER,
		PACKET_CG_PVP_BEGIN = PACKET_CG_RANK_BEGIN + PacketClientGameNumber.PACKET_CG_RANK_NUMBER,
        PACKET_CG_MISSION_BEGIN = PACKET_CG_PVP_BEGIN + PacketClientGameNumber.PACKET_CG_PVP_NUMBER, 
		PACKET_CG_ATTENDANCE_BEGIN	= PACKET_CG_MISSION_BEGIN + PacketClientGameNumber.PACKET_CG_MISSION_NUMBER, // 签到
		PACKET_CG_TRIAL_BEGIN = PACKET_CG_ATTENDANCE_BEGIN + PacketClientGameNumber.PACKET_CG_ATTENDANCE_NUMBER, // 试炼
		PACKET_CG_EIGHTY_BEGIN = PACKET_CG_TRIAL_BEGIN + PacketClientGameNumber.PACKET_CG_TRIAL_NUMBER,			// 八十一难
        PACKET_CG_SECT_BEGIN = PACKET_CG_EIGHTY_BEGIN + PacketClientGameNumber.PACKET_CG_EIGHTY_NUMBER,			// 宗派
        PACKET_CG_CLIENT_BEGIN = PACKET_CG_SECT_BEGIN + PacketClientGameNumber.PACKET_CG_SECT_NUMBER,			// 客户端配置

		//game ==> client
		PACKET_GC_LOGIN_BEGIN = PacketBegin.PACKET_GC_BEGIN,//login
		PACKET_GC_ACCOUNT_BEGIN = PACKET_GC_LOGIN_BEGIN + PacketClientGameNumber.PACKET_GC_LOGIN_NUMBER, //account
		PACKET_GC_HERO_BEGIN = PACKET_GC_ACCOUNT_BEGIN + PacketClientGameNumber.PACKET_GC_ACCOUNT_NUMBER,//hero
		PACKET_GC_ITEM_BEGIN = PACKET_GC_HERO_BEGIN + PacketClientGameNumber.PACKET_GC_HERO_NUMBER, //item
		PACKET_GC_LEVEL_BEGIN = PACKET_GC_ITEM_BEGIN + PacketClientGameNumber.PACKET_GC_LEVEL_NUMBER, //level
		PACKET_GC_BATTLE_PVE_BEGIN = PACKET_GC_LEVEL_BEGIN + PacketClientGameNumber.PACKET_GC_LEVEL_NUMBER, //-- PVE的战斗信息
		PACKET_GC_MATRIX_BEGIN = PACKET_GC_BATTLE_PVE_BEGIN + PacketClientGameNumber.PACKET_GC_BATTLE_PVE_NUMBER,	//-- 阵法信息
		PACKET_GC_SHOP_BEGIN = PACKET_GC_MATRIX_BEGIN + PacketClientGameNumber.PACKET_GC_MATRIX_NUMBER,	//-- 商店信息
        PACKET_GC_LOTTERY_DRAW_BEGIN = PACKET_GC_SHOP_BEGIN + PacketClientGameNumber.PACKET_GC_SHOP_NUMBER,	//-- 商店信息
        PACKET_GC_MAIL_BEGIN = PACKET_GC_LOTTERY_DRAW_BEGIN + PacketClientGameNumber.PACKET_GC_LOTTERY_DRAW_NUMBER,	//-- 邮件信息
        PACKET_GC_CHAT_BEGIN = PACKET_GC_MAIL_BEGIN + PacketClientGameNumber.PACKET_GC_MAIL_NUMBER,			//-- 聊天信息
        PACKET_GC_FRIEND_BEGIN = PACKET_GC_CHAT_BEGIN + PacketClientGameNumber.PACKET_GC_CHAT_NUMBER,	//-- 好友信息
        PACKET_GC_CONVERT_BEGIN = PACKET_GC_FRIEND_BEGIN + PacketClientGameNumber.PACKET_GC_FRIEND_NUMBER, //兑换信息
		PACKET_GC_RANK_BEGIN = PACKET_GC_CONVERT_BEGIN + PacketClientGameNumber.PACKET_GC_CONVERT_NUMBER,
		PACKET_GC_PVP_BEGIN = PACKET_GC_RANK_BEGIN + PacketClientGameNumber.PACKET_GC_RANK_NUMBER,
        PACKET_GC_MISSION_BEGIN = PACKET_GC_PVP_BEGIN + PacketClientGameNumber.PACKET_GC_PVP_NUMBER,  //任务
		PACKET_GC_ATTENDANCE_BEGIN	= PACKET_GC_MISSION_BEGIN + PacketClientGameNumber.PACKET_GC_MISSION_NUMBER, // 签到
		PACKET_GC_TRIAL_BEGIN = PACKET_GC_ATTENDANCE_BEGIN + PacketClientGameNumber.PACKET_GC_ATTENDANCE_NUMBER, // 试炼
		PACKET_GC_EIGHTY_BEGIN = PACKET_GC_TRIAL_BEGIN + PacketClientGameNumber.PACKET_GC_TRIAL_NUMBER,			// 八十一难
		PACKET_GC_SECT_BEGIN = PACKET_GC_EIGHTY_BEGIN + PacketClientGameNumber.PACKET_GC_EIGHTY_NUMBER,			// 宗派
        PACKET_GC_CLIENT_BEGIN = PACKET_GC_SECT_BEGIN + PacketClientGameNumber.PACKET_GC_SECT_NUMBER,			// 客户端配置
	}

	public enum PACKET_TYPE
	{
		PACKET_TYPE_NONE = 0,	//-- 消息空，默认值

		//client ==> login
		PACKET_CLLogin = PacketBegin.PACKET_CL_BEGIN + 0,       //-- 客户端请求登陆

		PACKET_CL_END,

		
	
        //Client
        GCClientInit = PacketClientGameBegin.PACKET_GC_CLIENT_BEGIN,

		PACKET_GC_END,

		PACKET_TYPE_NUM = PACKET_GC_END,
	}
}
