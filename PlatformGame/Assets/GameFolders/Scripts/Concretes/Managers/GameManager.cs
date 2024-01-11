using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlatformGame.Scripts.Concretes.Controller.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] float _sceneLoadTime;
        public static GameManager Instance { get; private set; }
        private void Awake()
        {
            SingletonThisGameObject();
        }
        void SingletonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        public void LoadScene(int sceneIndex=0)
        {
            StartCoroutine(LoadSceneAsync(sceneIndex));
        }
        private IEnumerator LoadSceneAsync(int sceneIndex)
        {
            yield return new WaitForSeconds(_sceneLoadTime);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + sceneIndex);
        }
    }
}

