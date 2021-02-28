using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RSG;



    public class Status : MonoBehaviour
    {
        [SerializeField] List<StatusType> _characterStatuses;
        private IPromiseTimer timer;

        public delegate void StatusEvents(GameObject actor, StatusType type, float duration);
        public static StatusEvents onCharacterGotStatus;
        public static StatusEvents onCharacterStatusUpdated;
        public static StatusEvents onCharacterStatusEnded;

        private void Start()
        {
            _characterStatuses = new List<StatusType>();
            timer = new PromiseTimer();

        }

        private void Update()
        {
            timer.Update(Time.deltaTime);
        }

        public IPromise<StatusType> SetCharacterStatus(StatusType type)
        {
            var promise = new Promise<StatusType>();

            type.currentD = type.duration;
            _characterStatuses.Add(type);
            onCharacterGotStatus?.Invoke(gameObject, type, type.duration);
            type.StartStatus(gameObject);

            RunStatus(type).Done(() => {
                _characterStatuses.Remove(type);
                onCharacterStatusEnded.Invoke(gameObject, type, type.duration);
                type.Reset(gameObject);
                promise.Resolve(type);
           });
            

            return promise;    
        }

        private IPromise RunStatus(StatusType type)
        {
            var promise = new Promise();

            StartCoroutine(Cycle(type));

            return timer.WaitFor(type.duration);
        }

        private IEnumerator Cycle(StatusType type)
        {
            while (_characterStatuses.Contains(type))
            {
                yield return new WaitForSeconds(type.cycleTime);
                type.RunStatus(gameObject);
                type.currentD = Mathf.Clamp(type.currentD - 1F, 0, type.duration);
                onCharacterStatusUpdated(gameObject, type, type.cycleTime);
            }
        }

    }

    public abstract class StatusType : ScriptableObject
    {
        public string name;
        public float cycleTime;
        public float duration;
        public float currentD;


        public abstract void StartStatus(GameObject actor);

        public abstract void RunStatus(GameObject actor);

        public abstract void Reset(GameObject actor);
    }

