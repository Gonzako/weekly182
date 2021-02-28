using UnityEngine;

public class Trap : BaseInteractable
{
    [Tooltip("The damage the player will take")]
    public int Damage = 10;

    [Tooltip("The time in seconds before the player is damaged again")]
    public float DamageDelay = 2f;

    private float hitTimer = 0;

    protected override void OnPlayerTriggerEnter(Player player)
    {
        hitTimer = 0;
        hitTimer += Time.deltaTime;
    }

    protected override void OnPlayerTriggerExit(Player player)
    {
        HandlePlayerDamage(player);
    }

    protected override void OnPlayerTriggerStay(Player player)
    {
        HandlePlayerDamage(player);
    }

    private void HandlePlayerDamage(Player player)
    {
        hitTimer += Time.deltaTime;
        if (hitTimer > DamageDelay)
        {
            hitTimer = 0;
            player.TakeDamage(Damage);
        }
    }
}