using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharacter : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    private float speed = 2f;
    private float Reed = 150f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        m_Rigidbody = GetComponent<Rigidbody>();
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
           
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * Reed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * Reed, Space.World);
        }

        if (Input.GetKey(KeyCode.R))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
