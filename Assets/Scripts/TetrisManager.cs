using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisManager : MonoBehaviour {

    /// <summary>
    /// 保存所有Brick的二维list
    /// </summary>
    private List<List<Brick>> tile = new List<List<Brick>>();
    /// <summary>
    /// Brick在场景中的从属节点
    /// </summary>
    [SerializeField] private Transform tileTrans;

    private void Awake()
    {
        InitBrick();
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
    /// <summary>
    /// 初始化场景中所需要的所有Brick
    /// </summary>
    private void InitBrick()
    {
        float startPosX = -(Const.BRICK_SIZE * Const.MAX_COLUMN_COUNT / 2 - Const.BRICK_SIZE / 2);
        float startPosY = -(Const.BRICK_SIZE * Const.MAX_ROW_COUNT / 2 - Const.BRICK_SIZE / 2);
        GameObject BrickPref = Resources.Load<GameObject>("Bricks/Brick");

        for (int i=0;i<Const.MAX_COLUMN_COUNT;i++)
        {
            List<Brick> row = new List<Brick>();
            for(int j=0;j<Const.MAX_ROW_COUNT;j++)
            {
                GameObject tmpBrick = Instantiate(BrickPref, tileTrans);
                if (tmpBrick != null)
                {
                    Brick b = tmpBrick.GetComponent<Brick>();
                    b.CreateBrick(startPosX + Const.BRICK_SIZE * i, startPosY + Const.BRICK_SIZE * j, new Color(1.0F, 1.0F, 1.0F), true);
                    row.Add(b);
                }
            }
            tile.Add(row);
        }
    }
}
