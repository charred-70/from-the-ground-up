using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTextureDefault;
    [SerializeField] private Texture2D holdingCursorTexture;

    [SerializeField] private Vector2 clickPosition = Vector2.zero;

    void Start()
    {
        Cursor.visible = true;

        if (cursorTextureDefault == null)
            Debug.LogWarning("Default cursor texture not assigned in Inspector.");
        if (holdingCursorTexture == null)
            Debug.LogWarning("Holding cursor texture not assigned in Inspector.");

        // Use ForceSoftware for testing (more consistent across platforms)
        if (cursorTextureDefault != null)
            Cursor.SetCursor(cursorTextureDefault, clickPosition, CursorMode.ForceSoftware);
    }

    void Update()
    {
        // debug input so we know it's detected
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Mouse button down");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("Mouse button up");
        if (Input.GetMouseButton(0))
            Debug.Log("Mouse button held");

        // show the holding texture while the button is held
        if (Input.GetMouseButton(0))
        {
            if (holdingCursorTexture != null)
                Cursor.SetCursor(holdingCursorTexture, clickPosition, CursorMode.ForceSoftware);
        }
        else
        {
            if (cursorTextureDefault != null)
                Cursor.SetCursor(cursorTextureDefault, clickPosition, CursorMode.ForceSoftware);
        }
    }
}

