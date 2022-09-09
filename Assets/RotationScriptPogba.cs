using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScriptPogba : MonoBehaviour
{
    private float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime * 40;
        transform.rotation = Quaternion.Euler(0,x,180);
    }
}
