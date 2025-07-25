using UnityEngine;
using UnityEngine.UI;

public class Sample2 : MonoBehaviour
{
    public enum Projection
    {
        Perspetive,
        Orthographic
    }
    public enum FieldOfViewAxis
    {
        Vertical,
        Horizontal
    }

    public Projection projection;
    public FieldOfViewAxis fieldofViewAxis;
    public int FieldOfView;
    public float Near = 0.3f;
    public int Far = 1000;
    public bool PhysicalCamera;
}
