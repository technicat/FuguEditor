using UnityEngine;
using UnityEditor;

namespace Hyper {
public class HyperBowlMenu {
		const string srcPath = "Assets/iPhoneTextures/Icon/";
		const string freeDefs = "FUGU_ADS;P31_IAD;P31_WEB";
		//const string freeDefs = "FUGU_ADS;P31_IAD";
		//const string freeDefs = "FUGU_ADS";
	
		static Texture2D[]icons = new Texture2D[4];
		
		static void UseIcon(string name,BuildTargetGroup target) {
			Texture2D icon = AssetDatabase.LoadMainAssetAtPath (srcPath+name) as Texture2D;
			for (int i=0; i<icons.Length; ++i) {
				icons[i]=icon;
			}
			PlayerSettings.SetIconsForTargetGroup(target,icons);
		}
		
		static void UseIcon(string[] names, BuildTargetGroup target) {
			for (int i=0; i<names.Length; ++i) {
				Texture2D icon = AssetDatabase.LoadMainAssetAtPath (srcPath+names[i]) as Texture2D;
				icons[i]=icon;
			}
			PlayerSettings.SetIconsForTargetGroup(target,icons);
		}
		
// desktop
		
[MenuItem ("FuguGames/HyperBowl/desktop/Mac")]
static void mac() {
	PlayerSettings.productName = "HyperBowl";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Standalone,"HYPERALL");
	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.StandaloneOSXIntel64);
}
		
// web
		
[MenuItem ("FuguGames/HyperBowl/web/HyperBowl")]
static void webplayer() {
	PlayerSettings.productName = "HyperBowl";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebPlayer,"HYPERALL");
	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.WebPlayerStreamed);
	//UseIcon ("classic512.png",BuildTargetGroup.iPhone);
}
		
[MenuItem ("FuguGames/HyperBowl/web/Kongregate")]
static void Kongregate() {
	PlayerSettings.productName = "HyperBowl";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebPlayer,"HYPERALL;KONGREGATE");
	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.WebPlayerStreamed);
	//UseIcon ("classic512.png",BuildTargetGroup.iPhone);
}
		
[MenuItem ("FuguGames/HyperBowl/web/NaCl")]
static void NaCl() {
	PlayerSettings.productName = "HyperBowl";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.NaCl,"HYPERALL");
	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.NaCl);
	//UseIcon ("classic512.png",BuildTargetGroup.iPhone);
}
		
// ios
		
static void TargetiOS() {
	PlayerSettings.use32BitDisplayBuffer = true;
	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iPhone);
		}

[MenuItem ("FuguGames/HyperBowl/iOS/HyperBowl")]
static void HyperBowl() {
	PlayerSettings.productName = "HyperBowl";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERALL");
	string[] names = new string[] {"hyperbowl-logo-banner-scaled-512x512.png",
								"hyperbowl-logo-banner-scaled-114x114.png",
								"hyperbowl-logo-banner-scaled-72x72.png",
								"hyperbowl-logo-banner-scaled-57x57.png"};
	UseIcon (names,BuildTargetGroup.iPhone);
	TargetiOS();
	/* for (var scene in EditorBuildSettings.scenes) {
		scene.enabled = true;
	}
	EditorBuildSettings.scenes = EditorBuildSettings.scenes; */
}

[MenuItem ("FuguGames/HyperBowl/iOS/HyperBowl Classic")]
static void Classic() {
	PlayerSettings.productName = "HyperBowl Classic";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlClassic";
	PlayerSettings.use32BitDisplayBuffer = true;
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERCLASSIC;"+freeDefs);
	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.iPhone);
	UseIcon ("classic512.png",BuildTargetGroup.iPhone);
}

[MenuItem ("FuguGames/HyperBowl/iOS/HyperBowl Rome")]
static void Rome() {
	PlayerSettings.productName = "HyperBowl Rome";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlRome";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERROME;"+freeDefs);
	UseIcon ("rome.png",BuildTargetGroup.iPhone);
	TargetiOS();
}

