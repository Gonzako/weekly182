using UnityEngine;

public class WindTurbine : BaseInteractable
{
    [Tooltip("Will apply this amount of force in the direction to the player")]
    public float ForceMagnitude;

    private Rigidbody playerRigidBody;

    protected override void OnPlayerTriggerEnter(Player player)
    {
        if (playerRigidBody == null)
            playerRigidBody = player.GetComponent<Rigidbody>();
    }

    protected override void OnPlayerTriggerExit(Player player)
    {
        return;
    }

    protected override void OnPlayerTriggerStay(Player player)
    {
        playerRigidBody.AddForce(transform.forward*ForceMagnitude, ForceMode.Force);
    }
}