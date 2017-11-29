using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu_script : MonoBehaviour
{
    public Canvas quit_menu;
    public Button start_button;
    public Button exit_button;
    public Button help_button;

    void Start()

    {
        quit_menu = quit_menu.GetComponent<Canvas>();
        start_button = start_button.GetComponent<Button>();
        exit_button = exit_button.GetComponent<Button>();
        help_button = exit_button.GetComponent<Button>();
        quit_menu.enabled = false;

    }

    public void exit_pressed()

    {
        quit_menu.enabled = true;
        start_button.enabled = false;
        exit_button.enabled = false;
        help_button.enabled = false;

    }

    public void no_pressed()

    {
        quit_menu.enabled = false;
        start_button.enabled = true;
        exit_button.enabled = true;
        help_button.enabled = true;

    }

    public void start_level()

    {
        SceneManager.LoadScene("help_scene");

    }

    public void go_to_help_menu()

    {
        SceneManager.LoadScene("help_scene_menu");

    }

    public void exit_game()

    {
        Application.Quit();

    }

}
