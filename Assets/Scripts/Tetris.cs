using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NeonTetris.Common;

/// <summary>
/// 表示一块俄罗斯方块的类
/// </summary>
public class Tetris : MonoBehaviour {

    /// <summary>
    /// 方块的中心砖块
    /// </summary>
    private Brick centerBrick;
    /// <summary>
    /// 中心砖块的位置，也代表整个方块的位置
    /// </summary>
    private PosPair pos;
    /// <summary>
    /// 附属的砖块，位置由中心砖块位置和自身偏移量决定
    /// </summary>
    private Brick[] subBricks;
    /// <summary>
    /// 附属砖块相对于中心砖块的位置偏移量
    /// </summary>
    private PosPair[] subOffset;
    /// <summary>
    /// 方块现在的朝向
    /// </summary>
    private Direction facing;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
