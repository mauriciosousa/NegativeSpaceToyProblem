using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

    static GameObject lastCubeMoved;
    public GameObject onTopOf = null;

    public void GoTo(Vector3 position)
    {
        transform.position = position;
        lastCubeMoved = this.gameObject;
    }

    void OnTriggerEnter(Collider col)
    {
        if (lastCubeMoved == this.gameObject && Checkerboard.isCube(col.gameObject))
        {
            onTopOf = col.gameObject;
            GoTo(transform.position + new Vector3(0, Checkerboard.moveUp * 2.0f, 0));
        }
    }

    internal string initPosition()
    {
        return name + " ontopof " + onTopOf.name;
    }
}
