using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] GameObject playerModel;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerTurnOnMouseClick();
    }

    private void PlayerTurnOnMouseClick()
    {
        if(Input.GetMouseButton(1))
        {
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask))
                playerModel.transform.LookAt(raycastHit.point);
        }
    }
}
