using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneDestroy : MonoBehaviour
{
    public PlaneController script;
    private float planespeed;

    public GameObject explosion;
    public Transform spawnTransform;

    private bool collisionHandled = false;

    // Start is called before the first frame update
    void Start()
    {
        script = FindObjectOfType<PlaneController>(); // Corrected the method name
    }

    // Update is called once per frame
    void Update()
    {
        planespeed = script.speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (planespeed > 3 && !collisionHandled)
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(collision.gameObject);
            }

            Instantiate(explosion, spawnTransform.position, spawnTransform.rotation);

            StartCoroutine(DelayAndLoadScene(2f)); // Delay for 2 seconds (adjust as needed)
            collisionHandled = true;
        }
    }

    IEnumerator DelayAndLoadScene(float delay)
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(1); // Load the scene after the delay
    }
}
