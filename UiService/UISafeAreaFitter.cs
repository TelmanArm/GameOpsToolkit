using UnityEngine;

namespace Core.UI.Base
{
    public static class UISafeAreaFitter
    {
        public static void FitInSafeArea(this RectTransform trans)
        {
            Rect safeAreaRect = Screen.safeArea;
            
            Vector2 anchorMin = safeAreaRect.position;
            Vector2 anchorMax = safeAreaRect.position + safeAreaRect.size;
            anchorMin.x /= Screen.width;
            anchorMin.y /= Screen.height;
            anchorMax.x /= Screen.width;
            anchorMax.y /= Screen.height;
            //trans.anchorMin = anchorMin;
            trans.anchorMax = anchorMax;

            // Debug.LogFormat("Safe area applied to {0}: x={1}, y={2}, w={3}, h={4} on full extents w={5}, h={6}",
            //     trans.name, safeAreaRect.x, safeAreaRect.y, safeAreaRect.width, safeAreaRect.height, Screen.width,
            //     Screen.height);
        }
    }
}
