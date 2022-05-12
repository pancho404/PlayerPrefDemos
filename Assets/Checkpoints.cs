using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{

    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Checkpoint"))
        {
            player.transform.position = transform.position;
        }
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        PlayerPrefs.SetInt("Checkpoint", 1);
        Debug.Log("CHECKPOINTEADO");
    }

}
