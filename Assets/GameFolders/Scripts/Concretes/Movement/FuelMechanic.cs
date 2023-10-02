using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelMechanic : MonoBehaviour
{
    [SerializeField] float _maxfuel = 100f;
    [SerializeField] float _currentfuel;
    [SerializeField] ParticleSystem _particleSystem;

    public float CurrentFuel => _currentfuel / _maxfuel;
    public bool IsEmpty => _currentfuel < 1f;
   
    private void Awake()
    {
        _currentfuel = _maxfuel;
    }

    public void IncreaseFuel(float increase)
    {
        _currentfuel += increase;
        _currentfuel = Mathf.Min(_currentfuel, _maxfuel);
          if (_particleSystem.isPlaying)
            {
            Invoke("ActivateParticleSystem", 0.5F);
            }
        }
    private void ActivateParticleSystem()
    {
      
        _particleSystem.gameObject.SetActive(false);
    }

    public void DecreaseFuel(float decrease)
    {
        _currentfuel -= decrease;
        _currentfuel = Mathf.Max(_currentfuel, 0f);

        if (_particleSystem.isStopped)
        {
            _particleSystem.gameObject.SetActive(true);

        }
    }
}
