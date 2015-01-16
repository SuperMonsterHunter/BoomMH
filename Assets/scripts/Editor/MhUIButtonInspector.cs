using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(MhUIButton), true)]
public class VilleNGUIButtonInspector : UIButtonEditor {
	
	protected override void DrawProperties ()
	{
		base.DrawProperties();
		NGUIEditorTools.DrawPaddedProperty ("BtnUIType", serializedObject, "m_btnUIType");
	}
}
