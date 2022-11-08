using UnityEngine;
using MiddleVR;
using MiddleVR.Unity;

/// <summary>
/// Erstes Beispiel für eine Interaktion mit MiddleVR
/// </summary>
/// <remarks>
/// Wir verwenden eine Taste auf der Tastatur für das Highlighting
/// eines GameObjects.
///
/// Eine Version mit Hilfe des Wands finden wir in der Klasse
/// WandHighlighter.
/// </remarks>
public class KeyboardHighlighter : MonoBehaviour
{
    /// <summary>
    /// Die Farbe dieses Materials wird für die geänderte Farbe verwendet.
    /// </summary>
    [Tooltip("Material für das Highlight")]
    public Material HighlightMaterial;

    /// <summary>
    /// Instanz des MiddleVR DeviceManager
    /// </summary>
    private MiddleVR.vrDeviceManager m_Manager;
    
    /// <summary>
    /// Welche Taste  soll verwendet werden?
    /// </summary>
    /// <remarks>
    /// Die Tasten eines Keyboards sind in MiddleVR als uint-Variablen
    /// verfügbar.
    ///
    /// Beispiel: MVR.VRK_SPACE, MVR.VRK_1, ...
    /// </remarks>
    private uint key = MVR.VRK_H;
    /// <summary>
    /// Statur des Highlighters
    /// </summary>
    private bool m_status = false;
    /// <summary>
    /// Variable, die das Original-Material des Objekts enthält
    /// </summary>
    private Material myMaterial;
    /// <summary>
    /// Wir fragen die Materialien ab und speichern die Farben als Instanzen
    /// der Klasse Color ab.
    /// </summary>
    private Color originalColor, highlightColor;

    /// <summary>
    /// Wir fragen das Material und die Farbe ab und setzen
    /// die Highlight-Farbe aus dem zugewiesenen Material.
    /// </summary>
    private void Awake()
    {
        myMaterial = GetComponent<Renderer>().material;
        originalColor = myMaterial.color;
        highlightColor = HighlightMaterial.color;
    }

    /// <summary>
    /// Instanz des MiddleVR DeviceManagers abfragen
    /// </summary>
    private void OnEnable()
    {
        if (MVR.DeviceMgr != null)
            m_Manager = MVR.DeviceMgr;
        else
            MVRTools.Log("MiddleVR Device Manager nicht gefunden!");
    }

    private void Update()
    {
        if (m_Manager.IsKeyToggled(key))
            changeColor();
    }
    /// <summary>
    /// Farbwechsel, wird in den Listernern registriert
    /// </summary>
    private void changeColor()
    { 
        if (!m_status)
            myMaterial.color = highlightColor;
        else
            myMaterial.color = originalColor; 
        
         m_status = !m_status;
    }
}
