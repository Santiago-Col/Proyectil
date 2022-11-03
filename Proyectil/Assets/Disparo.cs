using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject disparoPrefab;
    public int velocidad;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject nuevodisparo = Instantiate(disparoPrefab, transform.position + transform.up, transform.rotation);
            nuevodisparo.GetComponent<Rigidbody2D>().AddForce(transform.up * velocidad, ForceMode2D.Impulse);
        }
    }
}