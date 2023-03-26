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

    public void SelectMarcosTurret()
    {
        Debug.Log("Marcos Purchased");
        buildManager.SelectTurretToBuild(marcosTurret);
    }

    public void SelectZeusTurret()
    {
        Debug.Log("Zeus Purchased");
        buildManager.SelectTurretToBuild(zeusTurret);
    }

    public void SelectHadesTurret()
    {
        Debug.Log("Hades Purchased");
        buildManager.SelectTurretToBuild(hadesTurret);
    }
}
