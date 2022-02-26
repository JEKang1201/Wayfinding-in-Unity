using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//저희 실험에서는 아이템 찾기 과제도 있었기에, 해당 아이템에 접근하면 아이템이
//자동으로 사라지면서 아이템 count가 되도록 구현한 코드입니다.
//해당 코드는 Finish_Game와 연결되어 사용되는데 ExitWall를 통해 게임을 종료하려면
//item 수가 2일 때만 게임이 종효되도록 구현하였습니다.

public class GetItem : MonoBehaviour {

  public float  _time;
  bool End;

  public int itemCount;

  public Finish_Game manager;

  public GameObject warning;

  void Start(){
    warning.SetActive(false);
  }

  void OnTriggerEnter(Collider other){

    if (other.tag == "Item"){
      itemCount++;
      other.gameObject.SetActive(false);
      Debug.Log(itemCount);
      Debug.Log("획득 아이템 : " + other.gameObject.name);
    }
    else if(other.tag == "ExitWall"){
      if(itemCount == manager.TotalItemCount){
        End = true;
        if(End == true){
          Debug.Log( _time);
        }
      }
      else{
        warning.SetActive(true);
    }
  }
}
  void Update(){
    if(End == false){
      _time+=Time.deltaTime;
    }
  }
}
