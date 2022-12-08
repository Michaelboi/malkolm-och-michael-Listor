using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using spawnpositions;

public class spelare : MonoBehaviour
{
    player_spawns current_pos;
    // Start is called before the first frame update
    void Start()
    {
        current_pos = GetComponent<player_spawns>();
        current_pos.position();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
