﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_GListWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.GList), typeof(FairyGUI.GComponent));
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("GetFromPool", GetFromPool);
		L.RegFunction("AddItemFromPool", AddItemFromPool);
		L.RegFunction("AddChildAt", AddChildAt);
		L.RegFunction("RemoveChildAt", RemoveChildAt);
		L.RegFunction("RemoveChildToPoolAt", RemoveChildToPoolAt);
		L.RegFunction("RemoveChildToPool", RemoveChildToPool);
		L.RegFunction("RemoveChildrenToPool", RemoveChildrenToPool);
		L.RegFunction("GetSelection", GetSelection);
		L.RegFunction("AddSelection", AddSelection);
		L.RegFunction("RemoveSelection", RemoveSelection);
		L.RegFunction("ClearSelection", ClearSelection);
		L.RegFunction("SelectAll", SelectAll);
		L.RegFunction("SelectNone", SelectNone);
		L.RegFunction("SelectReverse", SelectReverse);
		L.RegFunction("HandleArrowKey", HandleArrowKey);
		L.RegFunction("ResizeToFit", ResizeToFit);
		L.RegFunction("HandleControllerChanged", HandleControllerChanged);
		L.RegFunction("ScrollToView", ScrollToView);
		L.RegFunction("GetFirstChildInView", GetFirstChildInView);
		L.RegFunction("ChildIndexToItemIndex", ChildIndexToItemIndex);
		L.RegFunction("ItemIndexToChildIndex", ItemIndexToChildIndex);
		L.RegFunction("SetVirtual", SetVirtual);
		L.RegFunction("SetVirtualAndLoop", SetVirtualAndLoop);
		L.RegFunction("RefreshVirtualList", RefreshVirtualList);
		L.RegFunction("Setup_BeforeAdd", Setup_BeforeAdd);
		L.RegFunction("Setup_AfterAdd", Setup_AfterAdd);
		L.RegFunction("New", _CreateFairyGUI_GList);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("defaultItem", get_defaultItem, set_defaultItem);
		L.RegVar("foldInvisibleItems", get_foldInvisibleItems, set_foldInvisibleItems);
		L.RegVar("selectionMode", get_selectionMode, set_selectionMode);
		L.RegVar("itemRenderer", get_itemRenderer, set_itemRenderer);
		L.RegVar("itemProvider", get_itemProvider, set_itemProvider);
		L.RegVar("scrollItemToViewOnClick", get_scrollItemToViewOnClick, set_scrollItemToViewOnClick);
		L.RegVar("onClickItem", get_onClickItem, null);
		L.RegVar("onRightClickItem", get_onRightClickItem, null);
		L.RegVar("layout", get_layout, set_layout);
		L.RegVar("lineCount", get_lineCount, set_lineCount);
		L.RegVar("columnCount", get_columnCount, set_columnCount);
		L.RegVar("lineGap", get_lineGap, set_lineGap);
		L.RegVar("columnGap", get_columnGap, set_columnGap);
		L.RegVar("align", get_align, set_align);
		L.RegVar("verticalAlign", get_verticalAlign, set_verticalAlign);
		L.RegVar("autoResizeItem", get_autoResizeItem, set_autoResizeItem);
		L.RegVar("itemPool", get_itemPool, null);
		L.RegVar("selectedIndex", get_selectedIndex, set_selectedIndex);
		L.RegVar("selectionController", get_selectionController, set_selectionController);
		L.RegVar("touchItem", get_touchItem, null);
		L.RegVar("isVirtual", get_isVirtual, null);
		L.RegVar("numItems", get_numItems, set_numItems);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_GList(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.GList obj = new FairyGUI.GList();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.GList.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFromPool(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.GObject o = obj.GetFromPool(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddItemFromPool(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				FairyGUI.GObject o = obj.AddItemFromPool();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				FairyGUI.GObject o = obj.AddItemFromPool(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GList.AddItemFromPool");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddChildAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject<FairyGUI.GObject>(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			FairyGUI.GObject o = obj.AddChildAt(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChildAt(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				FairyGUI.GObject o = obj.RemoveChildAt(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				FairyGUI.GObject o = obj.RemoveChildAt(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GList.RemoveChildAt");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChildToPoolAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.RemoveChildToPoolAt(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChildToPool(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject<FairyGUI.GObject>(L, 2);
			obj.RemoveChildToPool(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChildrenToPool(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				obj.RemoveChildrenToPool();
				return 0;
			}
			else if (count == 3)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				obj.RemoveChildrenToPool(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GList.RemoveChildrenToPool");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSelection(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			System.Collections.Generic.List<int> o = obj.GetSelection();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddSelection(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.AddSelection(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveSelection(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.RemoveSelection(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearSelection(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			obj.ClearSelection();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SelectAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			obj.SelectAll();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SelectNone(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			obj.SelectNone();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SelectReverse(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			obj.SelectReverse();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HandleArrowKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.HandleArrowKey(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResizeToFit(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				obj.ResizeToFit(arg0);
				return 0;
			}
			else if (count == 3)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				obj.ResizeToFit(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GList.ResizeToFit");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HandleControllerChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			FairyGUI.Controller arg0 = (FairyGUI.Controller)ToLua.CheckObject<FairyGUI.Controller>(L, 2);
			obj.HandleControllerChanged(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScrollToView(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				obj.ScrollToView(arg0);
				return 0;
			}
			else if (count == 3)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.ScrollToView(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				obj.ScrollToView(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GList.ScrollToView");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFirstChildInView(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			int o = obj.GetFirstChildInView();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChildIndexToItemIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = obj.ChildIndexToItemIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ItemIndexToChildIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = obj.ItemIndexToChildIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetVirtual(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			obj.SetVirtual();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetVirtualAndLoop(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			obj.SetVirtualAndLoop();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshVirtualList(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			obj.RefreshVirtualList();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Setup_BeforeAdd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			FairyGUI.Utils.XML arg0 = (FairyGUI.Utils.XML)ToLua.CheckObject<FairyGUI.Utils.XML>(L, 2);
			obj.Setup_BeforeAdd(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Setup_AfterAdd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GList obj = (FairyGUI.GList)ToLua.CheckObject<FairyGUI.GList>(L, 1);
			FairyGUI.Utils.XML arg0 = (FairyGUI.Utils.XML)ToLua.CheckObject<FairyGUI.Utils.XML>(L, 2);
			obj.Setup_AfterAdd(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			string ret = obj.defaultItem;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index defaultItem on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_foldInvisibleItems(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			bool ret = obj.foldInvisibleItems;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index foldInvisibleItems on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_selectionMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.ListSelectionMode ret = obj.selectionMode;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index selectionMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemRenderer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.ListItemRenderer ret = obj.itemRenderer;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemRenderer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemProvider(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.ListItemProvider ret = obj.itemProvider;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemProvider on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scrollItemToViewOnClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			bool ret = obj.scrollItemToViewOnClick;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollItemToViewOnClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClickItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.EventListener ret = obj.onClickItem;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onClickItem on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onRightClickItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.EventListener ret = obj.onRightClickItem;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onRightClickItem on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.ListLayoutType ret = obj.layout;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index layout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lineCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int ret = obj.lineCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lineCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_columnCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int ret = obj.columnCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index columnCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lineGap(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int ret = obj.lineGap;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lineGap on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_columnGap(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int ret = obj.columnGap;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index columnGap on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_align(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.AlignType ret = obj.align;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index align on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_verticalAlign(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.VertAlignType ret = obj.verticalAlign;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalAlign on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autoResizeItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			bool ret = obj.autoResizeItem;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoResizeItem on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemPool(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.GObjectPool ret = obj.itemPool;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemPool on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_selectedIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int ret = obj.selectedIndex;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index selectedIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_selectionController(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.Controller ret = obj.selectionController;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index selectionController on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_touchItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.GObject ret = obj.touchItem;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index touchItem on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isVirtual(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			bool ret = obj.isVirtual;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isVirtual on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_numItems(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int ret = obj.numItems;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index numItems on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.defaultItem = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index defaultItem on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_foldInvisibleItems(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.foldInvisibleItems = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index foldInvisibleItems on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_selectionMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.ListSelectionMode arg0 = (FairyGUI.ListSelectionMode)ToLua.CheckObject(L, 2, typeof(FairyGUI.ListSelectionMode));
			obj.selectionMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index selectionMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemRenderer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.ListItemRenderer arg0 = (FairyGUI.ListItemRenderer)ToLua.CheckDelegate<FairyGUI.ListItemRenderer>(L, 2);
			obj.itemRenderer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemRenderer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_itemProvider(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.ListItemProvider arg0 = (FairyGUI.ListItemProvider)ToLua.CheckDelegate<FairyGUI.ListItemProvider>(L, 2);
			obj.itemProvider = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemProvider on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scrollItemToViewOnClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.scrollItemToViewOnClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scrollItemToViewOnClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_layout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.ListLayoutType arg0 = (FairyGUI.ListLayoutType)ToLua.CheckObject(L, 2, typeof(FairyGUI.ListLayoutType));
			obj.layout = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index layout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lineCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.lineCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lineCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_columnCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.columnCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index columnCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lineGap(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.lineGap = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lineGap on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_columnGap(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.columnGap = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index columnGap on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_align(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.AlignType arg0 = (FairyGUI.AlignType)ToLua.CheckObject(L, 2, typeof(FairyGUI.AlignType));
			obj.align = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index align on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_verticalAlign(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.VertAlignType arg0 = (FairyGUI.VertAlignType)ToLua.CheckObject(L, 2, typeof(FairyGUI.VertAlignType));
			obj.verticalAlign = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index verticalAlign on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autoResizeItem(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.autoResizeItem = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index autoResizeItem on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_selectedIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.selectedIndex = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index selectedIndex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_selectionController(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			FairyGUI.Controller arg0 = (FairyGUI.Controller)ToLua.CheckObject<FairyGUI.Controller>(L, 2);
			obj.selectionController = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index selectionController on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_numItems(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GList obj = (FairyGUI.GList)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.numItems = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index numItems on a nil value");
		}
	}
}

