using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Cost {

	public string Component;
	public string FK_TrackId;
	public string Maintenance_Date;
	public int Repair_Cost;
	public string Repair_Type;
}


[Serializable]
public class CostList {

	public List<Cost> list;
}
