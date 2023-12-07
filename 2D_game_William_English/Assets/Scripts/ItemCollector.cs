using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int melons = 0;
    [SerializeField] private Text MelonsText;
    [SerializeField] private AudioSource collectingSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            collectingSoundEffect.Play();
            Destroy(collision.gameObject);
            melons++;
            MelonsText.text = "Melons" + melons;

        }
    }
}
