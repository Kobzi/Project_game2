using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

	BuildManager buildManager;

	void Start()
	{
		buildManager = BuildManager.instance;
	}

	public void PurchaseStandardTurret()
	{
		Debug.Log("Standard Turred Selected");
		buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
	}

	public void PurchaseAnotherTurret()
	{
		Debug.Log("Another Turred Selected");
		buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
	}
}
