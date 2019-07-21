using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad/20f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-2f)
        {
            Destroy(gameObject);
        }
    }
}
