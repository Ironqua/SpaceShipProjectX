using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayController : MonoBehaviour
{
   InputManager _inputManager;
   MoveScript _moveScript;
    RotaterScript _rotateScript;
    FuelMechanic _fuelMechanic;

    bool _canMove;
    bool _ýsForceUp;
    float _leftright;
    public float TurnSpeed;


    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += HandleOnEventTrigger;
        GameManager.Instance.OnMissionSucced += HandleOnEventTrigger;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver-= HandleOnEventTrigger; 
        GameManager.Instance.OnMissionSucced -= HandleOnEventTrigger;
    }
    private void Awake()
    {
        Reference();
    }

    private void Start()
    {
        _canMove = true;
        Init();
    }

    private void Update()
    {
        if (!_canMove) return;
        Debug.Log(_inputManager.IsForceUp);
        Debug.Log(_inputManager.pressLeftRight);

        if (_inputManager.IsForceUp&& !_fuelMechanic.IsEmpty) 
        {
        _ýsForceUp = true;
        }
       else
        {
            _ýsForceUp = false;
            _fuelMechanic.IncreaseFuel(0.01f);

        }
        _leftright = _inputManager.pressLeftRight;
    }



    private void FixedUpdate()
    {
         if (_ýsForceUp)
        {   
         _moveScript.FixedTick();
            _fuelMechanic.DecreaseFuel(0.2f);
        
        }

        _rotateScript.FixedTick(_leftright);
    }

   private void HandleOnEventTrigger()
    {
        _canMove = false;
        _ýsForceUp = false;
        _leftright = 0f;
        _fuelMechanic.IncreaseFuel(0f);

    }
    private void Reference()
    {
      
    }
    private void Init()
    {
        _inputManager = new InputManager();
        _moveScript = new MoveScript(rigidbody:GetComponent<Rigidbody>());
        _rotateScript = new RotaterScript(this); // different object 
        _fuelMechanic=GetComponent<FuelMechanic>(); // same object req
    }
}
