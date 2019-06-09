using UnityEngine;
using System;
using System.Collections;
using UnityEditor;

namespace Fugu.Editor {


public class Version {

[MenuItem ("FuguGames/Version/IncVersion")]
static void IncVersion() {
	// todo - increment PlayerSettings.bundleVersion
	ClearBuildIOS();
	IncBuildAndroid();
}

[MenuItem ("FuguGames/Version/IncIOSBuild")]
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

[MenuItem ("FuguGames/Version/ClearIOSBuild")]
static void ClearBuildIOS() {
	PlayerSettings.iOS.buildNumber = "0";
}


[MenuItem ("FuguGames/Version/IncBuildAndroid")]
static void IncBuildAndroid() {
	PlayerSettings.Android.bundleVersionCode =  PlayerSettings.Android.bundleVersionCode+1;
}

}
}