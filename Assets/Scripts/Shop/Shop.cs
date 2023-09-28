using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint marcosTurret;
    public TurretBlueprint zeusTurret;
    public TurretBlueprint hadesTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }


    //Basically in all this code below its shows you in the debug console on unity whether the icons in the bottom left have been pressed
    public void SelectMarcosTurret()
    {
        Debug.Log("Marcos logo pressed");
        buildManager.SelectTurretToBuild(marcosTurret);    
    }

    public void SelectZeusTurret()
    {
        Debug.Log("Zeus logo pressed");
        buildManager.SelectTurretToBuild(zeusTurret);
    }

    public void SelectHadesTurret()
    {
        Debug.Log("Hades logo pressed");
        buildManager.SelectTurretToBuild(hadesTurret);
    }
}
