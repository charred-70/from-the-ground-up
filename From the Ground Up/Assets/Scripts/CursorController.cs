using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTextureDefault;
    [SerializeField] private Texture2D holdingCursorTexture;

    [SerializeField] private Vector2 clickPosition = Vector2.zero;

    void Start()
    {
        Cursor.visible = true;

        // Use ForceSoftware for testing (more consistent across platforms)
        if (cursorTextureDefault != null)
            Cursor.SetCursor(cursorTextureDefault, clickPosition, CursorMode.ForceSoftware);
    }

    void Update()
    {

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

