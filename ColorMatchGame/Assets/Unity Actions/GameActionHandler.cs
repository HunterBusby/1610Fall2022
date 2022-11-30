using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction GameActionObj;
    public UnityEvent OnRaiseEvent;
    private void Start()
    {
        GameActionObj.raise +=Raise;
    }

    private void Raise()
    {
        OnRaiseEvent.Invoke();
    }
}
