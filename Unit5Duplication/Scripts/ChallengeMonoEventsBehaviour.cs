using UnityEngine;
using UnityEngine.Events;

public class ChallengeMonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent mouseOverEvent, mousedownEvent, mouseExitEvent;

    private void OnMouseDown()
    {
        mousedownEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }
    
    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }
}
