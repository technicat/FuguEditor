using UnityEngine;
using System.Collections;
using UnityEditor;

namespace Fugu.Editor {


public class Activate {

[MenuItem ("FuguGames/Active/ActivateRecursively")]
static void ActivateRecursively() {
	if (Selection.activeGameObject !=null) {
		SetActiveRecursively(Selection.activeGameObject,true);
	}
}

[MenuItem ("FuguGames/Active/DeactivateRecursively")]
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

[MenuItem ("FuguGames/ActivateRecursively", true)]
[MenuItem ("FuguGames/DeactivateRecursively", true)]
static bool ValidateGameObject() {
	return (Selection.activeGameObject !=null);
}
}
}