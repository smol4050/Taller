using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoor : MonoBehaviour
{
    [SerializeField] private float moveAmount;
    [SerializeField] private float duration;

    [SerializeField] private Vector3 startPos;
    [SerializeField] private Vector3 endPos;

    private void Awake()
    {
        startPos = transform.localPosition;
    }
}
