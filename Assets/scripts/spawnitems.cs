using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    // Uma lista/array de objetos (coloque frutas boas e bombas aqui)
    public GameObject[] spawnList; 

    // Tempo em segundos entre o surgimento de cada objeto
    public float spawnInterval = 1.2f; 

    // Limites laterais (Eixo X) e altura (Eixo Y)
    public float minX = -8.0f;
    public float maxX = 8.0f;
    public float spawnHeight = 7.0f;

    void Start()
    {
        // Executa a função de criar itens repetidamente
        InvokeRepeating("SpawnRandomItem", 0.5f, spawnInterval);
    }

    void SpawnRandomItem()
    {
        // Verifica se você colocou algum item na lista no Inspector
        if (spawnList != null && spawnList.Length > 0)
        {
            // Sorteia um índice aleatório da lista de itens
            int randomIndex = Random.Range(0, spawnList.Length);
            GameObject itemSelected = spawnList[randomIndex];

            // Escolhe uma posição X aleatória dentro dos limites
            float randomX = Random.Range(minX, maxX);
            Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0.0f);

            // Cria o item sorteado no céu
            if (itemSelected != null)
            {
                Instantiate(itemSelected, spawnPosition, Quaternion.identity);
            }
        }
    }
}