using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class archerR : MonoBehaviour
{
    public float speed = 1;
    int bow = 1;
    int count;

    void Start()
    {
        count = 0;
    }
    void FixedUpdate()
    {
        if (count <= 100)
        {
            if (bow == 1)
            {
                this.transform.Translate(speed/20, 0, 0);
                count = count + 1;
            }
        }

    }

}
