using UnityEngine;

public class PigMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    float traveledDistance = 0;
    void Update()
    {
        float dt = Time.deltaTime;
        
        Vector3 move = new Vector3(1*dt,0,0);
        transform.position += move;   
        //transform.position += new Vector3(-5,0,0);   

        traveledDistance += move.magnitude;

        if (traveledDistance > 10)
        {
            transform.position = new Vector3(0,0,0);
        }
    
    }
}
