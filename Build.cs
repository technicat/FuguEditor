using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Fugu.Editor {

public class Build : EditorWindow {

       [MenuItem ("FuguGames/Builds")]
       static void Init() {
       	EditorWindow.GetWindow(typeof(Build));
	}

		public void OnGUI() {
		 LayoutTarget(BuildTarget.iPhone);
			 LayoutTarget(BuildTarget.Android);
			 LayoutTarget(BuildTarget.WebPlayer);
			 LayoutTarget(BuildTarget.WebPlayerStreamed);
			LayoutTarget(BuildTarget.StandaloneWindows);
		}
		
		private void LayoutTarget(BuildTarget target) {
			string path = EditorUserBuildSettings.GetBuildLocation(target);
			if (!System.String.IsNullOrEmpty(path)) {
				EditorGUILayout.BeginHorizontal();
				string name = target.ToString();
				if (EditorUserBuildSettings.activeBuildTarget == target) {
					name = name + " (current)";
				};
				EditorGUILayout.LabelField(name);
	     	  	if (System.IO.File.Exists(path) || System.IO.Directory.Exists(path)) {
					if (GUILayout.Button("Delete Build")) {
	       		  		FileUtil.DeleteFileOrDirectory(path);
					}
	      	 	}
				EditorGUILayout.EndHorizontal();
				EditorGUILayout.LabelField(path);  	
			}
	}
}
}