using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FindScript : MonoBehaviour
{
    public Text Win;
    
    public Text Food1;
    public GameObject Food;

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
        Food1.gameObject.SetActive(true);
        Win.gameObject.SetActive(true);
        

    }
}