[MenuItem ("FuguGames/HyperBowl/iOS/HyperBowl Forest")]
static void Forest() {
	PlayerSettings.productName = "HyperBowl Forest";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlForest";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERFOREST;"+freeDefs);
	UseIcon ("forest.png",BuildTargetGroup.iPhone);
	TargetiOS();
}

[MenuItem ("FuguGames/HyperBowl/iOS/HyperBowl High Seas")]
static void HighSeas() {
	PlayerSettings.productName = "HyperBowl High Seas";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlHighSeas";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERSHIP;"+freeDefs);
	UseIcon ("highseas.png",BuildTargetGroup.iPhone);
	TargetiOS();
}

[MenuItem ("FuguGames/HyperBowl/iOS/HyperBowl San Francisco")]
static void SanFrancisco() {
	PlayerSettings.productName = "HyperBowl San Francisco";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperSF";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERSF;"+freeDefs);
	UseIcon ("hypersf.png",BuildTargetGroup.iPhone);
	TargetiOS();
}

[MenuItem ("FuguGames/HyperBowl/iOS/HyperBowl Tokyo")]
static void Tokyo() {
	PlayerSettings.productName = "HyperBowl Tokyo";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperTokyo";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERTOKYO;"+freeDefs);
	UseIcon ("tokyo.png",BuildTargetGroup.iPhone);
	TargetiOS();
}

[MenuItem ("FuguGames/HyperBowl/iOS/HperBowl Snowpark")]
static void Snowpark() {
	PlayerSettings.productName = "HyperBowl Snowpark";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlSnow";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERSNOW;"+freeDefs);
	UseIcon ("snowpark.png",BuildTargetGroup.iPhone);
	TargetiOS();
}
	
[MenuItem ("FuguGames/HyperBowl/iOS/HyperBowl Penelope")]
static void Penelope() {
	PlayerSettings.productName = "HyperBowl Penelope";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlPenelope";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERPENELOPE;"+freeDefs);
	UseIcon ("penelope.png",BuildTargetGroup.iPhone);
	TargetiOS();
}
	
[MenuItem ("FuguGames/HyperBowl/iOS/HyperBowl Mushroom")]
static void Mushroom() {
	PlayerSettings.productName = "HyperBowl Mushroom";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlMushroom";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.iPhone,"HYPERMUSHROOM;"+freeDefs);
	UseIcon ("mushroom.png",BuildTargetGroup.iPhone);
	TargetiOS();
}
		
		// google play - etc

static void TargetAndroidGeneric() {
	PlayerSettings.use32BitDisplayBuffer = false;
	EditorUserBuildSettings.androidBuildSubtarget = AndroidBuildSubtarget.Generic;
	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
}
		
[MenuItem ("FuguGames/HyperBowl/Google/HyperBowl")]
static void GoogleComplete() {
	PlayerSettings.productName = "HyperBowl";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlComplete";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"GOOGLE;FUGU_ADS;HYPERALL");
	TargetAndroidGeneric();
}
		
[MenuItem ("FuguGames/HyperBowl/Google/HyperBowl Lite")]
static void GoogleLite() {
	PlayerSettings.productName = "HyperBowl Lite";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"GOOGLE;FUGU_ADS;HYPERALL");
	TargetAndroidGeneric();
}

[MenuItem ("FuguGames/HyperBowl/Google/HyperBowl Pro")]
static void GooglePro() {
	PlayerSettings.productName = "HyperBowl Pro";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlPro";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"GOOGLE;HYPERALL");
	TargetAndroidGeneric();
}
		
[MenuItem ("FuguGames/HyperBowl/Google/HyperBowl Classic")]
static void GoogleClassic() {
	PlayerSettings.productName = "HyperBowl Classic";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlClassic";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"GOOGLE;FUGU_ADS;HYPERCLASSIC");
	//UseIcon("rome.png",BuildTargetGroup.Android);
	TargetAndroidGeneric();
}
		
[MenuItem ("FuguGames/HyperBowl/Google/HyperBowl Rome")]
static void GoogleRome() {
	PlayerSettings.productName = "HyperBowl Rome";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlRome";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"GOOGLE;FUGU_ADS;HYPERROME");
	//UseIcon("rome.png",BuildTargetGroup.Android);
	TargetAndroidGeneric();
}
		
