using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().color -= new Color(0, 0.1f, 0.1f, 0);
        Destroy(gameObject);
    }
}
