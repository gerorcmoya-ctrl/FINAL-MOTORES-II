using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject instruccionesPanel;

    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void MostrarInstrucciones()
    {
        instruccionesPanel.SetActive(true);
    }

    public void CerrarInstrucciones()
    {
        instruccionesPanel.SetActive(false);
    }

    public void Salir()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}