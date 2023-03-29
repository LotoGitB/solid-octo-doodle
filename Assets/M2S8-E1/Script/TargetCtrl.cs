using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCtrl : MonoBehaviour
{
  private TimerCtrl timerRef;
  private ScoreCtrl scoreRef;

  private void Start()
  {
    //timerRef = new TimerCtrl();
    timerRef = GameObject.Find("Timer").GetComponent<TimerCtrl>();
    scoreRef = GameObject.Find("Score").GetComponent<ScoreCtrl>();
  }
  private void OnMouseDown()
  {
    Debug.Log("Clicked " + gameObject.name);
    if (timerRef.GetTimer() > 0)
    {
      timerRef.AddTime(0.5f);
      scoreRef.ScoreAdd(1);
      gameObject.SetActive(false);
    }
  }
}
