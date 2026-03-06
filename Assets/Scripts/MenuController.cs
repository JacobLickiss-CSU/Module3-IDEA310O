using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    public bool releaseCursor = false;

    InputAction menuAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menuAction = InputSystem.actions.FindAction("Menu");

        if(releaseCursor)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(menuAction.IsPressed())
        {
            GoMenu();
        }
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void GoLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void GoLevel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
