using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float angle;
    [SerializeField] private float thickness;
    [SerializeField] private float rInner;
    [SerializeField] private float rOuter;
    private void Awake()
    {
       Init();
    }

    private void Init()
    {
        CreateShape();
    }

    private void CreateShape()
    {
        
    }
}
