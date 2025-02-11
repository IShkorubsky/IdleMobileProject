using Scripts;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RangeRenderer : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;

    // Update is called once per frame
    void Update()
    {
        DoRenderer();
    }

    [Range(0, 50)]
    public int segments = 20;
    LineRenderer line;

    private void DoRenderer()
    {
        line = gameObject.GetComponent<LineRenderer>();
        line.positionCount = segments + 1;
        line.useWorldSpace = false;
        CreatePoints();
    }

    void CreatePoints()
    {
        float x;
        float y;

        float angle = 20f;

        for (int i = 0; i < (segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * playerStats.range / 2;
            y = Mathf.Cos(Mathf.Deg2Rad * angle) * playerStats.range / 2;

            line.SetPosition(i, new Vector3(x, 0, y));

            angle += (360f / segments);
        }
    }
}
