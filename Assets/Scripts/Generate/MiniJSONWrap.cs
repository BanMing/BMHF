﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MiniJSONWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MiniJSON), typeof(System.Object));
		L.RegFunction("jsonDecode", jsonDecode);
		L.RegFunction("jsonEncode", jsonEncode);
		L.RegFunction("lastDecodeSuccessful", lastDecodeSuccessful);
		L.RegFunction("getLastErrorIndex", getLastErrorIndex);
		L.RegFunction("getLastErrorSnippet", getLastErrorSnippet);
		L.RegFunction("New", _CreateMiniJSON);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMiniJSON(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MiniJSON obj = new MiniJSON();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MiniJSON.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int jsonDecode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			object o = MiniJSON.jsonDecode(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int jsonEncode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			object arg0 = ToLua.ToVarObject(L, 1);
			string o = MiniJSON.jsonEncode(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int lastDecodeSuccessful(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			bool o = MiniJSON.lastDecodeSuccessful();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLastErrorIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			int o = MiniJSON.getLastErrorIndex();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int getLastErrorSnippet(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = MiniJSON.getLastErrorSnippet();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

