using UnityEditor;

namespace RR.Serialization
{
    public static class PropertyDrawerUtility
    {
        public static int GetChildrenSize(SerializedProperty property)
        {
            if (!property.hasChildren)
            {
                return 1;
            }

            if (property.isArray)
            {
                return property.isExpanded ? property.arraySize : 1;
            }       

            if (!property.isExpanded)
            {
                return 1;
            }

            SerializedProperty clone = property.Copy();

            return clone.CountInProperty();
        }
    }
}