//using System.Runtime.InteropServices.WindowsRuntime;
//using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoveredColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (!buildManager.CanBuild)
        {
            return;
        }
        //you cannot build there
        if (turret != null)
        {
            Debug.Log("Can't build there!");
            return;
        }
        buildManager.BuildTurretOn(this);
   
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        if (!buildManager.CanBuild)
        {
            return;
        }

        //when cursor hover over grass node it makes it to a selectec colour in Inspector
        if (buildManager.HasMoney)
        {
            rend.material.color = hoveredColor;
        }else
        {
            rend.material.color = notEnoughMoneyColor;
        }

    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
