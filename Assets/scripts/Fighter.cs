using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public int hitpoint;
    public int maxHitpoint;
    public float pushRecoverSpeed;


    protected float immuneTime = 1.0f;
    private float LastImmune;

    protected Vector3 pushDirection;


    protected virtual void ReceiveDamage(Damage dmg)
    {
        if (Time.time - LastImmune > immuneTime)
        {
            LastImmune = Time.time;
            hitpoint -= dmg.damageAmount;
            pushDirection = (transform.position - dmg.origin).normalized * dmg.pushForce;
            if (hitpoint <=0){
                hitpoint = 0;
                Death ();
            }
    }
}    
    protected virtual void Death(){


    }
}