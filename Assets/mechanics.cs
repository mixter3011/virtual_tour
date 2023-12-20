using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Set this variable to reference the UI panel for displaying questions
    public GameObject questionPanel;

    // To check if the player is currently in the range of an animal
    private bool inAnimalRange = false;

    // Start is called before the first frame update
    void Start()
    {
        
        questionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Check for user input (you can customize this based on your needs)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move the player based on input
        transform.Translate(new Vector3(horizontalInput, 0.0f, verticalInput) * Time.deltaTime);

        // Check if the player is in the range of an animal
        if (inAnimalRange && Input.GetKeyDown(KeyCode.Space))
        {
            DisplayQuestion(); // Display the question when the player presses Space
        }
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            inAnimalRange = true;
        }
    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            inAnimalRange = false;
            HideQuestion();
        }
    }

    // Display the question panel and question text
    void DisplayQuestion()
    {
        questionPanel.SetActive(true);
        // Add your code here to set and display the question related to the current animal
    }

    // Hide the question panel
    void HideQuestion()
    {
        questionPanel.SetActive(false);
    }
}