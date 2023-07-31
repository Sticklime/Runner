using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ChunkPlacer : MonoBehaviour
{
    [SerializeField] private Chunk[] ChunkPrefabs;

    private Transform _player;
    private List<Chunk> _spawnedChunks = new List<Chunk>();
    public Chunk FirstChunk;

    public void Construct(Transform player) =>
        _player = player;

    private void Start()
    {
        _spawnedChunks.Add(FirstChunk);
    }

    private void Update()
    {
        if (_player.position.x > _spawnedChunks[_spawnedChunks.Count - 1].End.position.x - 15)
            SpawnChunk();
    }

    private void SpawnChunk()
    {
        Chunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        newChunk.transform.position =
            _spawnedChunks[_spawnedChunks.Count - 1].End.position - newChunk.Begin.localPosition;
        _spawnedChunks.Add(newChunk);

        if (_spawnedChunks.Count >= 3)
        {
            Destroy(_spawnedChunks[0].gameObject);
            _spawnedChunks.RemoveAt(0);
        }
    }
}