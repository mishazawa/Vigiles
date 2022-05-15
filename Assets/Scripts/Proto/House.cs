using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public bool isFlame = false;
    public bool isDead  = false;

    public void SetOnFire () {
        isFlame = true;
        applyMat();
        StartCoroutine(burn());
    }

    public void Supress() {
        isFlame = false;
    }

    IEnumerator burn() {
        var timePass = 0f;
        while (isFlame && timePass < Constants.BURN_TIME_MAX) {
            timePass += Time.deltaTime;
            yield return null;
        }

        isDead = isFlame; // true or false;
        applyMat();
    }

    void applyMat () {
        var rend = gameObject.GetComponent<Renderer>();
        if (isDead) {
            rend.material.color = Color.black;
            return;
        }
        if (isFlame) {
            rend.material.color = Color.red;
            return;
        }
        rend.material.color = Color.white;
    }
}
