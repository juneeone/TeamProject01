using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{

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

    public void Score_one(Collider other)
    {
        if(other.gameObject.tag=="JEM")
        {
            Destroy(other.gameObject);
            score += 100;
            Debug.Log(score);
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
