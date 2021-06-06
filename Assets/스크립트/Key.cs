using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{   
    public int Key_Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        //열쇠 획득 시 전용 효과음이 재생되고 사라진다.
        if (collider.gameObject.tag == "Player")
        {          
            Debug.Log("열쇠 획득!");
            SFX.Play_Key();
            Destroy(gameObject);         
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
