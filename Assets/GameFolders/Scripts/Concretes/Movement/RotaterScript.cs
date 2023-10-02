using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class RotaterScript
{
    Rigidbody _rigidbody;
    PlayController _playController;

    public RotaterScript(PlayController playController)
    {
       _playController = playController;
        _rigidbody=playController.GetComponent<Rigidbody>();
    }

    public void FixedTick(float direction)
    {
        if (direction == 0)
        {
            if (_rigidbody.freezeRotation)
            {
                _rigidbody.freezeRotation = false;
                return;
            }
        }
        if(!_rigidbody.freezeRotation)
        {
            _rigidbody.freezeRotation=true;
        }
        _playController.transform.Rotate(Vector3.back * Time.deltaTime * direction * _playController.TurnSpeed);

    }
}
