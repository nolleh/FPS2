using UnityEngine;
using System.Collections;

//namespace TEST {
public class KongBullet : MonoBehaviour {

	private Vector3 vDir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}

	public void init(Vector3 _vDir) {
		vDir = _vDir;
	}

	void Move() {
		Vector3 vPos = transform.localPosition;
		vPos.z += vDir.z;
		transform.localPosition = vPos;
	}
}
//}
