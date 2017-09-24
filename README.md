# PropertyDrawer

## Fazer o TagSelector PropertyDrawer

- MonoBehaviour com um campo string myTag;
- TagSelectorAttribute;
- TagSelectorDrawer (pasta Editor);

Ao invés de aparecer um campo texto, é um menu popup com as tags da unity pra escolher

(EditorGUI.Popup(...);)

UnityEditorInternal.InternalEditorUtility.tags

## Extras

Não dar erro caso use o atributo em fields de outro tipo (que nao seja string)

Fazer o LayerSelector PropertyDrawer
