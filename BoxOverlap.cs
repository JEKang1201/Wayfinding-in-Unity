using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOverlap : MonoBehaviour {

    public LayerMask layer;
    //저희 실험에서 최단 거리가 아닌 루트로 갔을 때, 각 잘못된 위치마다 naming을 해서 잘못된 위치로 갈 때마다 이름이 뜨도록 처치한 코드입니다.
	// Update is called once per frame
	void Update () {
        MyCollisions ();
    }

    void MyCollisions () {
        Collider [] hitColliders = Physics.OverlapBox (
            GetComponent<BoxCollider> ().center + transform.parent.position,
            GetComponent<BoxCollider> ().size / 2,
            Quaternion.identity,
            layer
        );

        int i = 0;
        while (i < hitColliders.Length) {
            Debug.Log ("Hit : " + hitColliders [i].name);
            i++;
        }
    }
}
