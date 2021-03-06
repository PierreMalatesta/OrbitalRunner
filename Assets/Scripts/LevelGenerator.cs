using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform[] LevelParts;

    private void Awake()
    {
        SpawnChunk(124);
        SpawnChunk(195);
    }

  /// <summary>
  /// Spawns random prefabs
  /// </summary>
  /// <param name="x">'X' is always randomised</param>
    private void SpawnChunk(float x)
    {
        int index = Random.Range(0, LevelParts.Length);
        Instantiate(LevelParts[index], new Vector3(x, 10, -13), Quaternion.identity);
    }
}
