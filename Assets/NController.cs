using UnityEngine;
using System.Collections;

public class NController : MonoBehaviour {

    Animator a;
    int x;
    int maxShots;
    // Use this for initialization
    void Start()
    {
        maxShots = 2;
        a = this.gameObject.GetComponent<Animator>();
        x = maxShots;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            x = maxShots;
        }



        if (Input.GetKeyDown(KeyCode.W) && x>0)
        {
            a.SetTrigger("HP");
            x--;
        }
        if (Input.GetKeyDown(KeyCode.S) && x > 0)
        {
            a.SetTrigger("HK");
            x--;
        }
        if (Input.GetKeyDown(KeyCode.Z) && x > 0)
        {
            a.SetTrigger("S");
            x--;
        }

    }
}
