using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    private Rigidbody2D rb;
    private Animator anim;
    void Start()
    {
        currentHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Enemies"))
        { 
            TakeDamage();
            
        }
    }

    void TakeDamage()
    {
        currentHealth--;
        if (currentHealth <= 0) 
        {
                 rb.bodyType = RigidbodyType2D.Static;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
