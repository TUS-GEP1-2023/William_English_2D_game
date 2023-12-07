using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilespawnerfront : MonoBehaviour
{
    [SerializeField] PlayerContoller Player;
    public Projectile projectilePrefab;
    public Transform backLaunchOffset;
    public Transform frontLaunchOffset;
    [SerializeField] private AudioSource missileSoundEffect;
    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            
            if (Player.Direct == true)
            {
                missileSoundEffect.Play();
                Instantiate(projectilePrefab, frontLaunchOffset.position, transform.rotation);
            }
           
        }
    }
}
