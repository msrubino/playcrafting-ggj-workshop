using UnityEngine;

namespace DryRun
{
    public class TokenSpawner : MonoBehaviour
    {
        #region Fields
        public float timeBetweenSpawns = 1f;
        public GameObject[] tokens = null;

        private float _elapsedTime;
        #endregion

        #region Methods
        void Update()
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime < timeBetweenSpawns)
            {
                return;
            }

            _elapsedTime = 0;
            int randomTokenIndex = Random.Range(0, tokens.Length);
            GameObject token = tokens[randomTokenIndex];
            Instantiate(token, transform.position, Quaternion.identity);
        }
        #endregion
    }
}