using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Splash : MonoBehaviour
{
    public bool startScene;

    public Button botonDeInicio;

    private void Awake()
    {
        StartCoroutine(InicializaParaMainMenu());
    }

    private IEnumerator InicializaParaMainMenu()
    {
        //yield return new WaitForSeconds(5);
        yield  return new WaitUntil(() => startScene);

        SceneManager.LoadScene("MainMenu");
    }

    public void IniciarMainMenu()
    {
        startScene = true;
    }
}
