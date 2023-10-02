using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class WallController : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;
    [SerializeField] GameObject explosion;
    float effectduraction = 1f;


    private void OnCollisionEnter(Collision collision)
    {
        PlayController player=collision.collider.GetComponent<PlayController>();
        if (player != null)
        {
            //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
          //  GameManager.Instance.GameOver();
            _gameOverPanel.SetActive(true);
           
            Destroy(player.gameObject);
            effects();
            
        }
         void effects()
        {
            GameObject effect = Instantiate(explosion, player.transform.position, Quaternion.identity, transform.parent);
            Destroy(effect, effectduraction);
        }
    }
}
