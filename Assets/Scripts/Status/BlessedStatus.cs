using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOInventory
{
    [CreateAssetMenu(fileName = "BlessedStatus", menuName = "Create/BlessedStatus")]
    public class BlessedStatus : StatusType
    {
        public override void RunStatus(GameObject actor)
        {
            
        }

        public override void Reset(GameObject actor)
        {
            actor.GetComponentInChildren<Rigidbody>().mass = 1;
        }

        public override void StartStatus(GameObject actor)
        {
            actor.GetComponentInChildren<Rigidbody>().mass = 100;
        }
    }
}
