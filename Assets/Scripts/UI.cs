using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Unity UI Module
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Classe
    // 1、Canvas：Element that can be used for screen rendering.
    public Canvas Canvas;
    
    // 2、CanvasGroup：A Canvas placable element that can be used to modify children Alpha, Raycasting, Enabled state.
    public CanvasGroup CanvasGroup;
    
    // 3、CanvasRenderer：A component that will render to the screen after all normal rendering has completed when attached to a Canvas. Designed for GUI application.
    public CanvasRenderer CanvasRenderer;
    
    // 4、RectTransformUtility：Utility class containing helper methods for working with RectTransform.
    public RectTransformUtility RectTransformUtility;


    // Enumeration
    // 1、AdditionalCanvasShaderChannels：Enum mask of possible shader channel properties that can also be included when the Canvas mesh is created.
    public AdditionalCanvasShaderChannels AdditionalCanvasShaderChannels;
    
    // 2、RenderMode：RenderMode for the Canvas.
    public RenderMode RenderMode;

}
