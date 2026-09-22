using UnityEngine;

public class DestroyDrone : MonoBehaviour
{
    public BoxCollider hitbox;
    public int HP = 100;


    private void OnEnable()
    {
        Debug.Log("Drones ready.");
    }

    private void OnDisable()
    {
        Debug.Log("No target found");
    }

    private void OnMouseDown()
    {
        HP -= 25;
        Debug.Log("Drone got hit! Drone's remaining HP: " + HP);

        if (PointsManager.Instance != null)
        {
            PointsManager.Instance.IncreasePoints(50);
        }

        if (HP <= 0)
        {
            Debug.Log("Drone destroyed!");

            Destroy(gameObject);
            return;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (PointsManager.Instance != null)
        {
            PointsManager.Instance.IncreasePoints(-25);
            Debug.Log("Drone entered the Hazard Zone!");
        }
    }

}
