using UnityEngine;

public class Player : MonoBehaviour
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"Player Was DAMAGED {damage}");
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}