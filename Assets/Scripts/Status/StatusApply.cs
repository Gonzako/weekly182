using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOInventory {
    public class StatusApply : MonoBehaviour
    {
        [SerializeField] private StatusType type;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Status status;
            if(collision.transform.TryGetComponent(out status))
            {
                Debug.Log("Apply");
                StatusType newStatus = Instantiate(type);
                status.SetCharacterStatus(newStatus).
                    Then((StatusType type) => Debug.Log(type.name + "Completed"));
            }
        }
    }
}
