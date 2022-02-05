using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] Transform player;

    float sensitivity = 5f;

    float xRotation;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float xRot = Input.GetAxis("Mouse X") * sensitivity;
        float yRot = Input.GetAxis("Mouse Y") * sensitivity;

        xRotation -= yRot;

        Debug.Log(xRot);
        Debug.Log(yRot);
        
        transform.localRotation = Quaternion.Euler(xRotation,0,0);
        player.Rotate(player.up * xRot);
        
        
        
        //Debug.Log(mouseX);
        
    }

}
