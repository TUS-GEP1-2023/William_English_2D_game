using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSpawner : MonoBehaviour
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
             if (Player.Direct == false)
            {
                missileSoundEffect.Play();
                Instantiate(projectilePrefab, backLaunchOffset.position, transform.rotation);
            }
        }
    }
}
