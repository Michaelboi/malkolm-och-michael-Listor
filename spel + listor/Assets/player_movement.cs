using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace spel_move
{
    public class player_movement : MonoBehaviour
    {
        // Den h�r funktionen �r till f�r att kunna anv�nda kroppen av objectet och s�tta den som en variabel
        Rigidbody RB;
        public void kub_movement()
        {
            RB = GetComponent<Rigidbody>();
        }

        // inputs f�r att spelaren ska kunna r�ra sig
        public void movement()
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
        }
    }
}

