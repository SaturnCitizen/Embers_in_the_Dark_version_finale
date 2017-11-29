using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class help_menu_script : MonoBehaviour
{

    public void return_to_menu()

    {
        SceneManager.LoadScene("menu_scene");
    }
}
