using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseZeusTurret()
    {
        Debug.Log("Zeus Purchased");
        buildManager.SetTurretToBuild(buildManager.ZeusPrefab);
    }

    public void PurchaseHadesTurret()
    {
        Debug.Log("Hades Purchased");
        buildManager.SetTurretToBuild(buildManager.HadesPrefab);
    }
}
