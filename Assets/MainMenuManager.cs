using UnityEngine;
using UnityEngine.SceneManagement; // Important pour charger d'autres scènes plus tard

public class MainMenuManager : MonoBehaviour
{
    // Méthode pour le bouton Jouer
    public void PlayGame()
    {
        Debug.Log("Bouton Jouer cliqué !");
        // Plus tard, vous ajouterez ici :
        // SceneManager.LoadScene("NomDeVotreSceneDeJeu"); // Remplacez par le nom réel de votre scène de jeu
    }

    // Méthode pour le bouton Settings
    public void OpenSettings()
    {
        Debug.Log("Bouton Settings cliqué !");
        // Plus tard, vous pourrez ouvrir un panel de settings ou une autre scène
    }

    // Méthode pour le bouton Credits
    public void ShowCredits()
    {
        Debug.Log("Bouton Credits cliqué !");
        // Plus tard, vous pourrez ouvrir un panel de crédits ou une autre scène
    }

    // Optionnel : Méthode pour quitter le jeu (fonctionne sur build PC/Mobile, pas dans l'éditeur)
    public void QuitGame()
    {
        Debug.Log("Bouton Quitter cliqué !");
        Application.Quit();
    }
}