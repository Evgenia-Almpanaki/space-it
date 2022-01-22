using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(MenuManager))]
public class GameController : MonoBehaviour
{
    [SerializeField] private AsteroidCounter asteroidCounter;
    [SerializeField] private GameObject asteroidPrefab;
    [SerializeField] private Transform planetsParent;

    private MenuManager menuManager;
    private Plane plane;

    private void Awake()
    {
        menuManager = GetComponent<MenuManager>();
        plane = new Plane(Vector3.forward, 0);
    }

    private void Update() {

        if (planetsParent.childCount == 0) 
            FinishGame(true);

        if (Input.GetKeyUp(KeyCode.Mouse0))
            ShootAsteroid();
    }

    public void FinishGame(bool win)
    {
        if (win)
            menuManager.LoadScene(2);
        else
            menuManager.LoadScene(3);
    }

    private void ShootAsteroid()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        plane.Raycast(ray, out float ray_distance);
        Vector3 world_position = ray.GetPoint(ray_distance);

        Instantiate(asteroidPrefab, world_position, Quaternion.identity);
        asteroidCounter.DecreaseAsteroid();
    }
}
