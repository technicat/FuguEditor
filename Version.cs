using UnityEngine;
using System;
using System.Collections;
using UnityEditor;

namespace Fugu.Editor {

// should rename this
// 
public class Version {

	[MenuItem ("FuguGames/Version/Clear Defines")]
static void ClearDefines() {
	FuguGamesMenu.ClearAllScriptingDefines();
}

[MenuItem ("FuguGames/Version/Inc Mobile Versions")]
static void IncVersion() {
	// todo - increment PlayerSettings.bundleVersion
	ClearBuildIOS();
	IncBuildAndroid();
}

[MenuItem ("FuguGames/Version/Inc IOSBuild")]
static void IncBuildIOS() {
	try
       {
           int result = Int32.Parse(PlayerSettings.iOS.buildNumber);
		   result = result + 1;
		   PlayerSettings.iOS.buildNumber = result.ToString();
       }
	   catch (FormatException)
       {
           Debug.Log("Unable to parse iOS build number");
       }
}

[MenuItem ("FuguGames/Version/Clear IOS Build")]
static void ClearBuildIOS() {
	PlayerSettings.iOS.buildNumber = "0";
}


[MenuItem ("FuguGames/Version/IncBuildAndroid")]
static void IncBuildAndroid() {
	PlayerSettings.Android.bundleVersionCode =  PlayerSettings.Android.bundleVersionCode+1;
}

}
}