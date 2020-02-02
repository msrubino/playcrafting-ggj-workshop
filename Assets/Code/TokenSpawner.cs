using UnityEngine;

public class TokenSpawner : MonoBehaviour
{
    #region Fields
    public float timeToSpawn = 1;
    public GameObject tokenToSpawn;

    private float _timeElapsed;
    #endregion

    #region Methods
    private void Update()
    {
        _timeElapsed += Time.deltaTime;
        if (_timeElapsed < timeToSpawn)
        {
            return;
        }

        _timeElapsed = 0;
        Instantiate(tokenToSpawn, transform.position, Quaternion.identity);
    }
    #endregion
}
