using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController player;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3();
        movement.x = -v * speed;

        player.SimpleMove(movement);
    }
}
