using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject flagPrefab;
    public GameObject hitEffectPrefab;
    public Sprite[] flagSprites;

    public Transform spawnArea;
    public Text scoreText;

    private int score = 0;

    void Awake() => Instance = this;
    void Start()
    {
        SpawnAllFlags();
    }
    void SpawnAllFlags()
    {
        //Oyuncu
        GameObject player = SpawnFlag("tr", new Vector2(-3, 0));
        player.GetComponent<FlagController>().isPlayer = true;
        //Rakipler
        string[] others = new string[] { "de", "fr", "it", "us", "br", "cn", "jp" };
        foreach (string c in others)
        {
            Vector2 pos = new Vector2(Random.Range(1f, 4f), Random.Range(-2f, 2f));
            SpawnFlag(c,pos);
        }
    }
    GameObject SpawnFlag(string country,Vector2 pos)
    {
        GameObject flag = Instantiate(flagPrefab, pos, Quaternion.identity);
        flag.name = country;
        flag.GetComponent<FlagController>().country = country;

        Sprite sprite =System.Array.Find(flagSprites,x=>x.name == country);
        if (sprite != null)
        {
            flag.GetComponent<SpriteRenderer>().sprite = sprite;
            return flag;
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = $"Skor:{score}";
    }
}


