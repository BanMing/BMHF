﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class EventServerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(EventServer), typeof(System.Object));
		L.RegFunction("Register", _Register);
		L.RegFunction("UnRegister", UnRegister);
		L.RegFunction("Fire", Fire);
		L.RegFunction("Clear", Clear);
		L.RegFunction("New", _CreateEventServer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateEventServer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				EventServer obj = new EventServer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: EventServer.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _Register(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			EventServer obj = (EventServer)ToLua.CheckObject(L, 1, typeof(EventServer));
			string arg0 = ToLua.CheckString(L, 2);
			EventCallback arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (EventCallback)ToLua.CheckObject(L, 3, typeof(EventCallback));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(EventCallback), func) as EventCallback;
			}

			obj.Register(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnRegister(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			EventServer obj = (EventServer)ToLua.CheckObject(L, 1, typeof(EventServer));
			string arg0 = ToLua.CheckString(L, 2);
			EventCallback arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (EventCallback)ToLua.CheckObject(L, 3, typeof(EventCallback));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(EventCallback), func) as EventCallback;
			}

			obj.UnRegister(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Fire(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			EventServer obj = (EventServer)ToLua.CheckObject(L, 1, typeof(EventServer));
			string arg0 = ToLua.CheckString(L, 2);
			object arg1 = ToLua.ToVarObject(L, 3);
			obj.Fire(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			EventServer obj = (EventServer)ToLua.CheckObject(L, 1, typeof(EventServer));
			obj.Clear();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
