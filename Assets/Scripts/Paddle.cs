using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{


    public Camera mainCam;

    float LeftMax = 90;        //Max paddle can move to the left
    float RightMax = 500;        //Max paddle can move to the right
    // Start is called before the first frame update
    void Start()
    {
        mainCam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        ObjectMovement();
    }


    void ObjectMovement()
    {

        float move = Mathf.Clamp(Input.mousePosition.x, LeftMax, RightMax);

        float Xposition= mainCam.ScreenToWorldPoint(new Vector3(move, 0, 0)).x;

        this.transform.position = new Vector3(Xposition,-4,0);

    }
}
