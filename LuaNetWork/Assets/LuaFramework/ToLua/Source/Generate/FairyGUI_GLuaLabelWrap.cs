﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_GLuaLabelWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.GLuaLabel), typeof(FairyGUI.GLabel));
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("New", _CreateFairyGUI_GLuaLabel);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_GLuaLabel(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.GLuaLabel obj = new FairyGUI.GLuaLabel();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.GLuaLabel.New");
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
			FairyGUI.GLuaLabel obj = (FairyGUI.GLuaLabel)ToLua.CheckObject<FairyGUI.GLuaLabel>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

