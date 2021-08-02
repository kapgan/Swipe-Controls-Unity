using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    public Text outputText;

    private Vector2 startTouchPosition;
    private Vector2 currentPosition;
    private Vector2 endTouchPosition;
    private bool stopTouch = false;

    public float swipeRange;
    public float tapRange;
    

    [SerializeField]
    float guc = 1f;
 
    [SerializeField]
    Rigidbody rig;
    //////////////
    public bool enableSlowSwipe = false;
  

    void Update()
    {

            fastSwipe();


    }

    public void fastSwipe()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currentPosition = Input.GetTouch(0).position;
            Vector2 Distance = currentPosition - startTouchPosition;

            if (!stopTouch)
            {

                if (Distance.x < -swipeRange)
                {
                    outputText.text = "Left";
                    stopTouch = true;
                    
                    rig.AddForce(new Vector3(-guc,0f,0f), ForceMode.Impulse);

                }
                else if (Distance.x > swipeRange)
                {
                    outputText.text = "Right";
                    stopTouch = true;
                   rig.AddForce(new Vector3(guc, 0f, 0f), ForceMode.Impulse);
                }
                else if (Distance.y > swipeRange)
                {
                    outputText.text = "Up";
                    stopTouch = true;
                   rig.AddForce(new Vector3(0f,0f, guc), ForceMode.Impulse);
                }
                else if (Distance.y < -swipeRange)
                {
                    outputText.text = "Down";
                    stopTouch = true;
                   rig.AddForce(new Vector3(0f,0f, -guc), ForceMode.Impulse);
                }

            }

        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPosition = Input.GetTouch(0).position;

            Vector2 Distance = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                rig.AddForce(new Vector3(0f, guc,0f), ForceMode.Impulse);
                outputText.text = "Tap";
            }

        }
    }





}

