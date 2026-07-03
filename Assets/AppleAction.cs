using UnityEngine;

public class AppleAction : MonoBehaviour
{
    //public Transform playerTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 difference = transform.position - playerTransform.position;
        // if (difference.magnitude < 0.5){
        //     Debug.Log("Touched"); 
        // }
    }
    void OnTriggerEnter2D (Collider2D col)
    {
        Debug.Log ("Touched");
        Destroy(gameObject);
    }
}
