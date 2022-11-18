using UnityEngine;
using UnityEngine.Events;

public class TransformBehaviour : MonoBehaviour
{
    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }
}
