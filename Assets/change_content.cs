using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Make sure you are using TMPro for TextMeshPro
using UnityEngine.UI; // Import the UI namespace for Image

public class ChangeContent : MonoBehaviour
{
    public int indexContent = 0;
    public List<GameObject> listContent; // Changed from list to List
    public List<string> listString; // Changed from list to List
    public TextMeshProUGUI txt; // Changed TextMextpro to TextMeshProUGUI
    public AudioSource source; // Fixed typo from AudiouSource to AudioSource
    public Image zoomImage; // Make sure to use UnityEngine.UI for Image
    public GameObject parentZoom; // Parent object to enable when zooming
    public GameObject buttonParent;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = listString[0]; // Corrected txt.value to txt.text and added semicolon
        changeContent(indexContent);
    }

    // Update is called once per frame
    void Update()
    {
        // Your update logic here
    }

    public void changeContent(int index)
    {
        for (int i = 0; i < listContent.Count; i++) // Changed .size to .Count
        {
            if (i == index) // Changed === to ==
            {
                listContent[i].SetActive(true); // Changed setactive to SetActive and added semicolon
            }
            else
            {
                listContent[i].SetActive(false); // Changed setactive to SetActive and added semicolon
            }
        }
    }

    public void goingLeft()
    {
        if (indexContent > 0) // Changed condition to > 0 for better logic
        {
            indexContent--; // Decrement indexContent first
            txt.text = listString[indexContent]; // Corrected txt.value to txt.text and added semicolon
            changeContent(indexContent);
        }
    }

    public void goingRight()
    {
        if (indexContent < listContent.Count - 1) // Changed condition to < listContent.Count - 1 for better logic
        {
            indexContent++; // Increment indexContent first
            txt.text = listString[indexContent]; // Corrected txt.value to txt.text and added semicolon
            changeContent(indexContent);
        }
    }

    public void changeContentByIndex(int index)
    {
         for (int i = 0; i < listContent.Count; i++) // Changed .size to .Count
        {
            txt.text = listString[index]; // Corrected txt.value to txt.text and added semicolon
            if (i == index) // Changed === to ==
            {
                listContent[i].SetActive(true); // Changed setactive to SetActive and added semicolon
            }
            else
            {
                listContent[i].SetActive(false); // Changed setactive to SetActive and added semicolon
            }
        }
    }

    public void playSound(AudioClip clip) // Changed Sound to AudioClip
    {
        source.clip = clip; // Set the clip to the AudioSource
        source.Play(); // Play the clip
    }

    public void setZoomImage(Sprite img) // This method will be called by the button's onClick event
    {
        buttonParent.SetActive(false);
        parentZoom.SetActive(true); // Activate the parent zoom object
        zoomImage.sprite = img; // Set the sprite of the zoomImage
    }
}
