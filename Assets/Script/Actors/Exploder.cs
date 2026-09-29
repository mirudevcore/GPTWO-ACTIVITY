using UnityEngine;

public class Exploder : Actor
{

    public float explosionRadius = 5f;

    public override void PerformAttack()
    {
        Explode();
    }

    public override void TakeDamage(float damageAmount) 
    {
        Explode();
    }

    public void Explode()
    {
        Debug.Log("BOOOOOM!");
        Destroy(gameObject);
    }

}
