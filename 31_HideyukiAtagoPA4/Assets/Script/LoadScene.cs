using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string SceneToLoad = "";
    public float DelayTime = 1f;
    public void Start()
    {
        StartCoroutine("Wait");
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(DelayTime);

        SceneManager.LoadScene(1);
    }
}