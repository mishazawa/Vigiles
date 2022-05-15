using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Vector3 positionOffset = Vector3.zero + Vector3.up;
    public GameObject tower;
    // Update is called once per frame
    void Update()
    {
        Vector3 moveVec   = Vector3.zero;
        Vector3 rotateVec = Vector3.zero;
        if (Input.GetKeyUp(KeyCode.W)) {
            moveVec = Constants.DIR_UP;
        }
        if (Input.GetKeyUp(KeyCode.S)) {
            moveVec = Constants.DIR_DOWN;
        }
        if (Input.GetKeyUp(KeyCode.A)) {
            moveVec = Constants.DIR_LEFT;
        }
        if (Input.GetKeyUp(KeyCode.D)) {
            moveVec = Constants.DIR_RIGHT;
        }

        if (Input.GetKeyUp(KeyCode.Q)) {
            rotateVec = Constants.ROTATE_LEFT;
        }

        if (Input.GetKeyUp(KeyCode.E)) {
            rotateVec = Constants.ROTATE_RIGHT;
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            trySupressFire();
        }

        moveGrid(moveVec * Constants.GRID_SCALE);
        rotateTower(rotateVec * Constants.ROTATE_SCALE);
    }

    void moveGrid (Vector3 dir) {
        // transform.position += dir;
        transform.position += dir;
    }

    void rotateTower (Vector3 dir) {
        tower.transform.eulerAngles += dir;
    }

    void trySupressFire() {
        var dir = -tower.transform.right;
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(dir), out hit)) {
            Debug.DrawRay(transform.position, transform.TransformDirection(dir) * hit.distance, Color.yellow);

            var house = hit.transform.gameObject.GetComponent<House>();
            if (house != null) {
                house.Supress();
            }
        }
    }
}
