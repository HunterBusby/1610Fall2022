using UnityEngine;

[CreateAssetMenu]
public class ChallengeIntData : ScriptableObject
{
    public int points;

    public void UpdatePoints(int integer)
    {
        points += integer;
    }
}
