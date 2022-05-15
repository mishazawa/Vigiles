using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burner : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.B)) {
            foreach (Transform obj in transform) {
                var house = obj.gameObject.GetComponent<House>();
                if (Random.value > Constants.PROBABILITY && !house.isFlame && !house.isDead) {
                    house.SetOnFire();
                    return;
                }
            }
        }
    }
}
