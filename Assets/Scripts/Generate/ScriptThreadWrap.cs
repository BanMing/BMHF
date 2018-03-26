﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ScriptThreadWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ScriptThread), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("CreateInstance", CreateInstance);
		L.RegFunction("Start", Start);
		L.RegFunction("StopAll", StopAll);
		L.RegFunction("Stop", Stop);
		L.RegFunction("DoAction", DoAction);
		L.RegFunction("DoActionInNextFrame", DoActionInNextFrame);
		L.RegFunction("DoActionEverySecond", DoActionEverySecond);
		L.RegFunction("RepeatDoAction", RepeatDoAction);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateInstance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			ScriptThread o = ScriptThread.CreateInstance();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Start(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.IEnumerator arg0 = (System.Collections.IEnumerator)ToLua.CheckObject(L, 1, typeof(System.Collections.IEnumerator));
			UnityEngine.Coroutine o = ScriptThread.Start(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			ScriptThread.StopAll();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.IEnumerator arg0 = (System.Collections.IEnumerator)ToLua.CheckObject(L, 1, typeof(System.Collections.IEnumerator));
			ScriptThread.Stop(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoAction(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Action arg0 = null;
			LuaTypes funcType1 = LuaDLL.lua_type(L, 1);

			if (funcType1 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (System.Action)ToLua.CheckObject(L, 1, typeof(System.Action));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 1);
				arg0 = DelegateFactory.CreateDelegate(typeof(System.Action), func) as System.Action;
			}

			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			ScriptThread.DoAction(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoActionInNextFrame(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Action arg0 = null;
			LuaTypes funcType1 = LuaDLL.lua_type(L, 1);

			if (funcType1 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (System.Action)ToLua.CheckObject(L, 1, typeof(System.Action));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 1);
				arg0 = DelegateFactory.CreateDelegate(typeof(System.Action), func) as System.Action;
			}

			ScriptThread.DoActionInNextFrame(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoActionEverySecond(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Func<bool> arg0 = null;
			LuaTypes funcType1 = LuaDLL.lua_type(L, 1);

			if (funcType1 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (System.Func<bool>)ToLua.CheckObject(L, 1, typeof(System.Func<bool>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 1);
				arg0 = DelegateFactory.CreateDelegate(typeof(System.Func<bool>), func) as System.Func<bool>;
			}

			ScriptThread.DoActionEverySecond(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RepeatDoAction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Action), typeof(float)))
			{
				System.Action arg0 = null;
				LuaTypes funcType1 = LuaDLL.lua_type(L, 1);

				if (funcType1 != LuaTypes.LUA_TFUNCTION)
				{
					 arg0 = (System.Action)ToLua.ToObject(L, 1);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 1);
					arg0 = DelegateFactory.CreateDelegate(typeof(System.Action), func) as System.Action;
				}

				float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
				ScriptThread.RepeatDoAction(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Func<bool>), typeof(float)))
			{
				System.Func<bool> arg0 = null;
				LuaTypes funcType1 = LuaDLL.lua_type(L, 1);

				if (funcType1 != LuaTypes.LUA_TFUNCTION)
				{
					 arg0 = (System.Func<bool>)ToLua.ToObject(L, 1);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 1);
					arg0 = DelegateFactory.CreateDelegate(typeof(System.Func<bool>), func) as System.Func<bool>;
				}

				float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
				ScriptThread.RepeatDoAction(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: ScriptThread.RepeatDoAction");
			}
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

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, ScriptThread.Instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

