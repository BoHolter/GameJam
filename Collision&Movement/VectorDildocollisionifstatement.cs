using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VectorDildocollisionifstatement : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Dildo")
        {
            VectorDildocollision.dildocollision = true;
            
        }
    }
}
