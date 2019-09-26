using UnityEngine;
using NeonTetris.Common;

public class Brick : MonoBehaviour
{
    private Material mat = null;
    public Color BrickColor
    {
        set
        {
            if (!mat) mat = GetComponent<Material>();
            if (mat) mat.color = value;
        }
    }

    public bool taken = false;

    public void InitBrick(Position pos,Color color)
    {
        transform.position = new Vector3(pos.x, pos.y, 0);
        BrickColor = color;
    }
}
