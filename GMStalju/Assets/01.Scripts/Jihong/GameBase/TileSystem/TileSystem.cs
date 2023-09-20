using UnityEngine;

[RequireComponent(typeof(Grid))]
public class TileSystem : MonoBehaviour
{
    public static TileSystem tileSystem;
    
    private Grid _grid;

    public float multiplied = 1;
    
    private void Start()
    {
        if (tileSystem == null)
        {
            tileSystem = this;
        }

        _grid = GetComponent<Grid>();

        multiplied = (float)_grid.cellSize.x / (float)Vector3.one.x;
    }
    
}
