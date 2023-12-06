using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilespawnerfront : MonoBehaviour
{
    [SerializeField] PlayerContoller Player;
    public Projectile projectilePrefab;
    public Transform backLaunchOffset;
    public Transform frontLaunchOffset;
    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            
            if (Player.Direct == true)
            {
                Instantiate(projectilePrefab, frontLaunchOffset.position, transform.rotation);
            }
           
        }
    }
}
