using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automoving : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Z_Attack"))
        {
            transform.position += new Vector3(0, 0, 0.5f * Time.deltaTime);
        }
    }
}
