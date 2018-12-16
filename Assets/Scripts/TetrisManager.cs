using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisManager : MonoBehaviour {

    private List<List<Brick>> tile = new List<List<Brick>>();

    private void Awake()
    {

    }

    // Use this for initialization
    void Start () {
        Initialize();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Initialize()
    {

    }

    private void InitBrick()
    {
        for(int i=0;i<Const.MAX_COLUMN_COUNT;i++)
        {
            List<Brick> row = new List<Brick>();
            for(int j=0;j<Const.MAX_ROW_COUNT;j++)
            {
                Brick b = new Brick();
                row.Add(b);
            }
            tile.Add(row);
        }
    }
}
