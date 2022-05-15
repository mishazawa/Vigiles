using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{
    public static float   GRID_SCALE = 4;
    public static Vector3 DIR_UP     = new Vector3( 0, 0,  1);
    public static Vector3 DIR_DOWN   = new Vector3( 0, 0, -1);
    public static Vector3 DIR_LEFT   = new Vector3(-1, 0,  0);
    public static Vector3 DIR_RIGHT  = new Vector3( 1, 0,  0);

    public static float   ROTATE_SCALE = 90;
    public static Vector3 ROTATE_RIGHT = new Vector3(0, 1,  0);
    public static Vector3 ROTATE_LEFT  = new Vector3(0, -1, 0);

    public static float BURN_TIME_MAX = 5;
    public static float PROBABILITY   = .25f;
}