[MenuItem ("FuguGames/HyperBowl/Google/HyperBowl Forest")]
static void GoogleForest() {
	PlayerSettings.productName = "HyperBowl Forest";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlForest";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"GOOGLE;FUGU_ADS;HYPERFOREST");
	//UseIcon("rome.png",BuildTargetGroup.Android);
	TargetAndroidGeneric();
}
		
[MenuItem ("FuguGames/HyperBowl/Google/HyperBowl High Seas")]
static void GoogleShip() {
	PlayerSettings.productName = "HyperBowl Forest";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlHighSeas";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"GOOGLE;FUGU_ADS;HYPERSHIP");
	//UseIcon("rome.png",BuildTargetGroup.Android);
	TargetAndroidGeneric();
}
		
[MenuItem ("FuguGames/HyperBowl/Google/HyperBowl Snowpark")]
static void GoogleSnow() {
	PlayerSettings.productName = "HyperBowl Snowpark";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlSnowpark";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"GOOGLE;FUGU_ADS;HYPERSNOW");
	//UseIcon("snowpark.png",BuildTargetGroup.Android);
	TargetAndroidGeneric();
}
		
// opera
		
[MenuItem ("FuguGames/HyperBowl/Opera/HyperBowl Lite")]
static void Opera() {
	PlayerSettings.productName = "HyperBowl Lite";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"FUGU_ADS;HYPERALL");
	TargetAndroidGeneric();
}
		
		// nook - powervr
		
static void TargetNook() {
	PlayerSettings.use32BitDisplayBuffer = false;
	EditorUserBuildSettings.androidBuildSubtarget = AndroidBuildSubtarget.PVRTC;
	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
}

[MenuItem ("FuguGames/HyperBowl/Nook/HyperBowl")]
static void Nook() {
	PlayerSettings.productName = "HyperBowl";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlPro";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"NOOK;HYPERALL");
	TargetNook();
}
		
[MenuItem ("FuguGames/HyperBowl/Nook/HyperBowl Snowpark")]
static void NookSnow() {
	PlayerSettings.productName = "HyperBowl Snowpark";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlSnowpark";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"NOOK;HYPERSNOW");
	TargetNook();
}
		
	// amazon - etc
		
[MenuItem ("FuguGames/HyperBowl/Amazon/HyperBowl Lite")]
static void AmazonLite() {
	PlayerSettings.productName = "HyperBowl Lite";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"AMAZON;FUGU_ADS;HYPERALL");
	TargetAndroidGeneric();
}

[MenuItem ("FuguGames/HyperBowl/Amazon/HyperBowl Pro")]
static void AmazonPro() {
	PlayerSettings.productName = "HyperBowl Pro";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlPro";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"AMAZON;HYPERALL");
	TargetAndroidGeneric();
}
		
// nabi - tegra
		
static void TargetTegra() {
	PlayerSettings.use32BitDisplayBuffer = true;
	EditorUserBuildSettings.androidBuildSubtarget = AndroidBuildSubtarget.DXT;
	EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
}
		
[MenuItem ("FuguGames/HyperBowl/Nabi/HyperBowl Lite")]
static void NabiLite() {
	PlayerSettings.productName = "HyperBowl Lite";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"NABI;FUGU_ADS;HYPERALL");
	TargetTegra();
}

[MenuItem ("FuguGames/HyperBowl/Nabi/HyperBowl Pro")]
static void NabiPro() {
	PlayerSettings.productName = "HyperBowl Pro";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowlPro";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"NABI;HYPERALL");
	TargetTegra();
}
		
// samsung
[MenuItem ("FuguGames/HyperBowl/Samsung/HyperBowl")]
static void Samsung() {
	PlayerSettings.productName = "HyperBowl";
	PlayerSettings.bundleIdentifier = "com.technicat.HyperBowl";
	PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.Android,"SAMSUNG;FUGU_ADS;HYPERALL");
	TargetAndroidGeneric();
}

}
	
}