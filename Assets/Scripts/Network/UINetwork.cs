
using Deforestation.UI;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Deforestation.Network
{
	public class UINetwork : MonoBehaviour
	{
		#region Fields
		[SerializeField] private GameObject _connectingPanel;
		[SerializeField] private Button _exitButton;
		[SerializeField] private Button _retryButton;
		[SerializeField] private Button _exitWinButton;
		[SerializeField] private Button _retryWinButton;

		#endregion

		#region Properties
		public GameObject EndGamePanel;
		public GameObject WinGamePanel;

		#endregion

		#region Unity Callbacks	
		private void Awake()
		{
			_exitButton.onClick.AddListener(Exit);
			_exitWinButton.onClick.AddListener(Exit);
			_retryWinButton.onClick.AddListener(Retry);
			_retryButton.onClick.AddListener(Retry);
		}

		private void Retry()
		{
			SceneManager.LoadScene(0);
		}

		private void Exit()
		{
			Application.Quit();
		}
		#endregion

		#region Public Methods
		public void LoadingComplete()
		{
			_connectingPanel.SetActive(false);
		}
		#endregion

	}
}
