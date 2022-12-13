using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace player_move
{
    public class movement : MonoBehaviour
    {
        public Rigidbody RB;
        public int wholeNumber = 4;
        public float decimalNumber = 2.56f;
        public string text = "hejhej";
        Rigidbody GetRigidbody() { RB = GetComponent<Rigidbody>(); return RB;}
        
        public void spel_movement()
        {
            
            
            if (Input.GetKeyDown("space"))
            {
                RB.velocity = new Vector3(0, 5f, 0);
                
            }
            if (Input.GetKeyUp("space"))
            {
                RB.velocity = new Vector3(0, 0, 0);
            }
            if (Input.GetKey("up"))
            {
                RB.velocity = new Vector3(0, 0, 5f);
            }
            if (Input.GetKeyUp("up"))
            {
                RB.velocity = new Vector3(0, 0, 0);
            }
            if (Input.GetKey("right"))
            {
                RB.velocity = new Vector3(5f, 0, 0);
            }
            if (Input.GetKeyUp("right"))
            {
                RB.velocity = new Vector3(0, 0, 0);
            }
            if (Input.GetKey("down"))
            {
                RB.velocity = new Vector3(0, 0, -5f);
            }
            if (Input.GetKeyUp("down"))
            {
                RB.velocity = new Vector3(0, 0, 0);
            }
            if (Input.GetKey("left"))
            {
                RB.velocity = new Vector3(-5f, 0, 0);
            }
            if (Input.GetKeyUp("left"))
            {
                RB.velocity = new Vector3(0, 0, 0);
            }
            GetRigidbody();
        }
    }
}
