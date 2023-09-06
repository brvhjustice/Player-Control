using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    //camera transform position
    private Vector3 offset = new Vector3(13, 3, 3);
    //camera rotate position
    // private Rotate offsetRotate = new Rotate(0 -90);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
