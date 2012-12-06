/* Copyright (c) 2012 Technicat, LLC */

#pragma strict

@MenuItem ("FuguGames/Mesh Info")
static function MeshInfo() {
	if (Selection.activeGameObject !=null) {
		var mf:MeshFilter = Selection.activeGameObject.GetComponent(MeshFilter);
		if (mf == null) {
			Debug.Log(Selection.activeGameObject.name+" No mesh");
		} else {
			var sm:Mesh = mf.sharedMesh;
			Debug.Log("shader: "+Selection.activeGameObject.renderer.sharedMaterial.shader.name+" normals: "+sm.normals.length+" tangents: "+sm.tangents.length+" colors: "+sm.colors.length+" uv: "+sm.uv.length+" uv2: "+sm.uv2.length);
		}
	}
}

@MenuItem ("FuguGames/ActivateRecursively")
static function ActivateRecursively() {
	if (Selection.activeGameObject !=null) {
		SetActiveRecursively(Selection.activeGameObject,true);
	}
}

@MenuItem ("FuguGames/DeactivateRecursively")
static function DeactivateRecursively() {
	if (Selection.activeGameObject !=null) {
		SetActiveRecursively(Selection.activeGameObject,false);
	}
}

static function SetActiveRecursively(obj:GameObject,val:boolean) {
		obj.SetActive(val);
		for (var i:int=0; i<obj.transform.GetChildCount(); ++i) {
				SetActiveRecursively(obj.transform.GetChild(i).gameObject,val);
		}
			
}

@MenuItem ("FuguGames/CreateChild")
static function CreateChild() {
	if (Selection.activeGameObject !=null) {
		var go:GameObject = new GameObject("GameObject");
		go.transform.parent = Selection.activeGameObject.transform;
		go.transform.localPosition = Vector3.zero;
	}
}

@MenuItem ("FuguGames/ActivateRecursively", true)
@MenuItem ("FuguGames/DeactivateRecursively", true)
@MenuItem ("FuguGames/Mesh Info",true)
@MenuItem ("FuguGames/CreateChild",true)
static function ValidateGameObject() {
	return (Selection.activeGameObject !=null);
}

