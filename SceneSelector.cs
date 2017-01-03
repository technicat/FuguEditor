using UnityEngine;
using System.Collections;
using UnityEditor;

using UnityEditor.SceneManagement;

namespace Fugu {

public class SceneSelector : EditorWindow {

       [MenuItem ("FuguGames/Scene")]
       static void Init() {
       	EditorWindow.GetWindow(typeof(SceneSelector));
	}

	public void OnGUI() {
	     foreach (EditorBuildSettingsScene scene in  EditorBuildSettings.scenes) {
			EditorGUILayout.BeginHorizontal();
	       	EditorGUILayout.LabelField(scene.path);  
	      	 if (GUILayout.Button("Open")) {
	       	 	 EditorSceneManager.OpenScene(scene.path);
	       	}
			EditorGUILayout.EndHorizontal();
	}

		}
		
	}
}