using System;
using KoboldUi.Collections.Concrete.Impl;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace MainMenuScreen.Ui.LevelSelector.Selector
{
    public class LevelItemView : AUiSimpleCollectionView
    {
        [SerializeField] private TextMeshProUGUI nameText;
        [SerializeField] private GameObject lockedContainer;
        [SerializeField] private GameObject unlockedContainer;
        [SerializeField] private GameObject selectedBackground;
        [SerializeField] private GameObject unselectedBackground;
        [SerializeField] private StarGroup[] stars;
        [SerializeField] private Button button;

        public IObservable<Unit> OnClick => button.OnClickAsObservable();
        public LevelData Data { get; private set; }

        public void SetLevelData(LevelData levelData)
        {
            Data = levelData;
            
            nameText.text = levelData.Name;

            lockedContainer.SetActive(!levelData.IsUnlocked);
            unlockedContainer.SetActive(levelData.IsUnlocked);

            for (var i = 0; i < stars.Length; i++)
            {
                var isAchieved = i < levelData.StarsCount;  
                stars[i].SetState(isAchieved);
            }
        }

        public void SetSelectionState(bool isSelected)
        {
            selectedBackground.SetActive(isSelected);
            unselectedBackground.SetActive(!isSelected);
        }
    }
}