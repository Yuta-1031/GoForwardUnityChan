using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class CubeGenerator : MonoBehaviour {

	public GameObject stonePrefab;
	public GameObject cubePrefab;
	private float delta = 0;
	private float span = 1.0f;
	private float genPosX = 12;
	private float offsetY = 2.0f;
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
					int spwan = Random.Range(1, 7);
					if (spwan == 1)
					{
						GameObject stone = Instantiate(stonePrefab) as GameObject;
						stone.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);

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

