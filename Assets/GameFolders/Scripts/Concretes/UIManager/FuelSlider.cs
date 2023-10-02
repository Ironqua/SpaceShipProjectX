using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelSlider : MonoBehaviour
{
    Slider _slider;
    FuelMechanic _fuelMechanic;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        
    }
    private void Start()
    {
        _fuelMechanic = FindObjectOfType<FuelMechanic>();
    }

    private void Update()
    {
        _slider.value = _fuelMechanic.CurrentFuel;
    }

}
