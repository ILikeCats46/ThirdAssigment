using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LoseScript : MonoBehaviour
{

    public Text Lose;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      
        Lose.gameObject.SetActive(true);
    }
}
