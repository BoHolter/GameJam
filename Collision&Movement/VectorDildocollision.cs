using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDildocollision : MonoBehaviour
{
    public static bool dildocollision;
    public GameObject dildoappear;

    private void Awake()
    {
        dildocollision = false;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dildocollision)
        {
            dildoappear.SetActive(true);

        }
    }
}
