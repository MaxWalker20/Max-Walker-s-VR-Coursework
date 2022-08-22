using UnityEngine;

using static UnityEngine.Mathf;

public static class FunctionSelector {

	public delegate Vector3 Function (float u, float v, float t);

	public static Vector3 MultiWave (float x, float t, float r1, float r2) {
		Vector3 p;
		p.x = x;
		p.y = Sin(r1* PI * (x + 0.5f * t));
		p.y += 0.5f * Sin(r2 * PI * (x + t));
		p.z = 0;
		return p;
	}

	public static Vector3 MultiWave3D (float u, float v, float t) {
		Vector3 p;
		p.x = u;
		p.y = Sin(PI * (u + 0.5f * t));
		p.y += 0.5f * Sin(2f * PI * (v + t));
		p.y += Sin(PI * (u + v + 0.25f * t));
		p.y *= 1f / 2.5f;
		p.z = v;
		return p;
	}
}
