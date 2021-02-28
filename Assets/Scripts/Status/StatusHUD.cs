using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RSG;

namespace SOInventory
{


    public class StatusHUD : MonoBehaviour
    {
        [SerializeField] private Dictionary<StatusType, StatusElement> _statusTrack;
        [SerializeField] private List<StatusElement> _usableElements;

        [SerializeField] private int amountOfElements;
        [SerializeField] private GameObject _elementFab;


        private void Start()
        {
            _usableElements = new List<StatusElement>();
            _statusTrack = new Dictionary<StatusType, StatusElement>();
            InstantiateElementPool(); 
        }

        private void OnEnable()
        {  
            Status.onCharacterGotStatus += AddIntoTrack;
            Status.onCharacterStatusEnded += RemoveFromTrack;
            Status.onCharacterStatusUpdated += UpdateHud;
        }

        private void OnDisable()
        {
            Status.onCharacterGotStatus -= AddIntoTrack;
            Status.onCharacterStatusEnded -= RemoveFromTrack;
            Status.onCharacterStatusUpdated -= UpdateHud;
        }

        private void AddIntoTrack(GameObject mortal, StatusType type, float duration)
        {
                if (mortal.tag != "Player") return;

                StatusElement el = ReturnUsableElement();
                el.gameObject.SetActive(true);
                _statusTrack.Add(type, el);
                _statusTrack[type].SetData(string.Format("{0} {1}", type.name, type.currentD));
       
        }

        private void RemoveFromTrack(GameObject mortal, StatusType type, float duration)
        {
            if (mortal.tag != "Player") return;
            _statusTrack[type].gameObject.SetActive(false);
            _statusTrack.Remove(type);
        }

        private void UpdateHud(GameObject mortal, StatusType type, float duration)
        {
            if (mortal.tag != "Player") return;

            _statusTrack[type].SetData(string.Format("{0} {1}", type.name, type.currentD));
        }

        private void InstantiateElementPool()
        {
            for(int i = 0; i < amountOfElements; i++)
            {
                GameObject go = Instantiate(_elementFab);
                go.transform.SetParent(transform);
                StatusElement el = go.GetComponent<StatusElement>();
                _usableElements.Add(el);
            }
        }

        private StatusElement ReturnUsableElement()
        {
            var promise = new Promise<StatusElement>();

            foreach(StatusElement element in _usableElements)
            {
                if (!element.gameObject.activeInHierarchy)
                {
                    return element;
                }       
            }
            return null;
        }
    }
}