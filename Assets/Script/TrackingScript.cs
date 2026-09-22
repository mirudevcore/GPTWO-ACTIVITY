using UnityEngine;

public class TrackingScript : MonoBehaviour

{
    public float rotationSpeed;
    public Transform target;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 dir = (target.position - transform.position ).normalized;
        Quaternion targetRot = Quaternion.LookRotation(dir);
        transform.rotation =  Quaternion.Slerp (transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
        float dot = Vector3.Dot(transform.forward, dir);

        
    }
}
