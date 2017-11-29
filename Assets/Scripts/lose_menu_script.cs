using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class lose_menu_script : MonoBehaviour {

    public void retry()

    {
        SceneManager.LoadScene("level_one");
    }

    public void return_to_principal_menu()

    {
        SceneManager.LoadScene("menu_scene");
    }
}
