// EnemySpawner.cs
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // 1. R�f�rence au Prefab de l'ennemi
    // Faites glisser votre Prefab "Enemy" depuis la fen�tre Project ici dans l'Inspecteur
    public GameObject enemyPrefab;

    // Optionnel: pour la fonction Initialize de l'ennemi
    public Transform playerTransform; // Faites glisser le GameObject du joueur ici

    void Start()
    {
        // Exemple: Faire appara�tre un ennemi au d�marrage
        SpawnEnemy();

        // Trouver le joueur automatiquement si non assign� (alternative)
        if (playerTransform == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player"); // Assurez-vous que votre joueur a le tag "Player"
            if (playerObject != null)
            {
                playerTransform = playerObject.transform;
            }
            else
            {
                Debug.LogWarning("Spawner: Impossible de trouver le joueur avec le tag 'Player'");
            }
        }
    }

    void Update()
    {
        // Exemple: Faire appara�tre un ennemi en appuyant sur Espace
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        if (enemyPrefab == null)
        {
            Debug.LogError("Enemy Prefab non assign� dans l'EnemySpawner !");
            return;
        }

        // 2. D�terminer la position d'apparition
        Vector3 spawnPosition = transform.position; // Appara�t � la position du Spawner
        // Ou une position al�atoire proche:
        // spawnPosition += new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0);

        Debug.Log($"Tentative d'apparition d'un ennemi � {spawnPosition}");

        // 3. Instancier (cr�er une copie) du Prefab
        // Quaternion.identity signifie "pas de rotation"
        GameObject newEnemyObject = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        newEnemyObject.name = "Enemy_" + Time.time; // Donne un nom unique (optionnel)

        // --- C'est ici qu'on appelle les fonctions ---

        // 4. Obtenir une r�f�rence au script Enemy sur le nouvel objet cr��
        Enemy enemyScript = newEnemyObject.GetComponent<Enemy>();

        // 5. V�rifier si le script a �t� trouv� et appeler ses fonctions
        if (enemyScript != null)
        {
            Debug.Log("Script Enemy trouv� sur l'instance, appel des fonctions...");

            // Appeler la fonction d'initialisation
            enemyScript.Initialize(); // Passe la transform du joueur

            // Appeler une autre fonction (exemple: lui faire prendre des d�g�ts imm�diatement)
            // enemyScript.TakeDamage(10);

            // Appeler la fonction d'attaque (autre exemple)
            // enemyScript.Attack();
        }
        else
        {
            Debug.LogError("Le Prefab de l'ennemi n'a pas le script 'Enemy' attach� !");
        }
    }
}