using System;
using System.Collections.Generic;
using UnityEngine;
using NeonTetris.Common;
using UnityEngine.UI;

public class TetrisManager : MonoBehaviour
{
    private static TetrisManager instance = null;
    public static TetrisManager GetInstance
    {
        get
        {
            if (!instance)
            {
                instance = FindObjectOfType<TetrisManager>();
                if (!instance)
                {
                    GameObject newManger = new GameObject("TetrisManager");
                    instance = newManger.AddComponent<TetrisManager>();
                }
            }
            return instance;
        }
    }

    private List<List<Brick>> tile = new List<List<Brick>>();

    public Button btn;

    private void Awake()
    {
        if(!instance)
        {
            instance = this;
            gameObject.name = "TetrisManager";
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Initialize();
    }

    void Update()
    {

    }

    void Initialize()
    {
        float startPosX = -(Const.BRICK_SIZE * Const.MAX_COLUMN_COUNT / 2 - Const.BRICK_SIZE / 2);
        float startPosY = -(Const.BRICK_SIZE * Const.MAX_ROW_COUNT / 2 - Const.BRICK_SIZE / 2);
        GameObject brickPref = Resources.Load<GameObject>(Const.BRICK_PREFAB_PATH);
        if (!brickPref) return;

        for(int i=0;i< Const.MAX_ROW_COUNT;i++)
        {
            List<Brick> row = new List<Brick>();
            for (int j=0;j<Const.MAX_COLUMN_COUNT;j++)
            {
                GameObject brick = Instantiate(brickPref, transform);
                if(brick!=null)
                {
                    Brick b = brick.GetComponent<Brick>();
                    b.InitBrick(new Position(startPosX + Const.BRICK_SIZE * j, startPosY + Const.BRICK_SIZE * i), new Color(1.0F, 1.0F, 1.0F));
                    b.BrickColor = Color.blue;
                    row.Add(b);
                }
            }
            tile.Add(row);
        }
    }
}
