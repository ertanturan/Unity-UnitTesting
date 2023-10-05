using UnityEngine;

public class UnityComponentSpawner : MonoBehaviour
{
	public GameObject SpawnPrefab(GameObject prefab, Vector3 position)
	{
		return Instantiate(prefab, position, Quaternion.identity);
	}
}