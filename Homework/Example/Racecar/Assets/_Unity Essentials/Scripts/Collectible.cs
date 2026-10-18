using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject onCollectEffect; // Effect to play when collected
    public float rotationSpeed = 0.5f; // Speed of rotation in degrees per second
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        // Destory the collectable
        Destroy(gameObject);
        // Instantiate the effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
        
    }
}
