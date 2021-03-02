using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface : MonoBehaviour
{
    [SerializeField] private SurfaceTypes surface;

    public SurfaceTypes GetSurface => surface;
}


public enum SurfaceTypes {Wood=0, Metal=1}