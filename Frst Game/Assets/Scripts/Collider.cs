using UnityEngine.SceneManagement;
using UnityEngine;

public class Collider : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] float nextLvlDelay = 1f;
    [SerializeField] ParticleSystem succesParticles;
    [SerializeField] ParticleSystem defeatParticles;
    [SerializeField] AudioClip coin;

    Rigidbody rb;
    AudioSource auso;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        auso = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                    Debug.Log("You have been respawned");
                    break;
            case "Enemy":
                    Debug.Log("Enemy has killed you!");
                    Death();
                    Invoke("levelReload", reloadDelay);
                    break;
            case "Collectible":
                    Debug.Log("Congrats !");
                    CoinGrabbed();
                    Invoke("NextLevelLoad", nextLvlDelay);
                    break;
            default:
                    Debug.Log("You crashed into an obstacle");
                    Death();
                    Invoke("levelReload", reloadDelay);
                    break;
        }
    }   

    void Death()
    {
        defeatParticles.Play();
        GetComponent<Mover>().enabled = false;
    }


    void CoinGrabbed()
    {
        succesParticles.Play();
        auso.Stop();
        auso.PlayOneShot(coin);
        GetComponent<Mover>().enabled = false;
    }

    void levelReload()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneIndex);
    }

    void NextLevelLoad()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = CurrentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}

