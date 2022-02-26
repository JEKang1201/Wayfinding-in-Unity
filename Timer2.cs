using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//BoxOverlap코드와 함께 사용된 코드입니다. 잘못된 위치에 들어갔을 때, 잘못된 위치에서 머무른 시간이 위치의 이름과 시간이 함께 기록되도록 코딩하였습니다. 

public class Timer2 : MonoBehaviour {

    public float  _time;
    public int Count;
    bool End;

    void OnTriggerEnter(Collider Get){
      if(Get.GetComponent<Collider>().tag == "MainCamera"){
        _time = 0;
        Count += 1;
        _time+=Time.deltaTime;
      }
    }

    void OnTriggerStay(Collider Get){
      if(Get.GetComponent<Collider>().tag == "MainCamera"){
          _time+=Time.deltaTime;
        }
    }
    void OnTriggerExit(Collider Out){
      if(Count >= 1){
        Debug.Log("오류 위치 : " + this.gameObject.name);
        Debug.Log( _time);
        End = true;
      }
    }
}
