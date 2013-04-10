using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Fugu {


public class FuguGamesMenu {

[MenuItem ("FuguGames/ActivateRecursively")]
static void ActivateRecursively() {
	if (Selection.activeGameObject !=null) {
		SetActiveRecursively(Selection.activeGameObject,true);
	}
}

[MenuItem ("FuguGames/DeactivateRecursively")]
static void DectivateRecursively() {
	if (Selection.activeGameObject !=null) {
		SetActiveRecursively(Selection.activeGameObject,false);
	}
}

static void SetActiveRecursively(GameObject obj,bool val) {
		obj.SetActive(val);
		for (int i=0; i<obj.transform.childCount; ++i) {
				SetActiveRecursively(obj.transform.GetChild(i).gameObject,val);
		}
			
}

[MenuItem ("FuguGames/CreateChild")]
static void CreateChild() {
	if (Selection.activeGameObject !=null) {
		GameObject go = new GameObject("GameObject");
		go.transform.parent = Selection.activeGameObject.transform;
		go.transform.localPosition = Vector3.zero;
	}
}

[MenuItem ("FuguGames/ActivateRecursively", true)]
[MenuItem ("FuguGames/DeactivateRecursively", true)]
[MenuItem ("FuguGames/CreateChild",true)]
static bool ValidateGameObject() {
	return (Selection.activeGameObject !=null);
}
}
}