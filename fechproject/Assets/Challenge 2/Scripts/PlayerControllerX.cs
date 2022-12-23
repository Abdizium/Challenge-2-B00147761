using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float waitime = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && waitime <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            waitime = 1;

        }
        if (waitime >= 0) {
            waitime -= Time.deltaTime;
        }
    }
}
 