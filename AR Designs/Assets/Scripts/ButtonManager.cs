using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void ExitProgram()
    {
        Application.Quit();
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
}
