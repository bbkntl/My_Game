/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float sensetyCam = 5;
    Vector3 deltaPosCam;
    Vector3 target;
    
    void Start()
    {
        cameraTransform = transform;
        deltaPosCam = cameraTransform.position - Player.position;
        deltaPosCam.z = -10;
    }

    
    void Update()
    {
        target = Player.transform.position + deltaPosCam;
        target.y = -0.5f;
        cameraTransform.position = Vector3.MoveTowards(cameraTransform.position, target, Time.deltaTime * sensetyCam);
    }
}*/
