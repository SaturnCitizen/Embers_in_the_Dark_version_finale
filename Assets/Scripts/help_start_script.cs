using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class help_start_script : MonoBehaviour
{

    public void start_the_game()
    {
        SceneManager.LoadScene("level_one");
    }
}
