using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitDetection : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    Debug.Log(other.gameObject.name);
    if (other.gameObject.tag == "Bullet")
    {
      Destroy(other.gameObject);
    }
  }
}
