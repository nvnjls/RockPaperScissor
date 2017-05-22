using UnityEngine;
using System.Collections;

public class PController : MonoBehaviour {
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


        if (Input.GetKeyDown(KeyCode.Keypad9) && x > 0)
        {
            a.SetTrigger("HP");
            x--;
        }
        if (Input.GetKeyDown(KeyCode.Keypad6) && x > 0)
        {
            a.SetTrigger("HK");
            x--;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3) && x > 0)
        {
            a.SetTrigger("S");
            x--;
        }

    }
}
