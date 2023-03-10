using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotoBehaviour : MonoBehaviour
{
    //scene to go to
    public string goTo;
    //bool to check double click
    public bool dc;
    //position of mouse
    Vector2 mousePosition;
    

    // Start is called before the first frame update
    void Start()
    {
        dc = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //set mousePostition
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    //when mouse is over photo
    private void OnMouseOver()
    {
        //if left mouse button is clicked and dc is true
        if (Input.GetMouseButtonDown(0) && dc == true)
        {
            //go to scene
            SceneManager.LoadScene(goTo);
            
        }
        else if(Input.GetMouseButtonDown(0))
        {
            //dc is true, next click will go to scene
            dc = true;
            Debug.Log("DC: " + dc);
            
        }
        //as long as button is down
        if (Input.GetMouseButton(0))
        {
            //set transform to mouse position
            transform.position = mousePosition;
        }
    }

    private void OnMouseExit()
    {
        //reset dc when mouse exits
        dc = false;
        Debug.Log("DC: " + dc);
    }
}
