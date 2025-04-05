using UnityEngine;
using UnityEngine.SceneManagement; // Important pour charger d'autres sc�nes plus tard

public class MainMenuManager : MonoBehaviour
{
    // M�thode pour le bouton Jouer
    public void PlayGame()
    {
        Debug.Log("Bouton Jouer cliqu� !");
        // Plus tard, vous ajouterez ici :
        // SceneManager.LoadScene("NomDeVotreSceneDeJeu"); // Remplacez par le nom r�el de votre sc�ne de jeu
    }

    // M�thode pour le bouton Settings
    public void OpenSettings()
    {
        Debug.Log("Bouton Settings cliqu� !");
        // Plus tard, vous pourrez ouvrir un panel de settings ou une autre sc�ne
    }

    // M�thode pour le bouton Credits
    public void ShowCredits()
    {
        Debug.Log("Bouton Credits cliqu� !");
        // Plus tard, vous pourrez ouvrir un panel de cr�dits ou une autre sc�ne
    }

    public void ShowMiniGame()
    {
        Debug.Log("Bouton MiniGame cliqu� !");
        // Plus tard, vous pourrez ouvrir le mini jeu
    }

    // Optionnel : M�thode pour quitter le jeu (fonctionne sur build PC/Mobile, pas dans l'�diteur)
    public void QuitGame()
    {
        Debug.Log("Bouton Quitter cliqu� !");
        Application.Quit();
    }
}