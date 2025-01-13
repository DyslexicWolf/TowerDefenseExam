using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace TowerDefense.View.UI
{
    [RequireComponent(typeof(UIDocument))]

    public class PauseUI : MonoBehaviour
    {
        public event EventHandler NewGameClicked, MenuClicked;
        private UIDocument _document;

        private void Awake()
        {
            _document = GetComponent<UIDocument>();

            Button newGameBtn = _document.rootVisualElement.Q<Button>("NewGameButton");
            newGameBtn.clicked += NewGameBtn_clicked;

            Button menuBtn = _document.rootVisualElement.Q<Button>("MenuButton");
            menuBtn.clicked += MenuBtn_clicked;

            Hide();
        }

        public void Show()
        {
            _document.rootVisualElement.style.display = DisplayStyle.Flex;
        }

        public void Hide()
        {
            _document.rootVisualElement.style.display = DisplayStyle.None;
        }

        private void NewGameBtn_clicked()
        {
            NewGameClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MenuBtn_clicked()
        {
            MenuClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
