using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class win_menu_script : MonoBehaviour
{

    public void return_menu()

    {
        SceneManager.LoadScene("menu_scene");
    }
}
