using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//실제 실험에서 활용되지는 않았으나, 혹시 도움이 될까하여 넣습니다.
//특정 시간내에 과제를 완수해야 할 때 시간을 설정할 수 있도록 짜여진 코드입니다.
//시간은   public int secondLeft = 10; 에서 고쳐 사용하시면 됩니다.


public class timeAttack : MonoBehaviour{
  public int secondLeft = 10;
  public bool takingAway = false;

  void Update(){
    if(takingAway == false && secondLeft > 0){
      StartCoroutine(TimerTake());
    }
  }
  IEnumerator TimerTake(){
    takingAway = true;
    yield return new WaitForSeconds(1);
    secondLeft -= 1;
    takingAway = false;
  }
}
