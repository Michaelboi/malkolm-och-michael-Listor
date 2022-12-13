using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using spawnpositions;
<<<<<<< Updated upstream
using player_move;
=======
>>>>>>> Stashed changes

public class spelare : MonoBehaviour
{
    player_spawns current_pos;
<<<<<<< Updated upstream
    movement move = new movement();

    // Start is called before the first frame update
    void Start()
    {
        
        move = GetComponent<movement>();
        current_pos = GetComponent<player_spawns>();
        current_pos.position();
        move.RB = GetComponent<Rigidbody>();



=======
    // Start is called before the first frame update
    void Start()
    {
        current_pos = GetComponent<player_spawns>();
        current_pos.position();
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        
<<<<<<< Updated upstream
        move.spel_movement();
=======
>>>>>>> Stashed changes
    }
}
