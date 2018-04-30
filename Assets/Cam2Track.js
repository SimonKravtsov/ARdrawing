#pragma strict

var target : Transform;

function Start () {
	
}

function Update () {
	transform.LookAt(Vector3(target.position.x, target.position.y, target.position.z));
}
