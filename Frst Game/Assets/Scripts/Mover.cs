using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Mover : MonoBehaviour


{
    [SerializeField] float moveSpeed = 10f;

    BoxCollider bx;


    // Start is called before the first frame update
    void Start()
    {
        bx = GetComponent<BoxCollider>();
        Rules();
    }

    // Update is called once per frame
    void Update()
    {
        NextLevelLoader();
        Movement();
    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }

    void Rules()
    {
        Debug.Log("Your goal is to gather the coin");
        Debug.Log("But evil cube is protecting it!");
        Debug.Log("Try to not touch him and grab the precious coin ! Good Luck !");
    }



        void NextLevelLoader()
    {
        if (Input.GetKeyDown(KeyCode.L))
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
        

        
        
    

}
