using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_Goal : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player").GetComponent<Player_Control>().Key==1)
        {
            Destroy(gameObject);
        }
    }
}
