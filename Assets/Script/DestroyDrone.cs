using UnityEngine;

public class DestroyDrone : MonoBehaviour
{
    public BoxCollider hitbox;
    public int HP = 100;
    public int Points;

    private void OnMouseDown()
    {

        Points += 50;
        HP -= 25;
        Debug.Log("Drone got hit! Drone's remaining HP: " + HP);
        Debug.Log("Your Points: " + Points);

        if (HP <= 0) 
        {
            Debug.Log("Drone destroyed!");
            Destroy(gameObject);

            return;
        }
    }
}
