using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraFollow : MonoBehaviour
{public Transform Target;
public float Cameraspeed;

public float minX,maxX;
public float minY,maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Target!=null)
        {
            
            Vector2 newCamposition= Vector2.Lerp(transform.position,Target.position,Time.deltaTime*Cameraspeed);
            float ClampX = Mathf.Clamp(newCamposition.x,minX,maxX);
            float clampY = Mathf.Clamp(newCamposition.y,minY,maxY);
            transform.position=new Vector3(ClampX,clampY,-10f);
        }
    }
}
