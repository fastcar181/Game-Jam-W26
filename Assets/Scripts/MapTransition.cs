using Unity.Cinemachine;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MapTransition : MonoBehaviour
{
    [SerializeField] PolygonCollider2D mapBoundary;
    CinemachineConfiner2D confiner;
    [SerializeField] Direction direction;
    enum Direction { Up, Down, Left, Right }
    private void Awake()
    {
        confiner = FindFirstObjectByType<CinemachineConfiner2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            confiner.BoundingShape2D = mapBoundary;
            //confiner.InvalidateBoundingShapeCache();
            UpdatePlayerPosition(collision.gameObject);
        }
    }

    private void UpdatePlayerPosition(GameObject player)
    {
        Vector3 new_position = player.transform.position;

        switch (direction)
        {
            case Direction.Up:
                new_position.y += 3;
                break;
            case Direction.Down:
                new_position.y -= 3;
                break;
            case Direction.Left:
                new_position.x += 3;
                break;
            case Direction.Right:
                new_position.x -= 3;
                break;
        }

        player.transform.position = new_position;
    }
}
