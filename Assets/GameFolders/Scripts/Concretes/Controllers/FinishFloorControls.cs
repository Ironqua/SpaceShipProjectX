using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishFloorControls : MonoBehaviour
{
    [SerializeField] GameObject _finishParticle;
    [SerializeField] GameObject _winPanel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Finish");
            _finishParticle.SetActive(true);
            GameManager.Instance.MissionSucced();
            _winPanel.SetActive(true);
        }
        else
        {
            GameManager.Instance.GameOver();
        } 
    }





}
