using UnityEngine;

public class AIChatBot : MonoBehaviour {
    public GameObject prefab;
    public int nbObjects = 5;
    public float minX = 14.79f;
    public float maxX = 65f;
    public float minZ = -24f;
    public float maxZ = 26f;
    public float y = 0f;
    void Start() {
        for (int i = 0; i < nbObjects; i++) {
            Vector3 randomPos = new Vector3(Random.Range(minX, maxX), y, Random.Range(minZ, maxZ));
            Instantiate(prefab, randomPos, Quaternion.identity);
        }
    }
    
    void Update() {

    }
}