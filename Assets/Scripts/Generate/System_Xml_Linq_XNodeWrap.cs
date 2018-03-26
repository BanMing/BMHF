﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_Xml_Linq_XNodeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.Xml.Linq.XNode), typeof(System.Xml.Linq.XObject));
		L.RegFunction("CompareDocumentOrder", CompareDocumentOrder);
		L.RegFunction("DeepEquals", DeepEquals);
		L.RegFunction("ToString", ToString);
		L.RegFunction("AddAfterSelf", AddAfterSelf);
		L.RegFunction("AddBeforeSelf", AddBeforeSelf);
		L.RegFunction("ReadFrom", ReadFrom);
		L.RegFunction("Remove", Remove);
		L.RegFunction("WriteTo", WriteTo);
		L.RegFunction("Ancestors", Ancestors);
		L.RegFunction("CreateReader", CreateReader);
		L.RegFunction("ElementsAfterSelf", ElementsAfterSelf);
		L.RegFunction("ElementsBeforeSelf", ElementsBeforeSelf);
		L.RegFunction("IsAfter", IsAfter);
		L.RegFunction("IsBefore", IsBefore);
		L.RegFunction("NodesAfterSelf", NodesAfterSelf);
		L.RegFunction("NodesBeforeSelf", NodesBeforeSelf);
		L.RegFunction("ReplaceWith", ReplaceWith);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("DocumentOrderComparer", get_DocumentOrderComparer, null);
		L.RegVar("EqualityComparer", get_EqualityComparer, null);
		L.RegVar("PreviousNode", get_PreviousNode, null);
		L.RegVar("NextNode", get_NextNode, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareDocumentOrder(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Xml.Linq.XNode arg0 = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XNode));
			System.Xml.Linq.XNode arg1 = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 2, typeof(System.Xml.Linq.XNode));
			int o = System.Xml.Linq.XNode.CompareDocumentOrder(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DeepEquals(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Xml.Linq.XNode arg0 = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XNode));
			System.Xml.Linq.XNode arg1 = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 2, typeof(System.Xml.Linq.XNode));
			bool o = System.Xml.Linq.XNode.DeepEquals(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				string o = obj.ToString();
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode), typeof(System.Xml.Linq.SaveOptions)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				System.Xml.Linq.SaveOptions arg0 = (System.Xml.Linq.SaveOptions)ToLua.ToObject(L, 2);
				string o = obj.ToString(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XNode.ToString");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddAfterSelf(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode), typeof(object)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				obj.AddAfterSelf(arg0);
				return 0;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
				obj.AddAfterSelf(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XNode.AddAfterSelf");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddBeforeSelf(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode), typeof(object)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				obj.AddBeforeSelf(arg0);
				return 0;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
				obj.AddBeforeSelf(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XNode.AddBeforeSelf");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadFrom(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.XmlReader arg0 = (System.Xml.XmlReader)ToLua.CheckObject(L, 1, typeof(System.Xml.XmlReader));
			System.Xml.Linq.XNode o = System.Xml.Linq.XNode.ReadFrom(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Remove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XNode));
			obj.Remove();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteTo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XNode));
			System.Xml.XmlWriter arg0 = (System.Xml.XmlWriter)ToLua.CheckObject(L, 2, typeof(System.Xml.XmlWriter));
			obj.WriteTo(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Ancestors(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.Ancestors();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode), typeof(System.Xml.Linq.XName)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				System.Xml.Linq.XName arg0 = (System.Xml.Linq.XName)ToLua.ToObject(L, 2);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.Ancestors(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XNode.Ancestors");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateReader(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XNode));
			System.Xml.XmlReader o = obj.CreateReader();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ElementsAfterSelf(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.ElementsAfterSelf();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode), typeof(System.Xml.Linq.XName)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				System.Xml.Linq.XName arg0 = (System.Xml.Linq.XName)ToLua.ToObject(L, 2);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.ElementsAfterSelf(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XNode.ElementsAfterSelf");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ElementsBeforeSelf(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.ElementsBeforeSelf();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode), typeof(System.Xml.Linq.XName)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				System.Xml.Linq.XName arg0 = (System.Xml.Linq.XName)ToLua.ToObject(L, 2);
				System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> o = obj.ElementsBeforeSelf(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XNode.ElementsBeforeSelf");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsAfter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XNode));
			System.Xml.Linq.XNode arg0 = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 2, typeof(System.Xml.Linq.XNode));
			bool o = obj.IsAfter(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsBefore(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XNode));
			System.Xml.Linq.XNode arg0 = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 2, typeof(System.Xml.Linq.XNode));
			bool o = obj.IsBefore(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NodesAfterSelf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XNode));
			System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> o = obj.NodesAfterSelf();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NodesBeforeSelf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.CheckObject(L, 1, typeof(System.Xml.Linq.XNode));
			System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> o = obj.NodesBeforeSelf();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReplaceWith(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(System.Xml.Linq.XNode), typeof(object)))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				obj.ReplaceWith(arg0);
				return 0;
			}
			else if (TypeChecker.CheckParamsType(L, typeof(object), 2, count - 1))
			{
				System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)ToLua.ToObject(L, 1);
				object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
				obj.ReplaceWith(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.Xml.Linq.XNode.ReplaceWith");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DocumentOrderComparer(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, System.Xml.Linq.XNode.DocumentOrderComparer);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_EqualityComparer(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, System.Xml.Linq.XNode.EqualityComparer);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PreviousNode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)o;
			System.Xml.Linq.XNode ret = obj.PreviousNode;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index PreviousNode on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NextNode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.Xml.Linq.XNode obj = (System.Xml.Linq.XNode)o;
			System.Xml.Linq.XNode ret = obj.NextNode;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index NextNode on a nil value" : e.Message);
		}
	}
}

