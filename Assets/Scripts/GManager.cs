using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour {
    [System.NonSerialized]
    public int stageNum = 0;
    public static GManager instance = null;
    public int score = 0;
    public int life = 3;
    public float runLength;
    public bool isGameOver = false;
    public GameObject unityChan;
    public float gaugeMax = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
