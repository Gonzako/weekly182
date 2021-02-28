using UnityEngine;

public class Teleporter : BaseInteractable
{
    [Tooltip("The position to teleport the player to")]
    public Transform TeleportLocation;

    [Tooltip("If the player needs to stay on the teleporter, set to true")]
    public bool IsDelayTeleport = false;

    [Tooltip("The amount of time the player needs to stand on the teleporter")]
    public float Delay = 1f;

    private float delayTimer = 0;

    protected override void OnPlayerTriggerEnter(Player player)
    {
        delayTimer = 0;
        if (!IsDelayTeleport)
            TeleportPlayer(player);
    }

    protected override void OnPlayerTriggerExit(Player player)
    {
        delayTimer = 0;
    }

    protected override void OnPlayerTriggerStay(Player player)
    {
        delayTimer += Time.deltaTime;
        if (delayTimer > Delay)
            TeleportPlayer(player);
    }

    private void TeleportPlayer(Player player)
    {
        player.transform.position = TeleportLocation.position;
    }

    private void Start()
    {
        if (TeleportLocation == null)
            Debug.LogError("The teleporter needs to have a teleport location assigned to function correctly", this);
    }
}