using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace spawnpositions
{
    public class player_spawns : MonoBehaviour
    {
        System.Random X = new System.Random();
        List<Vector3> spawnpos = new List<Vector3>();
        public void position()
        {
            
            
            spawnpos.Add(new Vector3(2, 1, 0));
            spawnpos.Add(new Vector3(5, 1, 0)); 
            

            gameObject.transform.position = spawnpos[X.Next(0,1)];
        }
        
        

        
        
    }
}
