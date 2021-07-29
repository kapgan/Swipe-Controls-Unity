using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    [SerializeField] private Transform cubeTransform;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
        Touch touch=Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                  //  cubeTransform.localScale = new Vector3(2, 2, 2);
                    break;
                case TouchPhase.Moved:
                    cubeTransform.position+= new Vector3(touch.deltaPosition.x,touch.deltaPosition.y,0)*0.01f;
                    break;
                case TouchPhase.Stationary:
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
        }
    }
}
