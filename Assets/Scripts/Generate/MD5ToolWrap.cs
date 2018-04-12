﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MD5ToolWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("MD5Tool");
		L.RegFunction("Get", Get);
		L.RegFunction("GetByFilePath", GetByFilePath);
		L.RegFunction("Verify", Verify);
		L.RegFunction("VerifyFile", VerifyFile);
		L.RegFunction("GetUpperMD5", GetUpperMD5);
		L.RegFunction("GetUpperMD5WithFormatOne", GetUpperMD5WithFormatOne);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Get(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.IO.Stream)))
			{
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.ToObject(L, 1);
				string o = MD5Tool.Get(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(byte[])))
			{
				byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
				string o = MD5Tool.Get(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string o = MD5Tool.Get(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: MD5Tool.Get");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetByFilePath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = MD5Tool.GetByFilePath(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Verify(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.IO.Stream), typeof(string)))
			{
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.ToObject(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				bool o = MD5Tool.Verify(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(byte[]), typeof(string)))
			{
				byte[] arg0 = ToLua.CheckByteBuffer(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				bool o = MD5Tool.Verify(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				bool o = MD5Tool.Verify(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: MD5Tool.Verify");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int VerifyFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			bool o = MD5Tool.VerifyFile(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUpperMD5(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = MD5Tool.GetUpperMD5(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUpperMD5WithFormatOne(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = MD5Tool.GetUpperMD5WithFormatOne(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
