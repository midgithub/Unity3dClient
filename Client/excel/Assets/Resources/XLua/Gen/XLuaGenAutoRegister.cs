﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(FileUtil), FileUtilWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Common.DESEncrypt), CommonDESEncryptWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NetWork.HttpRequestError), NetWorkHttpRequestErrorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NetWork.HttpRequestStatus), NetWorkHttpRequestStatusWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NetWork.LocalHttpWebRequest), NetWorkLocalHttpWebRequestWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NetWork.HttpNet), NetWorkHttpNetWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NetWork.RecvEvent), NetWorkRecvEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(NetWork.NetSocket), NetWorkNetSocketWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.InvokeManager), GameClientInvokeManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.LocalSettingManager), GameClientLocalSettingManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.LogManager), GameClientLogManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.LuaEventManager), GameClientLuaEventManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.LuaSocketEventManager), GameClientLuaSocketEventManagerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.FrameTypeID), GameClientFrameTypeIDWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.ClientFrame), GameClientClientFrameWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.IFrame), GameClientIFrameWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.FrameLayer), GameClientFrameLayerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.FrameState), GameClientFrameStateWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.ComUIListBinderItems), GameClientComUIListBinderItemsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Scripts.UI.ComUIListScript), ScriptsUIComUIListScriptWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.MessageBoxFrame), GameClientMessageBoxFrameWrap.__Register);
				
				translator.DelayWrapLoader(typeof(LuaBehaviour), LuaBehaviourWrap.__Register);
				
				translator.DelayWrapLoader(typeof(GameClient.UIFrameLua), GameClientUIFrameLuaWrap.__Register);
				
				
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
