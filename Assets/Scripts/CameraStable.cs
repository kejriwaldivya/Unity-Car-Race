using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject car;
    public float Xpos;
    public float Ypos;
    public float Zpos;

	void Update () {
        Xpos = car.transform.eulerAngles.x;
        Ypos = car.transform.eulerAngles.y;
        Zpos = car.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(Xpos - Xpos, Ypos, Zpos - Zpos);
    }
}
