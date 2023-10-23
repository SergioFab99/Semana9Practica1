using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject balaPrefab; // Prefab de la bala

    private Transform firePoint; // Punto de origen de los disparos
    private Vector3 lastPlayerDirection = Vector3.up; // Almacena la �ltima direcci�n del jugador

    private void Start()
    {
        firePoint = transform.Find("FirePoint"); // Asigna el firepoint en el jugador
    }

    private void Update()
    {
        // Detectar el disparo con la tecla "X"
        if (Input.GetKeyDown(KeyCode.X))
        {
            Shoot();
        }

        // Detectar el movimiento del jugador y almacenar la �ltima direcci�n
        Vector3 playerDirection = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            playerDirection += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerDirection += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerDirection += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerDirection += Vector3.right;
        }

        if (playerDirection != Vector3.zero)
        {
            lastPlayerDirection = playerDirection.normalized;
        }
    }

    private void Shoot()
    {
        // Crear una instancia de la bala en la posici�n del firepoint
        GameObject bullet = Instantiate(balaPrefab, firePoint.position, Quaternion.identity);

        // Ajustar la rotaci�n de la bala para que dispare en la �ltima direcci�n del jugador
        bullet.transform.up = lastPlayerDirection;
    }
}