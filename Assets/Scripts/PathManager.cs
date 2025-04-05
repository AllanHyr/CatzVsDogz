using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    [SerializeField] private GameObject pathTilePrefab;
    [SerializeField] private float tileSize = 1f;
    
    private List<Vector2> waypoints = new List<Vector2>();
    
    public List<Vector2> Waypoints => waypoints;
    
    private void Start()
    {
        GenerateSimplePath();
    }
    
    private void GenerateSimplePath()
    {
        // Exemple de chemin simple en L
        CreatePathTile(new Vector2(-2f, 0f));
        CreatePathTile(new Vector2(-1f, 0f));
        CreatePathTile(new Vector2(0f, 0f));
        CreatePathTile(new Vector2(1f, 0f));
        CreatePathTile(new Vector2(2f, 0f));
        CreatePathTile(new Vector2(2f, 1f));
        CreatePathTile(new Vector2(2f, 2f));
        
        // Configurer les waypoints pour le mouvement des ennemis
        waypoints.Add(new Vector2(-2f, 0f));
        waypoints.Add(new Vector2(2f, 0f));
        waypoints.Add(new Vector2(2f, 2f));
    }
    
    private void CreatePathTile(Vector2 position)
    {
        if (pathTilePrefab == null) return;
        
        GameObject tile = Instantiate(pathTilePrefab, transform);
        tile.transform.position = position;
        tile.transform.localScale = new Vector3(tileSize, tileSize, 1f);
    }
    
    // Visualisation des waypoints dans l'éditeur
    private void OnDrawGizmos()
    {
        if (waypoints == null || waypoints.Count < 2) return;
        
        Gizmos.color = Color.red;
        for (int i = 0; i < waypoints.Count - 1; i++)
        {
            Vector3 start = new Vector3(waypoints[i].x, waypoints[i].y, 0);
            Vector3 end = new Vector3(waypoints[i + 1].x, waypoints[i + 1].y, 0);
            Gizmos.DrawLine(start, end);
            Gizmos.DrawSphere(start, 0.1f);
        }
        Vector3 last = new Vector3(waypoints[waypoints.Count - 1].x, waypoints[waypoints.Count - 1].y, 0);
        Gizmos.DrawSphere(last, 0.1f);
    }
}