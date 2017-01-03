using UnityEngine;
using System.Collections;
using UnityEditor;

using System.Linq;

namespace Fugu.Editor {


public class FuguGamesMenu {

		// make PlayerSettings extension?
		static public void AddScriptingDefineSymbolsForGroup(BuildTargetGroup targetGroup, string defines) {
			string defs = PlayerSettings.GetScriptingDefineSymbolsForGroup(targetGroup);
			defines += ";"+defs;
			PlayerSettings.SetScriptingDefineSymbolsForGroup(targetGroup,defines);
		}

		static public void SetBuildPath(BuildTarget target, string name) {
			string path = Application.dataPath;
			path = path.Substring(0, path.LastIndexOf("Assets"));
			EditorUserBuildSettings.SetBuildLocation(target,path+"/"+name);
		}

		//  iOS
		static public void TargetiOS(string file) {
			TargetiOS();
			SetBuildPath(BuildTarget.iOS,file);
		}
		
		
		static public void TargetiOS() {
			PlayerSettings.use32BitDisplayBuffer = true;
			EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iOS);
		}

		// tvOS

		static public void TargetTV(string file) {
			TargetTV();
			SetBuildPath(BuildTarget.tvOS,file);
		}


		static public void TargetTV() {
			PlayerSettings.use32BitDisplayBuffer = true;
			EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.tvOS);
		}

		// android

		static public void TargetAndroidGeneric(string file) {
			TargetAndroidGeneric();
			SetBuildPath(BuildTarget.Android,file);
		}

		static public void TargetAndroidGeneric() {
			PlayerSettings.use32BitDisplayBuffer = true; // false;
			EditorUserBuildSettings.androidBuildSubtarget = MobileTextureSubtarget.Generic;
			EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
		}

[MenuItem ("FuguGames/CreateChild")]
static void CreateChild() {
	if (Selection.activeGameObject !=null) {
		GameObject go = new GameObject("GameObject");
		go.transform.parent = Selection.activeGameObject.transform;
		go.transform.localPosition = Vector3.zero;
	}
}

[MenuItem ("FuguGames/CreateChild",true)]
static bool ValidateGameObject() {
	return (Selection.activeGameObject !=null);
}


}
}