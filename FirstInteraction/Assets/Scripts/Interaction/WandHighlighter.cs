using UnityEngine;
using MiddleVR;
using MiddleVR.Unity;

/// <summary>
/// Beispiel für eine Interaktion mit MiddleVR mit Hilfe des Wand.
/// </summary>
/// <remarks>
/// Wir verwenden eine Tasteauf dem Wandr für das Highlighting
/// eines GameObjects.
///
/// Eine Version mit Hilfe der Tastatur finden wir in der Klasse
///keyboardHighlighter.
/// </remarks>
public class WandHighlighter : MonoBehaviour
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
    /// Welcher Button auf dem Wand  soll verwendet werden?
    /// </summary>
    /// <remarks>
    /// Die Buttons sind durch uint-Variablen anzusprechen.
    /// Welche Buttons es gibt ist in der Konfigurations-Anwendung
    /// gut abzulesen!
    ///
    /// Die Nummer 0 ist der "primary button".
    /// </remarks>
    private uint button = 0;
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

    /// <summary>
    /// Reaktion auf den Tastendruck auf dem Wand.
    /// </summary>
    /// <remarks>
    /// Es gibt auch die Funktion IsWandButtonPressed.
    /// </remarks>
    private void Update()
    {
        if (m_Manager.IsWandButtonToggled(button))
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
