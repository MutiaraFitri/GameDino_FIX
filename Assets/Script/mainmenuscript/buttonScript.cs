using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playButtons(){
            Application.LoadLevel("map");
    }
    public void settingButtons(){
            Application.LoadLevel("map");
    }
    public void quitButtons(){
            Application.Quit();
    }
     
    public void level2(){
            Application.LoadLevel("Hutan");
    }
}
