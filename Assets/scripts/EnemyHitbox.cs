using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable
{
   public int damage;
   public float pushForce;

    protected override void OnCollide(Collider2D coll){
        if (coll.tag == "FIGHTER" && coll.name == "PLAYER"){
               
            Damage dmg = new Damage{ 
                damageAmount = damage,
                origin = transform.position,
                pushForce = pushForce
            };
            coll.SendMessage("ReceiveDamage",dmg); 
        }

    }


}
