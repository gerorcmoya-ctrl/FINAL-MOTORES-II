using UnityEngine;

public class Puerta : MonoBehaviour
{
    public int totalEnemigos = 6;
    private int enemigosEliminados = 0;

    public static Puerta Instance;

    void Awake()
    {
        Instance = this;
    }

    public void EnemigoDerrotado()
    {
        enemigosEliminados++;
        Debug.Log("Enemigos eliminados: " + enemigosEliminados + "/" + totalEnemigos);

        if (enemigosEliminados >= totalEnemigos)
        {
            AbrirPuerta();
        }
    }

    void AbrirPuerta()
    {
        // Bajar la puerta o desactivarla
        gameObject.SetActive(false);
        Debug.Log("Puerta abierta!");
    }
}