using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammovement : MonoBehaviour
{   
    [SerializeField]
    float sensx;
    [SerializeField]
    float sensy;

    public Transform orientation;
    float xrot=0,yrot=0;
    public float gz, gx;
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
     float mousex=-gz*Time.deltaTime*sensx*12;
     float mousey=gx*Time.deltaTime*sensy*10;
     yrot+=mousex;
     xrot-=mousey;
     xrot=Mathf.Clamp(xrot,-90f,90f);

    transform.rotation=Quaternion.Euler(xrot, yrot,0);
    orientation.rotation=Quaternion.Euler(0,yrot,0);

    }
}
