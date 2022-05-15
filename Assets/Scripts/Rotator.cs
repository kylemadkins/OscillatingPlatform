using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Controls")]

    [Tooltip("The axis around which the game object is rotating")]
    [SerializeField]
    private Vector3 axis = Vector3.up;

    [Tooltip("The speed with which the game object is rotating, measured in degrees per frame")]
    [SerializeField]
    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axis, speed);
    }
}
