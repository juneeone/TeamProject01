using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//골인 지점 게이트 스크립트
public class Gate_Goal : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //플레이어 오브젝트의 Key값을 불러오고 1이 된 것이 확인되면 게이트가 사라진다.
        if(GameObject.Find("Player").GetComponent<Player_Control>().Key==1)
        {
            Destroy(gameObject);
        }
    }
}
