using System.Collections;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoveredColor;
    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Can't build there!");
            return;
        }

        GameObject turrentToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turrentToBuild, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter()
    {
      rend.material.color = hoveredColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
