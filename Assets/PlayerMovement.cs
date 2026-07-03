using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;

    void Start() {
        // put player at position
        transform.position = new Vector3(0, 0, 0);
    }

    float distanceTraveled = 0;
    void Update() {
        float dt = Time.deltaTime;
        // * dt == per second

        Vector3 move = new Vector3(0, 0, 0);
        if (Input.GetKey("w")) {
            move += Vector3.up;
        }
        if (Input.GetKey("a")) {
            move += Vector3.left;
        }
        if (Input.GetKey("s")) {
            move += Vector3.down;
        }
        if (Input.GetKey("d")) {
            move += Vector3.right;
        }
        move = move * speed * dt;
        distanceTraveled += move.magnitude;
        transform.position += move;
    }
}