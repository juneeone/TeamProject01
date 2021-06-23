using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JEM : MonoBehaviour
{
    public int Jem_Count = 0;
    public Text JemCount;                  //게임을 진행하며 획득한 보석의 누적 갯수를 표시
    

    void Start()
    {
        JemCount.text = "보석:" + Jem_Count.ToString();
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        //플레이어와 부딪히면 젬카운트를 1 올리고 사라진다.
        if(collider.gameObject.tag=="Player")
        {                          
            SFX.Play_Jem();           
            Destroy(gameObject);
            Plus_Jem();
            
           // Debug.Log(Jem_Count);
          
        }
    }

    void Plus_Jem()
    {
        Jem_Count = Jem_Count + 1;
        JemCount.text = "보석:" + Jem_Count;
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
