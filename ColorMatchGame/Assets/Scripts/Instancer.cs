using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    
    public void CreateInstance(GameObject obj)
    {
        Instantiate(obj);
    }
    
    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreatInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.Vector3DList)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }
    
    public void CreatInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.Vector3DList[num].value, Quaternion.identity);
        num++;
        if (num == obj.Vector3DList.Count)
        {
            num = 0;
        }
    }
    
    public void CreatInstanceListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.Vector3DList.Count - 1);
        Instantiate(prefab, obj.Vector3DList[num].value, Quaternion.identity);
    }

}
