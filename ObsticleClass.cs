using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleClass : MonoBehaviour
{
    public float objectSpeed;

    public float minSpeed = 2;
    public float maxSpeed = 6;

    [SerializeField]
    public Rigidbody2D rb; 
}
