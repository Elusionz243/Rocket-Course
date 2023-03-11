using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  new Rigidbody rigidbody;
  float thrusterForce = 500f;
  float rotationalForce = 150f;
  // Start is called before the first frame update
  void Start()
  {
    rigidbody = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    RotateRocket();
    ActivateThruster();
  }

  void RotateRocket()
  {
    if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
    {
      HandleRotation(rotationalForce);
    }
    if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
    {
      HandleRotation(-rotationalForce);
    }
  }

  void HandleRotation(float rotationAmount)
  {
    transform.Rotate(Vector3.forward * rotationAmount * Time.deltaTime);
  }

  void ActivateThruster()
  {
    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
    {
      rigidbody.AddRelativeForce(Vector3.up * thrusterForce * Time.deltaTime);
    }
  }
}
