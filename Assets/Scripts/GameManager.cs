using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    [SerializeField] private Image FadePanel;
    private float time=0.0f;
    private float alphafadePanel = 0.0f;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;
    public GameObject door6;
    public GameObject door7;

    void Awake()
    {
        float random = Mathf.Ceil(Random.Range(0.0f, 6.0f));

        door1 = GameObject.Find("castle_doors (6)");
        door1.SetActive(false);
        door2 = GameObject.Find("castle_doors (5)");
        door2.SetActive(false);
        door3 = GameObject.Find("castle_doors (4)");
        door3.SetActive(false);
        door4 = GameObject.Find("castle_doors (3)");
        door4.SetActive(false);
        door5 = GameObject.Find("castle_doors (2)");
        door5.SetActive(false);
        door6 = GameObject.Find("castle_doors (1)");
        door6.SetActive(false);
        door7 = GameObject.Find("castle_doors");
        door7.SetActive(false);
        if (random == 0)
        {
            door1.SetActive(true);
        }
        if (random == 1)
        {
            door2.SetActive(true);
        }
        if (random == 2)
        {
            door3.SetActive(true);
        }
        if (random == 3)
        {
            door4.SetActive(true);
        }
        if (random == 4)
        {
            door5.SetActive(true);
        }
        if (random == 5)
        {
            door6.SetActive(true);
        }
        if (random == 6)
        {
            door7.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update () {
       time += Time.deltaTime;
        if (time > 1)
        {
            alphafadePanel += 0.01111f;
            time = 0.0f;
            FadePanel.color = new Color(0.0f, 0.0f, 0.0f, alphafadePanel);
        }
        if (alphafadePanel >= 1f)
            player_die();
	}

    public void player_gain_luminosity()
    {
        alphafadePanel -= 0.5f;
    }
    public void player_lose_luminosity()
    {
        alphafadePanel += 0.1f;
    }
    public void player_win()
    {
        SceneManager.LoadScene("win_scene");
    }
    public void player_die()
    {
        SceneManager.LoadScene("lose_scene");
    }
}
