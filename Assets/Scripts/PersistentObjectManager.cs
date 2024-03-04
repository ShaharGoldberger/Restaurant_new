using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//implement singleton
public class PersistentObjectManager : MonoBehaviour
{
    public static PersistentObjectManager instance = null;
    private static int gold=0;
    public GameObject Player;
    private static Vector3 SpawnPointPosition;//= new Vector3();
    public static bool isCoinActive = true;
    public GameObject coin;
    public Text goldText; 
    private void Awake() //runs before start
    {
        //for the first time
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            if(SceneManager.GetActiveScene().buildIndex == 0)
            {
                Player.transform.position = SpawnPointPosition;
                Player.transform.Rotate(new Vector3(0, 0, 0));
            }
            Destroy(gameObject);

        }
        DontDestroyOnLoad(gameObject); //in any case
        goldText.text = "Gold" + gold;//update text
        coin.SetActive(isCoinActive);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGold(int g)
    {
        gold = g;
    }

    public void setSpawnPointPos(Vector3 pos)
    {
        SpawnPointPosition = pos;
    }

  
}
