using UnityEngine;

public class Runner : Actor
{

    protected override void Awake() // lets change the HP/variables of the enemy instead of standard max health from actor
    {
        base.Awake();
        maxHealth = 50f;
        currentHealth = maxHealth;
        moveSpeed = 6f;
    }

    public override void PerformAttack()
    {
        Debug.Log("Speed attacks you");
    }
}
