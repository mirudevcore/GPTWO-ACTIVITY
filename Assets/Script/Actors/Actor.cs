using UnityEngine;

public abstract class Actor : MonoBehaviour
{
    //ABSTRACT: prevents anyone from accidentally
    //attaching this script to any game object
    [Header("Base Actor Attributes")]
    [SerializeField] protected float maxHealth = 100f;
    [SerializeField] protected float moveSpeed = 3f;
    [SerializeField] protected float Damage = 3f;

    //instead if private, keeps maxhealth hidden from unrelated outside scriptm wguke allowing child to read and adjust this (private: only you can, child parent cant change them)
    protected float currentHealth;

    //We mark awake as virtual, ensures child classes can initialize their own variable in their own awake
    protected virtual void Awake()
    {
        currentHealth = maxHealth;
    }

    // every enemy attacks differntly, its abstract to let them have different aattak
    public abstract void PerformAttack();
    //
    public virtual void TakeDamage(float damageAmount)
    { 
        currentHealth -= damageAmount;
        Debug.Log($"{gameObject.name} took {damageAmount}");
    }

    protected virtual void Die()
    {
        Debug.Log($"{gameObject.name} has died.");
        Destroy(gameObject);
    }
    private void Start()
    {
        
    }
}
