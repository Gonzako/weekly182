﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class momentumSetter : MonoBehaviour
{
    [SerializeField]
    Rigidbody target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = target.velocity;
    }
}
