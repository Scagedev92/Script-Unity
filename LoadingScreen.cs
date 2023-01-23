using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public Slider loadingBar;
    public Text loadingText;
    private AsyncOperation async;

    void Start()
    {
        loadingBar.value = 0;
        loadingText.text = "Loading...";
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        async = Application.LoadLevelAsync("New Scene 1");
        while (!async.isDone)
        {
            loadingBar.value = async.progress;
            loadingText.text = "Loading... " + (int)(async.progress * 100) + "%";
            yield return null;
        }
    }
}
