using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public double speed;
    public int pv;

    public void changeSpeed(double speedMultiplier)
    {
        speed = speed * speedMultiplier;
    }

    public void removePV(int removePv)
    {
        pv = pv - removePv;
        if (pv < 0)
        {
            Die();
        }
    }

    // Une fonction d'initialisation que l'on pourra appeler après l'apparition
    public void Initialize()
    {
        Debug.Log($"Enemy initialisé ! Points de vie: {pv}, Vitesse: {speed}.");
        // Autres logiques d'initialisation (ex: chercher le joueur, etc.)
    }
    private void Die()
    {
        Debug.Log($"{gameObject.name} est vaincu !");
        // Ajouter ici des effets (explosion, score, etc.)
        Destroy(gameObject); // Détruit le GameObject de l'ennemi
    }
}
