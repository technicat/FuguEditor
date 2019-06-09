using UnityEngine;
using System.Collections;
using UnityEditor;

using System.Linq;

namespace Fugu.Editor {


public class CreatChild {

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