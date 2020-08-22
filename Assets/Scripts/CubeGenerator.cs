using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;

public class CubeGenerator : MonoBehaviour {

	public GameObject blockPrefab;
	public GameObject cubePrefab;
	public GameObject groundPrefab;
	public GameObject stonePrefab;
	private float delta = 0;
	private float span = 1.0f;
	private float genPosX = 12;
	private float offsetY = 3.0f;
	private float spaceY = 6.9f;
	private float offsetX = 0.5f;
	private float spaceX = 0.4f;
	private int maxBlockNum = 4;
	private float spwan = 0;

	// Use this for initialization
	void Start () {
	}


    // Update is called once per frame
    void Update()
	{
		this.delta += Time.deltaTime;
		this.spwan += Time.deltaTime;
		if(spwan > 5)
        {
			if (this.delta > this.span)
			{
				this.delta = 0;
				int n = Random.Range(1, maxBlockNum);
				for (int i = 0; i < n; i++)
				{
					int spwan = Random.Range(1, 10);
					if (spwan == 1)
					{
						GameObject stone = Instantiate(blockPrefab) as GameObject;
						stone.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
					} else if(spwan == 2)
                    {
						GameObject Stone1 = Instantiate(stonePrefab) as GameObject;
						Stone1.transform.position = new Vector2(13.0f, -1.0f);
						GameObject Stone2 = Instantiate(stonePrefab) as GameObject;
						Stone2.transform.position = new Vector2(13.5f, -1.0f);
					} else if (spwan == 3){
						GameObject Ground1 = Instantiate(groundPrefab) as GameObject;
						Ground1.transform.position = new Vector2(13.0f, -1.0f);
						GameObject Ground2 = Instantiate(groundPrefab) as GameObject;
						Ground2.transform.position = new Vector2(13.0f, -1.0f);
						GameObject Ground3 = Instantiate(groundPrefab) as GameObject;
						Ground3.transform.position = new Vector2(13.0f, -1.0f);
					} 
					else
					{
						GameObject go = Instantiate(cubePrefab) as GameObject;
						go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
					}
				}
					this.span = this.offsetX + this.spaceX * n;
			}
	
		}

    }

}

