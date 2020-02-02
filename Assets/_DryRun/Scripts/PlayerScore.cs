using TMPro;
using UnityEngine;

namespace DryRun
{
    public class PlayerScore : MonoBehaviour
    {
        #region Fields
        public TextMeshProUGUI scoreText = null;

        private int score = 0;
        private const string _FORMATTABLE_TEXT = "Score: <size=150%>{0}</size>";
        #endregion

        #region Methods
        void Start()
        {
            UpdateScore();
            Token.DestroyedTokenEvent += OnDestroyedToken;
        }

        private void UpdateScore()
        {
            scoreText.text = string.Format(_FORMATTABLE_TEXT, score);
        }

        private void OnDestroyedToken(TokenStats stats)
        {
            score += stats.health;
            UpdateScore();
        }

        void OnDestroy()
        {
            Token.DestroyedTokenEvent -= OnDestroyedToken;
        }
        #endregion
    }
}