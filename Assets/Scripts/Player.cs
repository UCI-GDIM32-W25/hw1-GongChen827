using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        // Initialize seed counts and update UI
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        
    }

    private void Update()
    {
        // ALlow movement by using WASD/Arrow keys
        float moveX = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        _playerTransform.Translate(new Vector3(moveX, moveY, 0));

        // Allow planting seed with SPACE key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        // Check if seeds are available
        if (_numSeedsLeft > 0)
        {
            // plant a plant at the player's current position
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

            // Update seed counts
            _numSeedsLeft--;
            _numSeedsPlanted++;

            // Update UI
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
        else
        {
            Debug.Log("No seeds left to plant!");
        }
    }
}

