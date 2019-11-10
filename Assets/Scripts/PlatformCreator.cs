
using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    [Header("[Prefabs]")]
    public GameObject regularPlaform;
    public GameObject[] specialPlatforms;

    [Header("[Settings]")]
    [Range(0,100)]
    public int specialPlatformPercentage;
    void Start()
    {

        for(int i=0;i<4;i++)
        {
            int randomPercentage = Random.Range(0, 100);
            int randomSpecialPlatformIndex = Random.Range(0, specialPlatforms.Length);

            GameObject objectToBeCreated;
            objectToBeCreated = randomPercentage < specialPlatformPercentage ? specialPlatforms[randomSpecialPlatformIndex] : regularPlaform;

            GameObject platform = Instantiate(objectToBeCreated, transform.GetChild(i).position, transform.GetChild(i).rotation);
            platform.transform.SetParent(transform.GetChild(i));
            
        }
        Debug.Log(transform.lossyScale.normalized.z);
        
    }


}
