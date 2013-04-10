using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Fugu {

public class Build : EditorWindow {

       [MenuItem ("FuguGames/Build")]
       static void Init() {
       	EditorWindow.GetWindow(typeof(Build));
	}

	public void OnGUI() {
	       string path = EditorUserBuildSettings.GetBuildLocation(EditorUserBuildSettings.activeBuildTarget);
	       EditorGUILayout.LabelField(path);  
	       if (GUILayout.Button("Delete Build")) {
	       	  FileUtil.DeleteFileOrDirectory(path);
	       }
	}
}
}