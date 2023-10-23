using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 5.0f; // Velocidad de la bala grande
    public int damage = 10; // Da�o causado por la bala grande

    void Start()
    {
        // Obtener el componente Rigidbody2D de la bala
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Aplicar la velocidad a la bala
        rb.velocity = transform.up * bulletSpeed;
    }

    void Update()
    {
        
    }
}