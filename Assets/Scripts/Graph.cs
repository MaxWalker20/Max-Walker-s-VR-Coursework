using UnityEngine;

public class Graph : MonoBehaviour {

	[SerializeField]
	Transform pointPrefab;

	[SerializeField, Range(10, 100)]
	int resolution = 10;

	[SerializeField] public float ratioNumerator = 16f;

	[SerializeField] public float ratioDenominator = 15f;

	Transform[] points;

	void Awake () {
		float step = 2f / resolution;
		var scale = Vector3.one * step;
		points = new Transform[resolution * resolution];
		for (int i = 0; i < points.Length; i++) {
			Transform point = points[i] = Instantiate(pointPrefab);
			point.localScale = scale;
			point.SetParent(transform, false);
		}
	}

	void Update () {
		float time = Time.time;
		float step = 2f / resolution;
		float v = 0.5f * step - 1f;
		for (int i = 0, x = 0; i < points.Length; i++, x++) {
			if (x == (resolution * 3)) {
				x = 0;
			}
			float u = (x + 0.5f) * step - 1f;
			//Debug.Log(ratioNumerator + " and " + ratioDenominator);
			points[i].localPosition = FunctionSelector.MultiWave(u, time, ratioNumerator, ratioDenominator);
		}
	}


}
