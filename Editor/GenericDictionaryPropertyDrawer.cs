using UnityEditor;
using UnityEngine;

namespace LongMan.GameUtil.Editors
{
    /// <summary>
    /// Original Source: https://github.com/upscalebaby/generic-serializable-dictionary
    /// Draws the generic dictionary a bit nicer than Unity would natively (not as many expand-arrows
    /// and better spacing between KeyValue pairs). Also renders a warning-box if there are duplicate
    /// keys in the dictionary.
    /// </summary>
    [CustomPropertyDrawer(typeof(GenericDictionary<,>))]
    public class GenericDictionaryPropertyDrawer : PropertyDrawer
    {
        static float lineHeight = EditorGUIUtility.singleLineHeight;
        static float vertSpace = EditorGUIUtility.standardVerticalSpacing;

        public override void OnGUI(Rect pos, SerializedProperty property, GUIContent label)
        {
            // Draw list.
            var list = property.FindPropertyRelative("list");
            string fieldName = ObjectNames.NicifyVariableName(fieldInfo.Name);
            var currentRect = new Rect(lineHeight, pos.y, pos.width, lineHeight);
            EditorGUI.PropertyField(currentRect, list, new GUIContent(fieldName), true);

            // Draw key collision warning.
            if (property.FindPropertyRelative("keyCollision").boolValue)
            {
                currentRect.y += EditorGUI.GetPropertyHeight(list, true) + vertSpace;
                var entryPos = new Rect(lineHeight, currentRect.y, pos.width, lineHeight * 2f);
                EditorGUI.HelpBox(entryPos, "Duplicate keys will not be serialized.", MessageType.Warning);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float totHeight = 0f;

            // Height of KeyValue list.
            var listProp = property.FindPropertyRelative("list");
            totHeight += EditorGUI.GetPropertyHeight(listProp, true);

            // Height of key collision warning.
            if (property.FindPropertyRelative("keyCollision").boolValue)
                totHeight += lineHeight * 2f + vertSpace;

            return totHeight;
        }
    }
}