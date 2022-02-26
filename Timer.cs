using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//게임 종료에 해당하는 ExitWall에 닿기 전까지 총 게임 플레이 시간을 기록합니다.

public class Timer : MonoBehaviour {

    public float  _time;
    bool End;

    void OnTriggerEnter(Collider Get){
      if(Get.GetComponent<Collider>().tag == "ExitWall"){
          End = true;
      if(End == true){
          Debug.Log( _time);
      }
    }
  }

    void Update(){
      if(End == false){
         _time+=Time.deltaTime;
    }
  }
}
