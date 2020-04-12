using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Blazor.GridLoading
{
    /// <summary>
    /// Grid Loading Base.
    /// </summary>
    public class GridLoadingBase : ComponentBase
    {
        #region Parameters

        /// <summary>
        /// Specify column names.
        /// </summary>
        [Parameter] public List<string> ColumnNames { get; set; }
        private int _rowCount;
        /// <summary>
        /// Specify total amount of rows to display.
        /// </summary>
        [Parameter] public int RowCount
        {
            get => _rowCount;
            set
            {
                if (value > 0)
                    _rowCount = value;
            }
        }
        /// <summary>
        /// Specify whether it should render in dark mode or not.
        /// </summary>
        [Parameter] public bool IsDarkMode { get; set; }
        /// <summary>
        /// Specify animation type. If not specified, default is set to "Pulse" animation.
        /// </summary>
        [Parameter] public AnimationType AnimationType { get; set; } = AnimationType.Pulse;
        /// <summary>
        /// Specify animation duration in seconds. If not specified, default is set to "3" seconds.
        /// </summary>
        [Parameter] public int AnimationDuration { get; set; } = 3;
        /// <summary>
        /// Specify animation iteration count. If not specified, default is set to "infinite".
        /// </summary>
        [Parameter] public string AnimationIterationCount { get; set; } = "infinite";

        #endregion

        #region Initialization

        /// <summary>
        /// Checks whether "ColumnNames" parameter is null or empty.
        /// </summary>
        protected internal bool _isColNamesNullOrEmpty
        {
            get => (ColumnNames == null || ColumnNames.Count < 1);
        }
        /// <summary>
        /// Column size.
        /// </summary>
        protected internal string _columnSize
        {
            get
            {
                return (new string[] { "25%!important;", "50%!important;", "75%!important;", "100%!important;" })[new Random().Next(4)];
            }
        }
        /// <summary>
        /// Table css.
        /// </summary>
        protected internal string _tableCss
        {
            get => IsDarkMode ? "gl-table gl-table-sm gl-table-dark" : "gl-table gl-table-sm";
        }
        protected internal string _animationType
        {
            get
            {
                var type = AnimationType.GetType();
                var name = Enum.GetName(type, AnimationType);
                if (name != null)
                {
                    var fieldInfo = type.GetField(name);
                    if (fieldInfo != null)
                    {
                        DescriptionAttribute attr =
                               Attribute.GetCustomAttribute(fieldInfo,
                                 typeof(DescriptionAttribute)) as DescriptionAttribute;
                        if (attr != null)
                        {
                            return attr.Description;
                        }
                    }
                }
                return null;
            }
        }
        /// <summary>
        /// Animation duration.
        /// </summary>
        protected internal string _animationDuration
        {
            get => $"{AnimationDuration}s";
        }

        #endregion
    }
}