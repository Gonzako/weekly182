using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseRotator : MonoBehaviour
{
    [SerializeField]
    PlayerInputAssets playerInputs;

    [SerializeField]
    public Transform playerRef;

    public float moveAmount = 0.2f;
    public float maxAngle = 80;
    

    private Vector2 desiredDelta = Vector2.zero;


    // Start is called before the first frame update
    void Start()
    {
        playerInputs = new PlayerInputAssets();
        playerInputs.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        desiredDelta += playerInputs.GameWorld.DesiredDelta.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        transform.RotateAround(playerRef.position, new Vector3(desiredDelta.y,0, desiredDelta.x).normalized, desiredDelta.magnitude*moveAmount);
        //var desiredRotation = transform.rotation * Quaternion.Euler(desiredDelta.y*moveAmount, desiredDelta.x*moveAmount,0);

        //transform.rotation = desiredRotation;

        desiredDelta = Vector2.zero;
    }


}
