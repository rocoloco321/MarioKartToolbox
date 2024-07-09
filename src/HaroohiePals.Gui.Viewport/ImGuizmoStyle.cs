using OpenTK.Mathematics;

namespace HaroohiePals.Gui.Viewport;

class ImGuizmoStyle
{
    /// <summary>
    /// Colors of the various controls. Access using <see cref="ImGuizmoColor"></see>.
    /// </summary>
    public Color4[] Colors =
    [
        //Colors[DIRECTION_X]
        new Color4(0.666f, 0.000f, 0.000f, 1.000f),
        //Colors[DIRECTION_Y]
        new Color4(0.000f, 0.666f, 0.000f, 1.000f),
        //Colors[DIRECTION_Z]
        new Color4(0.000f, 0.000f, 0.666f, 1.000f),
        //Colors[PLANE_X]
        new Color4(0.666f, 0.000f, 0.000f, 0.380f),
        //Colors[PLANE_Y]
        new Color4(0.000f, 0.666f, 0.000f, 0.380f),
        //Colors[PLANE_Z]
        new Color4(0.000f, 0.000f, 0.666f, 0.380f),
        //Colors[SELECTION]
        new Color4(1.000f, 0.500f, 0.062f, 0.541f),
        //Colors[INACTIVE]
        new Color4(0.600f, 0.600f, 0.600f, 0.600f),
        //Colors[TRANSLATION_LINE]
        new Color4(0.666f, 0.666f, 0.666f, 0.666f),
        //Colors[SCALE_LINE]
        new Color4(0.250f, 0.250f, 0.250f, 1.000f),
        //Colors[ROTATION_USING_BORDER]
        new Color4(1.000f, 0.500f, 0.062f, 1.000f),
        //Colors[ROTATION_USING_FILL]
        new Color4(1.000f, 0.500f, 0.062f, 0.500f),
        //Colors[HATCHED_AXIS_LINES]
        new Color4(0.000f, 0.000f, 0.000f, 0.500f),
        //Colors[TEXT]
        new Color4(1.000f, 1.000f, 1.000f, 1.000f),
        //Colors[TEXT_SHADOW]
        new Color4(0.000f, 0.000f, 0.000f, 1.000f),
        //Colors[LOCAL_BOUNDS]
        new Color4(0.666f, 0.666f, 0.666f, 1.000f),
        //Colors[LOCAL_BOUNDS_DISABLED]
        new Color4(0.666f, 0.666f, 0.666f, 0.500f),
        //Colors[LOCAL_BOUNDS_CIRCLE_BORDER]
        Color4.Black
    ];
    /// <summary>
    /// Thickness of lines for translation gizmo
    /// </summary>
    public float TranslationLineThickness = 3f;
    /// <summary>
    /// Size of arrow at the end of lines for translation gizmo
    /// </summary>
    public float TranslationLineArrowSize = 6f;
    /// <summary>
    /// Thickness of lines for rotation gizmo
    /// </summary>
    public float RotationLineThickness = 2f;
    /// <summary>
    /// Thickness of line surrounding the rotation gizmo
    /// </summary>
    public float RotationOuterLineThickness = 3f;
    /// <summary>
    /// Thickness of lines for scale gizmo
    /// </summary>
    public float ScaleLineThickness = 3f;
    /// <summary>
    /// Size of circle at the end of lines for scale gizmo
    /// </summary>
    public float ScaleLineCircleSize = 6f;
    /// <summary>
    /// Thickness of hatched axis lines
    /// </summary>
    public float HatchedAxisLineThickness = 6f;
    /// <summary>
    /// Size of circle at the center of the translate/scale gizmo
    /// </summary>
    public float CenterCircleSize = 6f;
    /// <summary>
    /// Size of the big circles of the local bounds gizmo
    /// </summary>
    public float LocalBoundsLineThickness = 2f;
    /// <summary>
    /// Border thickness of the circles of the local bounds gizmo
    /// </summary>
    public float LocalBoundsAnchorBorderLineThickness = 1.2f;
    /// <summary>
    /// Size of the big circles of the local bounds gizmo
    /// </summary>
    public float LocalBoundsAnchorBigRadius = 8f;
    /// <summary>
    /// Size of the small circles of the local bounds gizmo
    /// </summary>
    public float LocalBoundsAnchorSmallRadius = 6f;
}
