using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] countryBallPrefabs;

    void Start()
    {
        int rastgeleIndex = Random.Range(0, countryBallPrefabs.Length);
        Instantiate(countryBallPrefabs[rastgeleIndex], new Vector3(0, 1, 0), Quaternion.identity);
    }
}
