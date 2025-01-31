using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float fireSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        fireSpeed = ShootFire.instance.projectileSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        ApplyForce();
    }
    private void ApplyForce()
    {
        transform.position += transform.right * fireSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
