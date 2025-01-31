using System.Collections.Generic;
using UnityEngine;

public class ShootFire : MonoBehaviour
{
    public static ShootFire instance;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform firePoint;
    public float projectileSpeed = 10f;
    [SerializeField] private int maxProjectiles = 5;
    private Queue<GameObject> projectiles = new Queue<GameObject>();


    void Awake(){
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Shoot();
        }
    }
    private void Shoot()
    {
        if (projectiles.Count >= maxProjectiles)
        {
            GameObject oldProjectile = projectiles.Dequeue();
            Destroy(oldProjectile);
        }

        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        projectiles.Enqueue(projectile);
    }
    
}
