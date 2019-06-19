using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject fire;
    public GameObject explosion;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(0, 0, 1f);
    }

    private void OnEnable()
    {
        //GetComponent<Rigidbody>().AddForce(0, 0, 20);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "BG")
        {
            print("123");
            Destroy(gameObject);
            Instantiate(fire, transform.position, Quaternion.identity);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}