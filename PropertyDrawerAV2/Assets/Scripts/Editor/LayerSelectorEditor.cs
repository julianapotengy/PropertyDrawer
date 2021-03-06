﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using System.Linq;

[CustomPropertyDrawer(typeof(LayerSelectorAttribute))]
public class LayerSelectorEditor : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType == SerializedPropertyType.Integer)
        {
            Rect popupRect = new Rect(position.x, position.y, position.width, position.height);
            int index = System.Array.IndexOf(InternalEditorUtility.layers, LayerMask.LayerToName(property.intValue));
            // add layer
            var options = InternalEditorUtility.layers.ToList();
            options.Add("");
            options.Add("Add Layer...");
            index = EditorGUI.Popup(popupRect, "Layers: ", index, options.ToArray());

            // change and save
            if (index == options.Count - 1)
            {
                var a = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0];
                Selection.activeObject = a;
            }
            else
            {
                string layerName = InternalEditorUtility.layers[index];
                property.intValue = LayerMask.NameToLayer(layerName);
            }
        }
    }
}
