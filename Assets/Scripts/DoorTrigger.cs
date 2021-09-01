﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    [SerializeField]
    GameObject door;

    bool isOpened = false;

    void OnTriggerEnter(Collider col)
    {
        if (isOpened == false)
        {
            isOpened = true;
            door.transform.position += new Vector3(0, -7, 0);
        }
    }
}
