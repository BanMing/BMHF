﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_Xml_Linq_XContainerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Xml.Linq.XContainer), typeof(System.Xml.Linq.XNode));
		L.RegFunction("Add", Add);
		L.RegFunction("AddFirst", AddFirst);
		L.RegFunction("CreateWriter", CreateWriter);
		L.RegFunction("Nodes", Nodes);
		L.RegFunction("DescendantNodes", DescendantNodes);
		L.RegFunction("Descendants", Descendants);
		L.RegFunction("Elements", Elements);
		L.RegFunction("Element", Element);
		L.RegFunction("RemoveNodes", RemoveNodes);
		L.RegFunction("ReplaceNodes", ReplaceNodes);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("FirstNode", get_FirstNode, null);
		L.RegVar("LastNode", get_LastNode, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XContainer), typeof(object)))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				obj.Add(arg0);
				return 0;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
				obj.Add(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XContainer.Add");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddFirst(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XContainer), typeof(object)))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				obj.AddFirst(arg0);
				return 0;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
				obj.AddFirst(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XContainer.AddFirst");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateWriter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XContainer));
			System.Xml.XmlWriter o = obj.CreateWriter();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Nodes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XContainer));
			System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> o = obj.Nodes();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DescendantNodes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XContainer));
			System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> o = obj.DescendantNodes();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Descendants(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XContainer)))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.Descendants();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XContainer), typeof(System.Xml.Linq.XName)))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				System.Xml.Linq.XName arg0 = (System.Xml.Linq.XName)ToLua.ToObject(L, 2);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.Descendants(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XContainer.Descendants");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Elements(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XContainer)))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.Elements();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XContainer), typeof(System.Xml.Linq.XName)))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				System.Xml.Linq.XName arg0 = (System.Xml.Linq.XName)ToLua.ToObject(L, 2);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.Elements(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XContainer.Elements");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Element(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XContainer));
			System.Xml.Linq.XName arg0 = (System.Xml.Linq.XName)ToLua.CheckObject(L, 2, typeof(System.Xml.Linq.XName));
			System.Xml.Linq.XElement o = obj.Element(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveNodes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XContainer));
			obj.RemoveNodes();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReplaceNodes(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XContainer), typeof(object)))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				obj.ReplaceNodes(arg0);
				return 0;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)ToLua.ToObject(L, 1);
				object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
				obj.ReplaceNodes(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XContainer.ReplaceNodes");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FirstNode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)o;
			System.Xml.Linq.XNode ret = obj.FirstNode;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index FirstNode on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LastNode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XContainer obj = (System.Xml.Linq.XContainer)o;
			System.Xml.Linq.XNode ret = obj.LastNode;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index LastNode on a nil value" : e.Message);
		}
	}
}
