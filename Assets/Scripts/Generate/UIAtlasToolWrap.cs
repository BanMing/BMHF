﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIAtlasToolWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIAtlasTool), typeof(SingletonMonoBehaviour<UIAtlasTool>));
		L.RegFunction("Init", Init);
		L.RegFunction("SaveConfig", SaveConfig);
		L.RegFunction("GetSpriteSync", GetSpriteSync);
		L.RegFunction("GetSprite", GetSprite);
		L.RegFunction("GetTextureSync", GetTextureSync);
		L.RegFunction("GetTexture", GetTexture);
		L.RegFunction("GetTextureRect", GetTextureRect);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIAtlasTool obj = (UIAtlasTool)ToLua.CheckObject(L, 1, typeof(UIAtlasTool));
			obj.Init();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SaveConfig(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UIAtlasTool.SaveConfig();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSpriteSync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UIAtlasTool obj = (UIAtlasTool)ToLua.CheckObject(L, 1, typeof(UIAtlasTool));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			System.Action<UnityEngine.Sprite> arg2 = null;
			LuaTypes funcType4 = LuaDLL.lua_type(L, 4);

			if (funcType4 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (System.Action<UnityEngine.Sprite>)ToLua.CheckObject(L, 4, typeof(System.Action<UnityEngine.Sprite>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 4);
				arg2 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Sprite>), func) as System.Action<UnityEngine.Sprite>;
			}

			UnityEngine.Sprite o = obj.GetSpriteSync(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSprite(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UIAtlasTool obj = (UIAtlasTool)ToLua.CheckObject(L, 1, typeof(UIAtlasTool));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			System.Action<UnityEngine.Sprite> arg2 = null;
			LuaTypes funcType4 = LuaDLL.lua_type(L, 4);

			if (funcType4 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (System.Action<UnityEngine.Sprite>)ToLua.CheckObject(L, 4, typeof(System.Action<UnityEngine.Sprite>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 4);
				arg2 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Sprite>), func) as System.Action<UnityEngine.Sprite>;
			}

			obj.GetSprite(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTextureSync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UIAtlasTool obj = (UIAtlasTool)ToLua.CheckObject(L, 1, typeof(UIAtlasTool));
			string arg0 = ToLua.CheckString(L, 2);
			System.Action<UnityEngine.Texture> arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (System.Action<UnityEngine.Texture>)ToLua.CheckObject(L, 3, typeof(System.Action<UnityEngine.Texture>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Texture>), func) as System.Action<UnityEngine.Texture>;
			}

			UnityEngine.Texture2D o = obj.GetTextureSync(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTexture(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UIAtlasTool obj = (UIAtlasTool)ToLua.CheckObject(L, 1, typeof(UIAtlasTool));
			string arg0 = ToLua.CheckString(L, 2);
			System.Action<UnityEngine.Texture> arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (System.Action<UnityEngine.Texture>)ToLua.CheckObject(L, 3, typeof(System.Action<UnityEngine.Texture>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(System.Action<UnityEngine.Texture>), func) as System.Action<UnityEngine.Texture>;
			}

			obj.GetTexture(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTextureRect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UIAtlasTool obj = (UIAtlasTool)ToLua.CheckObject(L, 1, typeof(UIAtlasTool));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			UnityEngine.Rect o = obj.GetTextureRect(arg0, arg1);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

