using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{

    public GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void doExit()
    {
        Application.Quit();
    }

    public void makeCube()
    {
        Instantiate(myCube, new Vector3(0, -.1f, 0.5f), Quaternion.identity);
    }

    public void changeColor()
    {
        myCube.GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }


}
