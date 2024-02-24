using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    public void ExitProgram()
    {
        Application.Quit();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
}
