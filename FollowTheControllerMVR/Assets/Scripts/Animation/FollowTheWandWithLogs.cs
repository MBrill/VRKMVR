using UnityEngine;
using MiddleVR;
using MiddleVR.Unity;

/// <summary>
/// Ein Objekt, dem diese Klasse hinzugefügt wird 
/// verfolgt einen Wand, der in der MiddleVR-Konfiguration
/// enthalten ist mit Hilfe von 
/// Transform.MoveTowards und Transform.LookAt.
/// Die Position des Verfolgers und des Controllers werden mit Log4Net
/// protokolliert.
/// </summary>
/// <remarks>
/// Wir verwenden den Wand Nr. 0.
///
/// Wir verwenden Logging mit Log4Net für die Ausgabe
/// der Position des Wands und des Verfolgers.
/// </remarks>
public class FollowTheWandWithLogs : MonoBehaviour
{
	/// <summary>
    /// Geschwindigkeit des Verfolgers
    /// </summary>
    [Tooltip("Geschwindigkeit")]
    [Range(1.0F, 20.0F)]
    public float speed = 10.0F;
	
	/// <summary>
	/// Die Bewegung erfolgt, falls dieser logische Wert true ist.
	/// </summary>
	[Tooltip("Soll sich der Verfolger sofort bewegen, ohne Button Click?")]
	public bool Move = false;
    
    /// <summary>
    /// Das GameObject des verfolgten Wand in der Hierarchie
    /// </summary>
    private GameObject player;
    
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
    /// Instanz einesLog4Net Loggers
    /// </summary>
    private static readonly log4net.ILog Logger 
	    = log4net.LogManager.GetLogger(typeof(FollowTheWandWithLogs));
    
    /// <summary>
    /// Sicherstellen, dass der MiddleVR-Device-Manager gefunden wir
    /// und Abfragen des GameObjects für den Wand.
    /// </summary>
    /// <remarks>
    /// Der Name des GameObjects für einen Wand ist "MVRWand".
    /// </remarks>
    private void Awake()
    {
	    if (MVR.DeviceMgr != null)
		    m_Manager = MVR.DeviceMgr;
	    else
	    {
		    MVRTools.Log("MiddleVR Device Manager nicht gefunden!");
		    return;
	    }
	    
	    player = GameObject.Find("MVRWand");
	    if (player == null)
		    Debug.LogError("Kein Wand in der MiddleVR-Konfiguration gefunden");
    }

    /// <summary>
    /// Abfragen, ob der primary button des Wand gedrückt ist.
    /// <summary>
    private void Udate()
    {
	    if (m_Manager.IsWandButtonPressed(button))
		    m_Go();
	    else
		    m_Stop();
    }
    /// <summar<>
    /// Bewegung in LateUpdate
    /// 
    /// Erster Schritt: Abfragen, ob eine Bewegung erfolgen soll.
    /// Zweiter Schritt: Position und Orientierung neu setzen.
    /// </summary>
    private void LateUpdate()
    {
	    if (!Move)
		    return;

	    var source = transform.position;
	    var target = player.transform.position;

	    // Schrittweite
	    var stepSize = speed * Time.deltaTime;
	    // Neue Position berechnen
	    transform.position = Vector3.MoveTowards(source, target, stepSize);
	    // Orientieren mit FollowTheTarget - wir "schauen" auf das verfolgte Objekt
	    transform.LookAt(player.transform);
	    
	    object[] args =
	    {
		    gameObject.name,
		    gameObject.transform.position.x,
		    gameObject.transform.position.y,
		    gameObject.transform.position.z,
	    };
	    Logger.InfoFormat("{0}; {1}; {2}; {3}", args);
        
	    object[] args1 =
	    {
		    "MiddleVR Wand",
		    target.x,
		    target.y,
		    target.z
	    };
	    Logger.InfoFormat("{0}; {1}; {2}; {3}", args1);
    }
    
    /// <summary>
    /// Bewegung aktivieren
    /// </summary>
    private void m_Go()
    {
	    Move = true;
    }
    
    /// <summary>
    /// Bewegung de-aktivieren
    /// </summary>
    private void m_Stop()
    {
	    Move = false;
    }
}
