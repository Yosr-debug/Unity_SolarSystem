using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;


public class cube : MonoBehaviour

{
    public Transform centerSphere; 
    public float orbitSpeed = 1.0f; 
    public float selfRotationSpeed = 2.0f; 

    private void Update()
    {
        
        transform.RotateAround(centerSphere.position, Vector3.up, orbitSpeed * Time.deltaTime);

      
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime);
    }
}