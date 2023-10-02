using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript 
{

    Rigidbody _rocketRigidbody;
    

   public   MoveScript(Rigidbody rigidbody)
    {
        _rocketRigidbody = rigidbody;
    }

    public void FixedTick()
    {
        _rocketRigidbody.AddRelativeForce(Vector3.up*Time.deltaTime*75f);
    }


}
