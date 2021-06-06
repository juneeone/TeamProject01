using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JEM : MonoBehaviour
{

    public int Jem_Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        //플레이어와 부딪히면 젬카운트를 1 올리고 사라진다.
        if(collider.gameObject.tag=="Player")
        {
            Jem_Count += 1;
            Debug.Log(Jem_Count);
            SFX.Play_Jem();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
