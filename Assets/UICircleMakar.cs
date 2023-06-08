﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICircleMakar : MonoBehaviour
{
    public RectTransform markerTransform; // Reference to the marker's RectTransform component
    public float minSize = 2f; // Minimum size of the circle marker
    public float maxSize = 50f; // Maximum size of the circle marker

    private void Start()
    {
        // Generate a random size for the circle marker
        float markerSize = Random.Range(minSize, maxSize);

        // Set the size of the marker using the RectTransform's sizeDelta property
        markerTransform.sizeDelta = new Vector2(markerSize, markerSize);
    }
}
