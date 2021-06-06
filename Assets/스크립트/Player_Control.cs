using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public int Key = 0;
    private float Player_Speed = 0.05f;
    public int score = 0;

    private void Player_Move()
    {
      if(Input.GetKey(KeyCode.UpArrow)==true)
        {
            transform.Translate(0.0f, 0.0f, Player_Speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(0.0f, 0.0f, -Player_Speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(-Player_Speed,0.0f , 0.0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(Player_Speed, 0.0f, 0.0f);
        }

    }

    //public void Score_one(Collider other)
    //{
    //    if (other.gameObject.tag == "JEM")
    //    {    
    //        score += 100;
    //        Debug.Log(score);
    //    }
    //}

    private void OnTriggerEnter(Collider collider)
    {
        //열쇠 획득 시
        if (collider.gameObject.tag == "KEY")
        {
            Key+=1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player_Move();
    }
}
