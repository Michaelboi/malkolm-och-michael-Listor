using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using spawnpositions;
using player_move;

public class spelare : MonoBehaviour
{
    player_spawns current_pos;
    movement move = new movement();

    // Start is called before the first frame update
    void Start()
    {
        
        move = GetComponent<movement>();
        current_pos = GetComponent<player_spawns>();
        current_pos.position();
        move.RB = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {
        
        move.spel_movement();
    }
}
