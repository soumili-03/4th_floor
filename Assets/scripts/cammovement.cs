using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammovement : MonoBehaviour
{   
    [SerializeField]
    float sensx;
    [SerializeField]
    float sensy;

    public Transform body;
    float xrot=0,yrot=0;
    public float gz, gx;
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
    float mousex=Input.GetAxisRaw("Mouse X")*Time.deltaTime*sensx*10;
     float mousey=Input.GetAxisRaw("Mouse Y")*Time.deltaTime*sensy*10;
    
     xrot-=mousey;
     xrot=Mathf.Clamp(xrot,-90f,90f);

    transform.localRotation=Quaternion.Euler(xrot, 0,0);
    body.Rotate(Vector3.up*mousex);
    

    }
}
