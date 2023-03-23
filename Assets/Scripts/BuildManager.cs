using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than 1 build manager");
        }

        instance = this;
    }

    public GameObject standardTurretPrefab;

    private GameObject turretToBuild;
    void Start()
    {
        turretToBuild = standardTurretPrefab;
    }


    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
