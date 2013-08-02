using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Fugu.Editor {

public class ObjectStats : EditorWindow {

       [MenuItem ("FuguGames/Stats/Object")]
       static void MeshInfo() {
      	 EditorWindow.GetWindow(typeof(ObjectStats));
	}
		[MenuItem ("FuguGames/Stats/Object",true)]
		static bool ValidateGameObject() {
			return Selection.activeGameObject != null;
		}

	public void OnGUI() {
		GameObject go = Selection.activeGameObject;
		EditorGUILayout.LabelField ("name: "+go.name);
		Vector3 pos = go.transform.position;
		EditorGUILayout.LabelField ("global position: "+pos.x+","+pos.y+","+pos.z);
		Vector3 rot = go.transform.eulerAngles;
		EditorGUILayout.LabelField ("global rotation: "+rot.x+","+rot.y+","+rot.z);
		Vector3 scale = go.transform.lossyScale;
		EditorGUILayout.LabelField ("lossy scale: "+scale.x+","+scale.y+","+scale.z);
		MeshFilter mf = go.GetComponent<MeshFilter>();
		if (mf == null) {
			EditorGUILayout.LabelField("No mesh");
		} else {
			Mesh sm = mf.sharedMesh;
			EditorGUILayout.LabelField("shader: "+go.renderer.sharedMaterial.shader.name);
			EditorGUILayout.LabelField("normals: "+sm.normals.Length);
			EditorGUILayout.LabelField("tangents: "+sm.tangents.Length);
			EditorGUILayout.LabelField("colors: "+sm.colors.Length);
			EditorGUILayout.LabelField("uv: "+sm.uv.Length);
			EditorGUILayout.LabelField("uv2: "+sm.uv2.Length);
		}
	}
}
}