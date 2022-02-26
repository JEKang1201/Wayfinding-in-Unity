using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//esc키를 통해 unit로 실행되는 게임 자체를 종료시키는 키입니다.

public class EndGame : MonoBehaviour
{
  void Update(){
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      Application.Quit();
    }
  }
}
