using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    [SerializeField] private Transform cubeTransform;
    // Update is called once per frame
    void Update()
    {
        cubeTransform.Rotate(new Vector3(0.6f,0.1f,1));
        if (Input.touchCount > 0)
        {
        Touch touch=Input.GetTouch(0);
        
            switch (touch.phase)
            {
                case TouchPhase.Began:
                  //  cubeTransform.localScale = new Vector3(2, 2, 2);
                    break;
                case TouchPhase.Moved:
                    cubeTransform.position+= new Vector3(touch.deltaPosition.x,touch.deltaPosition.y,0)*Time.deltaTime;
                    
                    break;
                case TouchPhase.Stationary://basýlý durduðunda
                    cubeTransform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                    Debug.Log("Stationary");
                    break;
                case TouchPhase.Ended:
                    cubeTransform.localScale = new Vector3(1, 1, 1);
                    break;
                case TouchPhase.Canceled:
                    Debug.Log("Canceled");
                    break;
                default:
                    break;
            }
            if (Input.touchCount > 1) { 
            Touch touch2 = Input.GetTouch(1);
         
                switch (touch2.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("Touch2");
                    break;
                case TouchPhase.Moved:
                    Debug.Log("Touch2");
                    break;
                case TouchPhase.Stationary:
                   
                    Debug.Log("Touch2");
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Touch2");
                    break;
                case TouchPhase.Canceled:
                    Debug.Log("Touch2");
                    break;
                default:
                    break;
            }}
        }
    }
}
