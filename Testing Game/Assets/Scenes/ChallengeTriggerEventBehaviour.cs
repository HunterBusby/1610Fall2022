using UnityEngine;
using UnityEngine.Events;

public class ChallengeTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerPointsEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerPointsEvent.Invoke();
    }
}
