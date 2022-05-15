using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Header("Movement Parameters")]

    [SerializeField]
    private Vector3 axis;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float distance;

    private Vector3 startingPosition;
    private Vector3 positiveEnd;
    private Vector3 negativeEnd;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = axis.normalized;
        startingPosition = transform.position;
        positiveEnd = startingPosition + (direction * distance);
        negativeEnd = startingPosition - (direction * distance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, positiveEnd) <= 0.01f || Vector3.Distance(transform.position, negativeEnd) <= 0.01f)
        {
            direction *= -1;
        }

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
