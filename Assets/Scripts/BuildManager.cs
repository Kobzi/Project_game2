using UnityEngine;

public class BuildManager : MonoBehaviour {
	
	public static BuildManager instance;
	
	void Awake()
	{
		if (instance != null )
		{
			Debug.LogError("Jest Więcej niż jeden BuildManager");
			return;
		}
		instance = this;
	}

	public GameObject standardTurretPrefab;
	public GameObject missileLauncherPrefab;
	
	private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }

    public void BuildTurretOn(Node node)
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Za mało pieniędzy na zbudowanie!");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        Debug.Log("Wieżyczka zbudowana! Dostępne środki: " + PlayerStats.Money);
    }

	public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
