using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

public class StartLua : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LuaSvr svr = new LuaSvr();
		svr.init(null, () =>
		{
			svr.start("Lua_Bag/LuaScripts/StartLua");
		});
	}
	
}
