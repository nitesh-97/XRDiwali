using UnityEngine;
using UnityEngine.UI;

public class LoadSceneButton : MonoBehaviour
{
	[SerializeField]
	private int sceneToLoad;
	
	private void Awake()
	{
		GetComponent<Button>().onClick.AddListener(LoadScene);
	}

	public void LoadScene()
	{
		gameObject.SetActive(false);
		FindObjectOfType<ProgressSceneLoader>().LoadScene(sceneToLoad);
	}
}