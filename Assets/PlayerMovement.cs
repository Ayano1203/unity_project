using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;

        if (Input.GetKey("w")) {
            transform.position += new Vector3(0,1 * dt,0);
        }
        if (Input.GetKey("a")) {
            transform.position += new Vector3(-1 * dt,0,0);
        }
        if (Input.GetKey("s")) {
            transform.position += new Vector3(0,-1 * dt,0);
        }
        if (Input.GetKey("d")) {
            transform.position += new Vector3(1 * dt,0,0);
        }

    }
}
