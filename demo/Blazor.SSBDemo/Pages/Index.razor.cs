using Blazor.GridLoading;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Blazor.SSBDemo.Pages
{
    public class IndexBase : ComponentBase
    {
        protected int _rowCount = 5;
        protected bool _isDarkMode = false;
        protected List<string> _columnNames = new List<string> { "#", "First", "Last", "Handle", "Is Online" };
        protected int _animationDuration = 2;
        protected AnimationType _animationType = AnimationType.Flash;

        private string _animationTypeString;
        protected string AnimationTypeString
        {
            get => _animationTypeString;
            set
            {
                foreach (var animationType in _animationTypes)
                {
                    if (animationType.GetDescription() == value)
                    {
                        _animationTypeString = value;
                        _animationType = animationType;
                        break;
                    }
                }
            }
        }
        protected List<AnimationType> _animationTypes = new List<AnimationType> { AnimationType.FadeIn, AnimationType.Pulse, AnimationType.Flash };
    }

    public static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
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
}