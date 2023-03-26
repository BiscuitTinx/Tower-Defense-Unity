using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

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

    public GameObject MarcosPrefab;
    public GameObject ZeusPrefab;
    public GameObject HadesPrefab;

    public GameObject buildEffect;

    private TurretBlueprint turretToBuild;
    
    public bool CanBuild
    {
        get { return turretToBuild != null; }
    }
    public bool HasMoney
    {
        get { return PlayerStats.Money >= turretToBuild.cost; }
    }

    public void BuildTurretOn(Node node)
    {
       if (PlayerStats.Money < turretToBuild.cost)
       {
           Debug.Log("Not Enough Gold To Build That");
           return;
       }

       PlayerStats.Money -= turretToBuild.cost;

       GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
       node.turret = turret;

       GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
       Destroy(effect, 5f);

       Debug.Log("Turret Built Money Left: " + PlayerStats.Money);
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}