using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

 [SerializeField]
 GameObject player;
 [SerializeField]
 Vector3 uzakl�kAyar;
    Vector3 fark;
 void Start()
 {
     fark = transform.position - player.transform.position;
 }


 void Update()
 {
     transform.position = player.transform.position + fark+uzakl�kAyar;
    }




}

