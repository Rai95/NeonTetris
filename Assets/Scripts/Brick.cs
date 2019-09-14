using NeonTetris.Common;
using UnityEngine;

/// <summary>
/// 组成俄罗斯方块矩阵的基本元素，在矩阵被初始化的时候就直接在场景中生成了，在之后的游戏过程中也不再被销毁
/// </summary>
public class Brick : MonoBehaviour
{
    private Material mat = null;
    /// <summary>
    /// 砖块的颜色
    /// </summary>
    public Color BrickColor
    {
        set
        {
            if (!mat) mat = gameObject.GetComponent<SpriteRenderer>().material;
            if (mat != null) { mat.color = value; }
        }
    }
    /// <summary>
    /// 砖块的位置
    /// </summary>
    public Pos Pos
    {
        set
        {
            transform.position = new Vector3(value.posX, value.posY);
        }
    }

    /// <summary>
    /// 初始化Brick的函数
    /// </summary>
    /// <param name="posX">X方向上的位置</param>
    /// <param name="posY">Y方向上的位置</param>
    /// <param name="c">初始颜色</param>
    /// <param name="visible">是不是可见的</param>
    public void CreateBrick(float posX = 0.0f, float posY = 0.0f, Color c = new Color(), bool visible = false)
    {
        Pos = new Pos(posX, posY);
        BrickColor = c;
        gameObject.SetActive(visible);
    }

}
