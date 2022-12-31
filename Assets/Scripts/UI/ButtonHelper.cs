using UnityEngine;

public class ButtonHelper : MonoBehaviour
{
    public void OnClickLoad(string scene)
    {
        SceneLoaderManager.GetInstance().LoadSceneByName(scene);
    }

    public void OnClickExit()
    {
        SceneLoaderManager.GetInstance().ExitGame();
    }
}
