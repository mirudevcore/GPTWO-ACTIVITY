using UnityEngine;

public class Grunt : Actor
{

    protected override void Awake() // lets change the HP/variables of the enemy instead of standard max health from actor
    {
        base.Awake();
        maxHealth = 50f;
        currentHealth = maxHealth;
        moveSpeed = 4f;
    }

    public override void PerformAttack()
    {
        Debug.Log("I perform BASH attack");
    }
}
