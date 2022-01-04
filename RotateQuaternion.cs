using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateQuaternion : MonoBehaviour
{
	Quaternion originRotation;

	float angleHorizontal;
	float angleVertical;
	float mouseSens = 5;  
    float angleRotationZ = 0.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        originRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        angleHorizontal+= Input.GetAxis("Mouse X") * mouseSens;
		angleVertical+= Input.GetAxis("Mouse Y") * mouseSens;

		angleVertical = Mathf.Clamp(angleVertical, -50, 50);
		Quaternion rotationY = Quaternion.AngleAxis(angleHorizontal, Vector3.up);
		Quaternion rotationX = Quaternion.AngleAxis(-angleVertical, Vector3.right);
		
		transform.rotation = originRotation * rotationY * rotationX;
        
        //DEBUG CODE
    }
}
