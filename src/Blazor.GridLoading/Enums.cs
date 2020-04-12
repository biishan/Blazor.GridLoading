using System.ComponentModel;

namespace Blazor.GridLoading
{
    /// <summary>
    /// Enum - Animation Type
    /// </summary>
    public enum AnimationType
    {
        /// <summary>
        /// None.
        /// </summary>
        [Description("")]
        None,
        /// <summary>
        /// Fade In.
        /// </summary>
        [Description("gl-animated gl-fadeIn")]
        FadeIn,
        /// <summary>
        /// Flash.
        /// </summary>
        [Description("gl-animated gl-flash")]
        Flash,
        /// <summary>
        /// Pulse.
        /// </summary>
        [Description("gl-animated gl-pulse")]
        Pulse
    }
}