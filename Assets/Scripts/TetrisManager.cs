using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonTetris.Common;

public class TetrisManager : MonoBehaviour {

    /// <summary>
    /// 保存所有Brick的二维list
    /// </summary>
    private List<List<Brick>> tile = new List<List<Brick>>();
    /// <summary>
    /// Brick在场景中的从属节点
    /// </summary>
    [SerializeField] private Transform tileTrans;
    /// <summary>
    /// 回合间隔时间
    /// </summary>
    private float tickInterval = Const.DEFAULT_TICK_INTERVAL;
    /// <summary>
    /// 当前的回合时间
    /// </summary>
    private float curTickTime = 0.0f;
    /// <summary>
    /// 当前的活动块
    /// </summary>
    private TetrisBase activeTetris;

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
        curTickTime += Time.deltaTime;
        if(curTickTime>=tickInterval)
        {
            RunTick();
            curTickTime = 0.0f;
        }
	}
    /// <summary>
    /// 对TetrisManager类进行初始化
    /// </summary>
    private void Initialize()
    {
        tickInterval = Const.DEFAULT_TICK_INTERVAL;
        curTickTime = 0.0f;
    }
    /// <summary>
    /// 进行一个回合
    /// </summary>
    private void RunTick()
    {

    }
    /// <summary>
    /// 初始化场景中所需要的所有Brick
    /// </summary>
    private void InitBrick()
    {
        float startPosX = -(Const.BRICK_SIZE * Const.MAX_COLUMN_COUNT / 2 - Const.BRICK_SIZE / 2);
        float startPosY = -(Const.BRICK_SIZE * Const.MAX_ROW_COUNT / 2 - Const.BRICK_SIZE / 2);
        GameObject BrickPref = Resources.Load<GameObject>(ResPath.BrickPref);

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
                    b.BrickColor = Color.blue;
                    row.Add(b);
                }
            }
            tile.Add(row);
        }
    }
    /// <summary>
    /// 检查某一砖块是否可以向某一方向移动
    /// </summary>
    /// <param name="b">要检查的砖块</param>
    /// <param name="drct">要移动的方向</param>
    /// <returns></returns>
    bool IsMoveable(Brick b,Direction drct)
    {
        return false;
    }
}
