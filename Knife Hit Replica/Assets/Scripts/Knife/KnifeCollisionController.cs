using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnifeCollisionController : MonoBehaviour
{
    [SerializeField] private KnifeDataTransmitter knifeDataTransmitter;
    [SerializeField] private KnifeSpawnController knifeSpawnController;
    private void Start()
    {
        knifeSpawnController = FindObjectOfType<KnifeSpawnController>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Circle"))
        {
            knifeDataTransmitter.setKnifeMovementForce(0);
            transform.SetParent(other.gameObject.transform);
            knifeSpawnController.IncreaseActiveKnifeIndex(1);
            knifeSpawnController.SetKnifeIconDisableColor(1);

        }
        if (other.gameObject.CompareTag("Knife"))
        {
            SceneManager.LoadScene(0);
        }

    }
}
