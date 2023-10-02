using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

public class ChangingColour : MonoBehaviour
{
    public GameObject sphere;
    public GameObject capsule;
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        sphere.GetComponent<Renderer>().material.color = Color.red;
        sphere.GetComponent<Rigidbody>().useGravity = true;

        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        capsule.SetActive(!capsule.activeSelf);
    }

    // Update is called once per frame
    // GetKeyDown does not work properly with FixedUpdate
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            capsule.SetActive(!capsule.activeSelf);
        }
    }


    private void OnMouseDown()
    {
        sphere.GetComponent<Renderer>().material.color = Color.cyan;
        if (Input.GetMouseButton(0))
            sphere.GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0) * 0.5f;
    }
    private void OnMouseUp()
    {
        sphere.GetComponent<Renderer>().material.color = Color.red;
        sphere.GetComponent<Rigidbody>().useGravity = true;
    }
}
