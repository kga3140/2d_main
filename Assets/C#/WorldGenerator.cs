using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldGenerator : MonoBehaviour
{

	//Map settings
	public int width = 200;
	public int height = 100;
	public int seed = 0;
	public float surfaceScale = 20f;
	public float caveScale = 15f;

	//Height settiings
	public int baseHeight = 40;
	public int mountainHeight = 35;

	public float caveThreshold;

	public Tilemap groundTilemap;
	public Tilemap caveTilemap;

	public TileBase grassTile;
	public TileBase dirtTile;
	public TileBase stoneTile;
	public TileBase mountineTile;

	private System.Random random;


	void Start()
	{
		if (seed == 0)
		{
			seed = Random.Range(-1000000, 1000000);
		}
		random = new System.Random(seed);
		GenerateWorld();
	}

	public void ChangeSeed()
	{

		seed = Random.Range(-1000000, 1000000);

		random = new System.Random(seed);
	}

	public void GenerateWorld()
	{
		groundTilemap.ClearAllTiles();
		caveTilemap.ClearAllTiles();

		for (int x = 0; x < width; x++)
		{
			float noise = Mathf.PerlinNoise((x + seed) / surfaceScale, 0);
			int terrainHeight = Mathf.FloorToInt(noise * mountainHeight) + baseHeight;

			for (int y = 0; y < height; y++)
			{
				if (y > terrainHeight)
				{
					continue;
				}

				Vector3Int pos = new Vector3Int(x, y, 0);
				if (y == terrainHeight)
				{
					groundTilemap.SetTile(pos, grassTile);
				}
				else if (y > terrainHeight - 4)
				{
					groundTilemap.SetTile(pos, dirtTile);
				}
				else
				{
					groundTilemap.SetTile(pos, stoneTile);

					GenerateCave(x, y, pos);
				}
			}
		}
	}

	void GenerateCave(int x, int y, Vector3Int pos)
	{
		float caveNoise = Mathf.PerlinNoise((x + seed) / caveScale, (y + seed) / caveScale);
		if (caveNoise > caveThreshold)
		{
			groundTilemap.SetTile(pos, null);
		}
	}
}

