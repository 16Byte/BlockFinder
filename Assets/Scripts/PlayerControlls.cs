using UnityEngine;
using System.Collections;

public class PlayerControlls : MonoBehaviour {

    public int Speed;
    public int RotationSpeed;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * Speed * Time.deltaTime);
            GetComponent<Rigidbody>().transform.Translate(Vector3.forward * Speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().transform.Translate(Vector3.back * Speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().transform.Translate(Vector3.left * Speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().transform.Translate(Vector3.right * Speed * Time.deltaTime, Space.World);
        }
    }

}
