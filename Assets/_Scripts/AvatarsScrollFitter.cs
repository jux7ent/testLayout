using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarsScrollFitter : MonoBehaviour {
    [SerializeField] private Sprite[] _avatars;
    [SerializeField] private Transform _gridTransform;
    [SerializeField] private GameObject _avatarPrefab;

    private void Awake() {
        AddAvatars(_avatars);
    }

    private void AddAvatars(Sprite[] avatars) {
        for (int i = 0; i < avatars.Length; ++i) {
            Instantiate(_avatarPrefab, _gridTransform).GetComponent<Image>().sprite = avatars[i];
        }
    }
}