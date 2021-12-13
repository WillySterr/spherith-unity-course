using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrithControls : MonoBehaviour
{
    public float rotateSpeed = 1;
    public float maxRotate = 45;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = transform.eulerAngles.x + Input.GetAxis("Vertical") * rotateSpeed * Time.deltaTime;
        float horizontal = transform.eulerAngles.z - Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

        if (vertical <= 315.0 && transform.eulerAngles.x >= 315.0) vertical = 315;
        if (vertical >= 45.0 && transform.eulerAngles.x <= 45.0) vertical = 45;
        if (horizontal <= 315.0 && transform.eulerAngles.z >= 315.0) horizontal = 315;
        if (horizontal >= 45.0 && transform.eulerAngles.z <= 45.0) horizontal = 45;

        transform.eulerAngles = new Vector3(
            vertical ,
            0,
            horizontal
        );

    }
}
